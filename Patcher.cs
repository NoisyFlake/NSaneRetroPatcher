using igArchiveLib;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO.Compression;
using System.Runtime.CompilerServices;
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

    public async static void Patch(string archivesPath, MainForm form) {
        string? pre = null;
        #if DEBUG
                pre = "..\\..\\..\\";
        #endif

        string music = pre + "music";
        string pakPath = archivesPath + "\\update.pak";

        form.SetProgress(0, "Patching: " + 0 + "% done");

        igArchive archive = new igArchive();
        archive.createFromDirectory(pakPath, Path.GetFullPath(music), (igArchive.CompressionType)0, PercentageReport: (percentage) => {
            int percent = (int)(percentage * 100f);
            form.SetProgress(percent, "Patching: " + percent + "% done");
        });
        archive.close();

        form.SetProgress(100, "Patching done, enjoy. You can now close the application.");
    }
}