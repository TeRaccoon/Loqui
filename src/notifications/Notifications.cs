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

namespace Loqui.src.notifications
{
    public partial class Notifications : Form
    {
        string UID;

        public Notifications(string UID)
        {
            this.UID = UID;
            InitializeComponent();
        }

        private void Notifications_Load(object sender, EventArgs e)
        {
            if (!File.Exists(@"dat/" + UID + "/FriendRequests.txt"))
            {
                notifications_txt.Text = "You have no new notifications!";
            }
            else
            {
                Encryption encryption = new Encryption();
                string[] friendRequests = File.ReadAllLines(@"dat/" + UID + "/FriendRequests.txt");
                string[] UIDs = File.ReadAllLines(@"dat/userUID.txt");

                foreach (string userID in friendRequests)
                {
                    int index = Array.IndexOf(UIDs, userID);
                    notifications_txt.AppendText("You have a friend request from " + encryption.Decrypt(7, 8, 4, File.ReadAllLines(@"dat/login_data.txt")[index]) + Environment.NewLine);
                }
            }
        }
    }
}
