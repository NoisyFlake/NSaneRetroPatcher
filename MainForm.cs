using System.Diagnostics;

namespace NSaneRetroPatcher;

public partial class MainForm : Form {
    private readonly LevelSelectForm levelSelect;

    public MainForm() {
        InitializeComponent();

        ActiveControl = pictureBox1;

        levelSelect = new LevelSelectForm();
        UpdateLevelSelectButtonText();

        string? installFolder = Patcher.FindNSaneTrilogy();
        if (installFolder != null) {
            directory.Text = installFolder;
        }
    }

    private void ChoseDirectory_Click(object sender, EventArgs e) {
        FolderBrowserDialog dialog = new FolderBrowserDialog {
            ShowNewFolderButton = false
        };

        DialogResult result = dialog.ShowDialog();
        if (result == DialogResult.OK) {
            directory.Text = dialog.SelectedPath;
        }
    }

    private void Directory_TextChanged(object sender, EventArgs e) {
        if (Directory.Exists(directory.Text + "\\archives")) {
            directoryStatus.Text = "✔ This is a valid N. Sane Trilogy directory";
            directoryStatus.ForeColor = SystemColors.ControlText;
            UpdateStartPatchingButtonStatus();
        } else {
            directoryStatus.Text = "✖ This is not a valid N. Sane Trilogy directory";
            directoryStatus.ForeColor = Color.Red;
            UpdateStartPatchingButtonStatus();
        }
    }

    private void StartPatching_Click(object sender, EventArgs e) {
        ToggleElements(false);

        ProgressLabel.Visible = true;

        string dir = directory.Text + "\\archives";
        bool patchPSX = versionPsx.Checked;

        List<Level> levels = Level.AllLevels();
        List<string> levelNamesToPatch = levelSelect.GetSelectedLevelNames();
        levels.RemoveAll(level => !levelNamesToPatch.Contains(level.PakName));

        Patcher.Patch(dir, levels, patchPSX, this);
    }

    private void ToggleElements(bool enabled) {
        directory.Enabled = enabled;
        directorySelect.Enabled = enabled;
        directoryStatus.Enabled = enabled;
        versionPsx.Enabled = enabled;
        versionNsane.Enabled = enabled;
        startPatching.Enabled = enabled;

        Progress.Visible = !enabled;
    }

    public void SetProgress(int percentage, string status) {
        Progress.Value = percentage;
        ProgressLabel.Text = status;
        ProgressLabel.ForeColor = SystemColors.ControlText;

        if (percentage == 100) {
            ToggleElements(true);
            ProgressLabel.ForeColor = Color.Green;
        }
    }

    private void UpdateStartPatchingButtonStatus() {
        startPatching.Enabled = (Directory.Exists(directory.Text + "\\archives")) && levelSelect.GetSelectedLevelNames().Count > 0;
    }

    private void UpdateLevelSelectButtonText() {
        int count = levelSelect.GetSelectedLevelNames().Count;

        levelSelectButton.Text = "Select Levels to Patch\n(" + count + " selected)";
        levelSelectButton.ForeColor = count > 0 ? SystemColors.ControlText : Color.Red;
    }

    private void LevelSelection_Click(object sender, EventArgs e) {
        levelSelect.ShowDialog();

        UpdateLevelSelectButtonText();
        UpdateStartPatchingButtonStatus();
    }
}
