using Microsoft.Win32;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace NSaneRetroPatcher;

static class Patcher
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]

    static void Main() {
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }

    public static string? FindNSaneTrilogy() {
        RegistryKey? steamKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\Valve\\Steam");
        string? steamPath = steamKey?.GetValue("InstallPath")?.ToString();

        string libraryFolders = steamPath + "/steamapps/libraryfolders.vdf";
        if (File.Exists(libraryFolders)) {
            string[] configLines = File.ReadAllLines(libraryFolders);

            List<string>? steamLibraries = new List<string>();

            foreach (var item in configLines) {
                Match match = Regex.Match(item, @"[A-Z]:\\");
                if (item != string.Empty && match.Success) {
                    string matched = match.ToString();
                    string item2 = item.Substring(item.IndexOf(matched));
                    item2 = item2.Replace("\\\\", "\\");
                    item2 = item2.Replace("\"", "");
                    steamLibraries.Add(item2);
                }
            }

            foreach (string folder in steamLibraries) {
                string path = folder + "\\steamapps\\common\\Crash Bandicoot - N Sane Trilogy";
                if (Directory.Exists(path)) return path;
            }
        }

        return null;
    }

    async public static void Patch(string Path, List<Level> levels, Boolean PatchPSX, MainForm form) {
        File.WriteAllText("log.txt", String.Empty);

        for (int index = 0; index < levels.Count; index++) {
            Level level = levels[index];
            string progressText = "Patching Level " + (index + 1) + " / " + levels.Count + ": " + level.Name;
            double percentage = index / (double)levels.Count * 100;
            int percentageInt = (int)Math.Ceiling(percentage);

            form.SetProgress(percentageInt, progressText);

            if (level.NeedsPSX && PatchPSX) {
                await PatchLevel(Path + "\\" + level.PakName + ".pak", true);
            }

            await PatchLevel(Path + "\\" + level.PakName + ".pak", false);
        }

        form.SetProgress(100, "Patching done, enjoy. You can now close the application.");
    }

    async private static Task PatchLevel(string LevelPath, bool PSX) {
        Process quickbms = new Process();
        quickbms.StartInfo.CreateNoWindow = true;
        quickbms.StartInfo.UseShellExecute = false;
        quickbms.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        quickbms.StartInfo.RedirectStandardOutput = true;
        quickbms.StartInfo.RedirectStandardError = true;

        string? pre = null;
        #if DEBUG
                pre = "..\\..\\..\\";
        #endif

        string tool = pre + "vendor\\quickbms.exe";
        string script = pre + "vendor\\nsanetrilogy.bms";
        string music = pre + "music" + "\\" + (PSX ? "psx" : "preconsole");

        quickbms.StartInfo.FileName = tool;
        quickbms.StartInfo.Arguments = "-w -r -r " + script + " \"" + LevelPath + "\" " + music;

        File.AppendAllText("log.txt", "Command: " + quickbms.StartInfo.FileName + " " + quickbms.StartInfo.Arguments + Environment.NewLine);

        quickbms.Start();
        await quickbms.WaitForExitAsync();

        // For whatever stupid reason, quickbms outputs its progress to stderr. An error is always displayed on the first line though, so only write it if one exists.
        string stderr = quickbms.StandardError.ReadToEnd();
        string firstErrorLine = stderr.Substring(0, stderr.IndexOf(Environment.NewLine));
        if (firstErrorLine.Contains("Error") || firstErrorLine.Contains("error")) File.AppendAllText("log.txt", firstErrorLine + Environment.NewLine);

        string stdout = quickbms.StandardOutput.ReadToEnd();
        File.AppendAllText("log.txt", stdout + Environment.NewLine);
    }
}