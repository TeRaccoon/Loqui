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

namespace Loqui
{
    public partial class login : Form
    {
        // Creates design Object
        Design design = new Design();

        public login()
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

            // checks if its login page or the create account page 
            if (login_btn.Text == "Login")
            {
                //Retrieve data from server (Reads login file)
                string[] loginData = File.ReadAllLines(@"dat/login_data.txt");
                try
                {
                    // Creates byte array of password for hashing
                    byte[] data  = ASCIIEncoding.ASCII.GetBytes(password);
                    byte[] result;

                    

                    // Computes SHA512 and saves output to result 
                    result = shaMgr.ComputeHash(data);

                    // Finds inxed Value of usernames in login_data
                    int index = Array.IndexOf(loginData, Encryption.Encrypt(7, 8, 4, username));

                    // If the converted Hashed result matches the password -->  login == SUCCESS
                    if (Convert.ToBase64String(result) == File.ReadAllLines(@"dat/password_data.txt")[index])
                    {
                        // Open menu Form
                        src.menu.Menu menu = new src.menu.Menu();
                        menu.Show();
                    }
                }
                catch
                {
                    // messesage Box for unsuccessful loging attempt 
                    MessageBox.Show("Username not found or password incorrect !", "Login Error",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            // if create account button was presses the following else statment is executed 
            else
            {
                // Read usernames in login_data
                string[] usernames = File.ReadAllLines(@"dat/login_data.txt");

                // checks if username already exists
                if (usernames.Contains(Encryption.Encrypt(7, 8, 4, username_txt.Text)))
                {
                    MessageBox.Show("Username already exists", "Create Account Error",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                // else create the new user
                else
                {
                    // Creates byte array of password for hashing
                    byte[] data = ASCIIEncoding.ASCII.GetBytes(password_txt.Text);
                    byte[] result;

                    // Computes SHA512 and saves output to result 
                    result = shaMgr.ComputeHash(data);

                    // Converts password Byte Array to Base64 String 
                    String[] uploadUser = { username_txt.Text, Convert.ToBase64String(result) };
                    
                    // Encrypt Username
                    uploadUser[0] = Encryption.Encrypt(7, 8, 4, uploadUser[0]);

                    //Append username to login_data
                    File.AppendAllText(@"dat/login_data.txt", uploadUser[0] + Environment.NewLine);

                    // Append password to password_data
                    File.AppendAllText(@"dat/password_data.txt", uploadUser[1] + Environment.NewLine);
                }

                // Creates randombOj Manager
                Random randomMgr = new Random();

                // This will create the unique User ID tag
                string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                string userID = string.Empty;
                string[] userUIDs = File.ReadAllLines(@"dat/userUID.txt");
                bool validUID = false;

                while (!validUID)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        userID += characters[randomMgr.Next(0, characters.Length)];
                    }
                    if (!userUIDs.Contains(userID))
                    {
                        validUID = true;
                    }
                }

                File.AppendAllText(@"dat/userUID.txt", userID + Environment.NewLine);
                createUser.Close();
            }
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
            // Creates new instance of the login page 
            login createUser = new login();

            // Rename buttons
            createUser.title_lbl.Text = "Create Account";
            createUser.login_btn.Text = "Create";
            createUser.forgotPassword_btn.Visible = false;
            createUser.createAccount_btn.Visible = false;
            createUser.darkMode_check.Visible = false;


            // show new instance of form
            createUser.ShowDialog();
        }

        // Set dark mode if the checkbox is clicked 
        private void DarkModeCheck_CheckedChanged(object sender, EventArgs e)
        {
            // Calls changeDisplayMode() method
            design.changeDisplayMode(this, darkMode_check.Checked, @"resources/white_background.jpg", @"resources/black_background.jpg");
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
                login_btn.PerformClick();
                e.Handled = true;
            }
        }
    }
}
