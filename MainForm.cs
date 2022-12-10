using System.Diagnostics;

namespace NSaneRetroPatcher;

public partial class MainForm : Form {

    public MainForm() {
        InitializeComponent();

        ActiveControl = pictureBox1;

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
            startPatching.Enabled = true;
        } else {
            directoryStatus.Text = "✖ This is not a valid N. Sane Trilogy directory";
            directoryStatus.ForeColor = Color.Red;
            startPatching.Enabled = false;
        }
    }

    private void StartPatching_Click(object sender, EventArgs e) {
        ToggleElements(false);

        ProgressLabel.Visible = true;

        string dir = directory.Text + "\\archives";
        Patcher.Patch(dir, this);
    }

    private void ToggleElements(bool enabled) {
        directory.Enabled = enabled;
        directorySelect.Enabled = enabled;
        directoryStatus.Enabled = enabled;
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
}
