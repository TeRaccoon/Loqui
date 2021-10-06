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


namespace Loqui.src.login.forgotPass
{
    public partial class ForgotPass : Form
    {
        public ForgotPass()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            Encryption encryption = new Encryption();
            //Retrieve data from server (Reads login file)
            string[] usernames = File.ReadAllLines(@"dat/login_data.txt");
            // Gets username
            string username = username_txt.Text;
            username = encryption.Encrypt(7, 8, 4, username);
            // Gets password
            string password = password_txt.Text;
            // Gets password 2
            string passwordRepeat = passwordRepeat_txt.Text;

            if (password != passwordRepeat)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!usernames.Contains(username))
                {
                    MessageBox.Show("Username does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {   
                    // Creates hash Manager Object
                    SHA512 shaMgr = new SHA512Managed();

                    // Creates byte array of password for hashing
                    byte[] data = ASCIIEncoding.ASCII.GetBytes(password_txt.Text);
                    byte[] result;

                    // Computes SHA512 and saves output to result 
                    result = shaMgr.ComputeHash(data);

                    string[] passwords = File.ReadAllLines(@"dat/password_data.txt");

                    int index = Array.IndexOf(usernames, username);

                    passwords[index] = Convert.ToBase64String(result);
                    File.WriteAllLines(@"dat/password_data.txt", passwords);
                }
            }
        }
    }
}
