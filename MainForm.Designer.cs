namespace NSaneRetroPatcher;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.directory = new System.Windows.Forms.TextBox();
            this.directorySelect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.startPatching = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.directoryStatus = new System.Windows.Forms.Label();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.ProgressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 478);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(312, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Game Location";
            // 
            // directory
            // 
            this.directory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.directory.Location = new System.Drawing.Point(317, 215);
            this.directory.Name = "directory";
            this.directory.Size = new System.Drawing.Size(401, 29);
            this.directory.TabIndex = 3;
            this.directory.TextChanged += new System.EventHandler(this.Directory_TextChanged);
            // 
            // directorySelect
            // 
            this.directorySelect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.directorySelect.Location = new System.Drawing.Point(722, 215);
            this.directorySelect.Name = "directorySelect";
            this.directorySelect.Size = new System.Drawing.Size(53, 29);
            this.directorySelect.TabIndex = 4;
            this.directorySelect.Text = "...";
            this.directorySelect.UseVisualStyleBackColor = true;
            this.directorySelect.Click += new System.EventHandler(this.ChoseDirectory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(314, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Welcome to the N. Sane Retro Patcher!\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(314, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(432, 63);
            this.label3.TabIndex = 6;
            this.label3.Text = "This tool will replace the music from the N. Sane Trilogy with \r\nthe classic musi" +
    "c from the PlayStation 1 games, using the \r\noriginal pre-console mixes from Josh" +
    " Mancell.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(314, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(456, 63);
            this.label4.TabIndex = 7;
            this.label4.Text = "Because not every track is available as a pre-console version yet,\r\nthe compresse" +
    "d PS1 version will be used for those few tracks. \r\nWhen new pre-console versions" +
    " are released, they will be added.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(314, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Unavailable tracks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(312, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(378, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Please check if the detected game directory is correct.";
            // 
            // startPatching
            // 
            this.startPatching.Enabled = false;
            this.startPatching.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startPatching.Location = new System.Drawing.Point(317, 455);
            this.startPatching.Name = "startPatching";
            this.startPatching.Size = new System.Drawing.Size(458, 46);
            this.startPatching.TabIndex = 12;
            this.startPatching.Text = "Patch Game";
            this.startPatching.UseVisualStyleBackColor = true;
            this.startPatching.Click += new System.EventHandler(this.StartPatching_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(44, 507);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Version 2.1.0 - Developed by NoisyFlake";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // directoryStatus
            // 
            this.directoryStatus.AutoSize = true;
            this.directoryStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.directoryStatus.Location = new System.Drawing.Point(313, 249);
            this.directoryStatus.Name = "directoryStatus";
            this.directoryStatus.Size = new System.Drawing.Size(0, 15);
            this.directoryStatus.TabIndex = 14;
            // 
            // Progress
            // 
            this.Progress.Location = new System.Drawing.Point(317, 455);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(458, 46);
            this.Progress.TabIndex = 15;
            this.Progress.Visible = false;
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProgressLabel.Location = new System.Drawing.Point(313, 431);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(460, 23);
            this.ProgressLabel.TabIndex = 16;
            this.ProgressLabel.Text = "ProgressText";
            this.ProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProgressLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 529);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.directoryStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.startPatching);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.directorySelect);
            this.Controls.Add(this.directory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "N. Sane Retro Patcher";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private PictureBox pictureBox1;
    private Label label1;
    private TextBox directory;
    private Button directorySelect;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Button startPatching;
    private Label label7;
    private Label directoryStatus;
    private ProgressBar Progress;
    private Label ProgressLabel;
}
