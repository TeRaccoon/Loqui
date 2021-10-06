using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Loqui.src.settings
{
    public partial class ProgramSettings : Form
    {
        int fileDialogCaller = 0;
        Form menu;
        public ProgramSettings(Form menu)
        {
            this.menu = menu;
            InitializeComponent();
            openFileDialog.Filter = "PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg";
        }

        public string GetLightBackground()
        {
            return File.ReadAllLines(@"dat\settings.txt")[0];
        }
        public string GetDarkBackground()
        {
            return File.ReadAllLines(@"dat\settings.txt")[1];
        }

        private void changeBackground_btn_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            if (fileDialogCaller == 0)
            {
                string[] settings = File.ReadAllLines(@"dat\settings.txt");
                fileDialogCaller = 1;
                settings[0] = openFileDialog.FileName;
                File.WriteAllLines(@"dat\settings.txt", settings);
                if (!darkMode_check.Checked)
                {
                    Image backgroundImage = new Bitmap(openFileDialog.FileName);
                    BackgroundImage = backgroundImage;
                    menu.BackgroundImage = backgroundImage;
                }
                openFileDialog.FileName = "DarkBackground";
            }
            else
            {
                string[] settings = File.ReadAllLines(@"dat\settings.txt");
                fileDialogCaller = 0;
                settings[1] = openFileDialog.FileName;
                File.WriteAllLines(@"dat\settings.txt", settings);
                if (darkMode_check.Checked)
                {
                    Image backgroundImage = new Bitmap(openFileDialog.FileName);
                    BackgroundImage = backgroundImage;
                    menu.BackgroundImage = backgroundImage;
                }
                openFileDialog.FileName = "LightBackground";
            }
        }

        private void darkMode_check_CheckedChanged(object sender, EventArgs e)
        {
            Design design = new Design();
            string[] backgrounds = File.ReadAllLines(@"dat\settings.txt");
            design.ChangeDisplayMode(this, darkMode_check.Checked, backgrounds[0], backgrounds[1]);
        }
    }
}
