using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSaneRetroPatcher {
    public partial class LevelSelectForm : Form {
        public LevelSelectForm() {
            InitializeComponent();

            List<Level> allLevels = Level.AllLevels();

            int x = 28;
            int y = 152;

            for (int i = 1; i < allLevels.Count; i++) {
                Level level = allLevels[i];

                if (level.PakName == "L200_Hub") {
                    x = 257;
                    y = 152;
                }

                if (level.PakName == "L300_Hub") {
                    x = 481;
                    y = 152;
                }

                CheckBox checkbox = new() {
                    Checked = true,
                    CheckState = CheckState.Checked,
                    ForeColor = level.NeedsPSX ? Color.Firebrick : SystemColors.ControlText,
                    Location = new Point(x, y),
                    Name = level.PakName,
                    Size = new Size(137, 19),
                    TabIndex = 54,
                    Text = level.Name,
                    UseVisualStyleBackColor = true
                };

                this.Controls.Add(checkbox);

                y += 17;
            }
        }

        public List<String> GetSelectedLevelNames() {
            List<String> result = new List<String>();

            foreach (Control control in Controls) {
                if (control.GetType() == typeof(CheckBox)) {
                    CheckBox checkbox = (CheckBox)control;
                    if (checkbox.Checked) result.Add(checkbox.Name);
                }
            }

            return result;
        }

        private void checkAll(bool check) {
            foreach (Control control in Controls) {
                if (control.GetType() == typeof(CheckBox)) {
                    CheckBox checkbox = (CheckBox)control;
                    checkbox.Checked = check;
                }
            }
        }

        private void DeselectAll_Click(object sender, EventArgs e) {
            checkAll(false);
        }

        private void SelectAll_Click(object sender, EventArgs e) {
            checkAll(true);
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
