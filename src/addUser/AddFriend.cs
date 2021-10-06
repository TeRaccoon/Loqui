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

namespace Loqui.src.addUser
{
    public partial class AddFriend : Form
    {
        string UID;

        public AddFriend(string UID)
        {
            this.UID = UID;
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string[] userIDS = File.ReadAllLines(@"dat/userUID.txt");
            if (!userIDS.Contains(UID_txt.Text))
            {
                MessageBox.Show("Sorry, we could not find a user with this UID. Make sure you have entered it correctly - it is case sensitive!", "Could not find user", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Encryption encryption = new Encryption();
                int index = Array.IndexOf(userIDS, UID_txt.Text);
                string username = encryption.Decrypt(7, 8, 4, File.ReadAllLines(@"dat/login_data.txt")[index]);
                try
                {
                    File.WriteAllText(@"dat/" + UID_txt.Text + "/FriendRequests.txt", UID);
                    MessageBox.Show("You sent a friend request to " + username + "#" + UID_txt.Text + "!", "Friend Request Sent!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to log friend request! Please try again.", "Friend Request Failed Error #0002", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
