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
using System.Threading;

//Local Namespaces
using Loqui.src.login.forgotPass;
using Loqui.src.login.createAcc;

namespace Loqui.src.login.createAcc
{
    public partial class CreateAccount : Form
    {
        
        public CreateAccount()
        {
            InitializeComponent();
        }

        // The create account button event 
        private void createAccount_btn_Click(object sender, EventArgs e)
        {
            // This if statment validates the username
            if (username_txt.Text == string.Empty || username_txt.Text.Contains(' ') || username_txt.Text.Length > 20)
            {
                MessageBox.Show("You know this username is invalid so stop trying to be funny", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!PasswordValidation(password_txt.Text))
            {

            }
            else
            {

                Encryption encryption = new Encryption();

                // Creates hash Manager Object
                SHA512 shaMgr = new SHA512Managed();

                // Read usernames in Login_data
                string[] usernames = File.ReadAllLines(@"dat/Login_data.txt");

                // checks if username already exists
                if (usernames.Contains(encryption.Encrypt(7, 8, 4, username_txt.Text)))
                {
                    MessageBox.Show("Username already exists", "Create Account Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    String[] uploadUser = { username_txt.Text, Convert.ToBase64String(result)};

                    // Encrypt Username
                    uploadUser[0] = encryption.Encrypt(7, 8, 4, uploadUser[0]);

                    //Append username to Login_data
                    File.AppendAllText(@"dat/Login_data.txt", uploadUser[0] + Environment.NewLine);

                    // Append password to password_data
                    File.AppendAllText(@"dat/password_data.txt", uploadUser[1] + Environment.NewLine);


                    // Creates randombOj Manager
                    Random randomMgr = new Random();

                    // This will create the unique User ID tag
                    string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                    string userID = string.Empty;
                    string[] userUIDs = File.ReadAllLines(@"dat/userUID.txt");
                    bool validUID = false;

                    // Keep trying to create userUID untill it is a unique one
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
                    // This will display the users UID that has just been generated
                    MessageBox.Show("Your unique user ID is " + userID + ". Please keep this safe! It is what you'll use to add friends.");
                    File.AppendAllText(@"dat/userUID.txt", userID + Environment.NewLine);
                    Directory.CreateDirectory(@"dat/" + userID);

                    // Releases all resources used by the System.ComponentModel.Component.
                    Dispose();
                }
            }
        }

        // This function is used to validate that the users password is strong enough
        private bool PasswordValidation(string data)
        {
            // Data used for validating the password 
            string punctuation = "#!£$%^&*()-_=+[{]};:@,<.>/?";
            string numbers = "1234567890";
            bool passed = false;
            int numCount = 0;
            int punctuationCount = 0;
            

            int passwordPoints = 0;
            
            // Following code will go through all the if statments to check the security of the password
            for (int i = 0; i < punctuation.Length; i++)
            {
                if (data.Contains(punctuation[i]))
                {
                    punctuationCount++;
                }
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (data.Contains(numbers[i]))
                {
                    numCount++;
                }
            }
            if (data.Length < 6)
            {
                passwordFeedback_lbl.Text = "Your password is too short (Needs to be at least 8 characters long)";
                passed = false;
                passwordPoints++;
            }
            if (data.Length > 6)
            {
                passwordFeedback_lbl.Text = "Your password doesn't contain enough numbers and special characters or is too short (Needs at least 1 number and 1 special character !)";
                passed = false;
                passwordPoints++;
            }
            if (data.Length > 6 && (punctuationCount > 0 || numCount > 0))
            {
                passwordFeedback_lbl.Text = "Your password doesn't contain enough numbers and special characters or is too short (Needs at least 1 number and 1 special character !)";
                passed = false;
                passwordPoints++;
            }
            
            if (data.Length > 8 && punctuationCount + numCount > 1)
            {
                passwordFeedback_lbl.Text = "Your password doesn't contain enough numbers and special characters or is too short (Needs at least 1 number and 1 special character !)";
                passed = false;
                passwordPoints++;
                passwordPoints++;
                passwordPoints++;
            }
            if (data.Length > 8 && punctuationCount >= 1 && numCount >= 1)
            {
                passwordFeedback_lbl.Text = "";
                passed = true;
                passwordPoints++;
                passwordPoints++;
                passwordPoints++;
                passwordPoints++;
                passwordPoints++;
            }

            /// <summary>
            /// WORK NEEDED
            /// </summary>

            // Displays the password strength in colour
            if (passwordPoints < 3)
            {
                pointScore_lbl.ForeColor = Color.Red;
                pointScore_lbl.Text += "Weak";
            }
            else if (passwordPoints < 4)
            {
                pointScore_lbl.ForeColor = Color.Orange;
                pointScore_lbl.Text += "OK";
            }
            else
            {
                pointScore_lbl.ForeColor = Color.Green;
                pointScore_lbl.Text += "Strong" + Environment.NewLine;
                pointScore_lbl.ForeColor = Color.Black;
                pointScore_lbl.Text += "Password Set";
            }
            Thread.Sleep(1000);
            pointScore_lbl.Text.Remove(0);
            passwordPoints = 0;
            // If the password is secure TRUE is returned
            return passed;
        }


        // Check box to see password 
        private void showPassword_check_CheckedChanged(object sender, EventArgs e)
        {
            password_txt.UseSystemPasswordChar = !showPassword_check.Checked;
        }

     
    }
}
