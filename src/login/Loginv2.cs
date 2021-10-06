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
using System.Security.Cryptography;

//Local Namespaces
using Loqui.src.login.forgotPass;
using Loqui.src.login.createAcc;
using Loqui.src.design;

namespace Loqui
{
    public partial class Login : Form
    {
        // Creates design Object
        Design design = new Design();

        public Login()
        {
            InitializeComponent(); 
        }

        // Login Button Event
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            // Create encryption Object 
            Encryption Encryption = new Encryption();
            // Creates hash Manager Object
            SHA512 shaMgr = new SHA512Managed();

            // Get username 
            string username = username_txt.Text;
            // Get password
            string password = password_txt.Text;

            //Retrieve data from server (Reads Login file)
            string[] LoginData = File.ReadAllLines(@"dat/Login_data.txt");
            try
            {
                // Creates byte array of password for hashing
                byte[] data  = ASCIIEncoding.ASCII.GetBytes(password);
                byte[] result;

                    

                // Computes SHA512 and saves output to result 
                result = shaMgr.ComputeHash(data);

                // Finds inxed Value of usernames in Login_data
                int index = Array.IndexOf(LoginData, Encryption.Encrypt(7, 8, 4, username));

                // If the converted Hashed result matches the password -->  Login == SUCCESS
                if (Convert.ToBase64String(result) == File.ReadAllLines(@"dat/password_data.txt")[index])
                {
                    // Open menu Form
                    src.menu.Menu menu = new src.menu.Menu(GetLoggingUID(index));
                    menu.Show();
                }
            }
            catch
            {
                // messesage Box for unsuccessful Loging attempt 
                MessageBox.Show("Username not found or password incorrect !", "Login Error",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // This function will fetch the users UID based of the usernameIndex and return it 
        private string GetLoggingUID(int usernameIndex)
        {
            return File.ReadAllLines(@"dat/userUID.txt")[usernameIndex];
        }

        //Forgot password Button Event
        private void ForgotPasswordBtn_Click(object sender, EventArgs e)
        {
            ForgotPass forgotPass = new ForgotPass();
            forgotPass.Show();
        }

        // Create Account Button Event 
        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {

            CreateAccount createAccount = new CreateAccount();
            createAccount.Show();
          
        }

        // Set dark mode if the checkbox is clicked 
        private void DarkModeCheck_CheckedChanged(object sender, EventArgs e)
        {
            // Calls changeDisplayMode() method
            design.ChangeDisplayMode(this, darkMode_check.Checked, @"resources/white_background.jpg", @"resources/black_background.jpg");
        }
        
        // Functions for button highlighting in dark mode
        private void GeneralButtonLeave(object sender, EventArgs e)
        {
            design.ButtonColour(sender as Button, true, darkMode_check.Checked);
        }
        private void GeneralButtonEnter(object sender, EventArgs e)
        {
            design.ButtonColour(sender as Button, false, darkMode_check.Checked);
        }

        // Defults to usernamebox 
        private void Login_Shown(object sender, EventArgs e)
        {
            //Sets focus on username textbox
            username_txt.Focus();

            //Loops through each button and assigns a custom event function to MouseLeave, MouseEnter and MouseDown events
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    // Sets custom functions to events
                    control.MouseLeave += GeneralButtonLeave;
                    control.MouseEnter += GeneralButtonEnter;
                }
            }
        }

        // Suppress system sound on enter key event 
        private void username_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                password_txt.Focus();
                e.SuppressKeyPress = true;
            }
        }

        // Press Enter key to submit username/Password Event
        private void password_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                Login_btn.PerformClick();
                e.Handled = true;
            }
        }

        // Check box to see password 
        private void showPassword_check_CheckedChanged(object sender, EventArgs e)
        {
            password_txt.UseSystemPasswordChar = !showPassword_check.Checked;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            Animate animate = new Animate();
            animate.SetAnimationLabel(title_lbl);
            animate.AnimateLabel(this, "Loqui Login");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Animate animate = new Animate();
            animate.SetAnimationLabel(title_lbl);
            animate.AnimateLabel(this, "Loqui Login");
        }
    }
}
