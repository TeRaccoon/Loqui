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

// Local Namespaces
using Loqui.src.settings;
using Loqui.src.addUser;
using Loqui.src.notifications;
using Loqui.src.dataHandling;

namespace Loqui.src.menu
{
    public partial class Menu : Form
    {
        // The logged in users Unique ID 
        string UID;

        public Menu(string UID)
        {
            this.UID = UID;
            InitializeComponent();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            // programSettings form is created 
            ProgramSettings programSettings = new ProgramSettings(this);

            // Show programSettings form
            programSettings.Show();
        }

        private void addFriend_img_Click(object sender, EventArgs e)
        {
            // addFriend form is created with the users UID
            AddFriend addFriend = new AddFriend(UID);

            // addFriend is shown
            addFriend.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            uploadData uploadDataMgr = new uploadData();
            uploadDataMgr.PingServerTest();

            // Checks if the user has any notfications 
            if (File.Exists(@"dat/" + UID + "/FriendRequests.txt"))
            {
                // Checks which mode of icon to show based on bool value of darkMode_checkD
                if (!darkMode_check.Checked)
                {
                    Image backgroundImage = new Bitmap(@"resources/icons/user_notif.png");
                    notification_img.BackgroundImage = backgroundImage;
                }
                if (darkMode_check.Checked)
                {
                    Image backgroundImagedark = new Bitmap(@"resources/icons/user_notif_White.png");
                    notification_img.BackgroundImage = backgroundImagedark;
                }

                
            }
        }
        /// <summary>
        /// This Function will chanage Contorls and Icons to dark mode or light mode depending on the bool value of darkMode_check.
        /// </summary>
        private void darkMode_check_CheckedChanged(object sender, EventArgs e)
        {
            // Checks if the user has any notfications 
            if (File.Exists(@"dat/" + UID + "/FriendRequests.txt"))
            {
                if (!darkMode_check.Checked)
                {
                    Image backgroundImage = new Bitmap(@"resources/icons/user_notif.png");
                    notification_img.BackgroundImage = backgroundImage;
                }
                if (darkMode_check.Checked)
                {
                    Image backgroundImagedark = new Bitmap(@"resources/icons/user_notif_White.png");
                    notification_img.BackgroundImage = backgroundImagedark;
                }
            }
            // Following block of if statments changes the icons 
            if (!darkMode_check.Checked)
            {
                Image backgroundImageBlankNotifLight = new Bitmap(@"resources/icons/user.png");
                notification_img.BackgroundImage = backgroundImageBlankNotifLight;
            }
            if (darkMode_check.Checked)
            {
                Image backgroundImageBlankNotifDark = new Bitmap(@"resources/icons/user_White.png");
                notification_img.BackgroundImage = backgroundImageBlankNotifDark;
            }
            if (!darkMode_check.Checked)
            {
                Image backgroundImageAddUserWhite = new Bitmap(@"resources/icons/addFriend.png");
                addFriend_img.BackgroundImage = backgroundImageAddUserWhite;
            }
            if (darkMode_check.Checked)
            {
                Image backgroundImageAddUserDark = new Bitmap(@"resources/icons/addFriend_White.png");
                addFriend_img.BackgroundImage = backgroundImageAddUserDark;
            }

            // design Object is created 
            Design design = new Design();

            ProgramSettings programSettings = new ProgramSettings(this);

            // Calls changeDisplayMode() method
            design.ChangeDisplayMode(this, darkMode_check.Checked, programSettings.GetLightBackground(), programSettings.GetDarkBackground());

        }


        private void notification_img_Click(object sender, EventArgs e)
        {
            // notifications form is created 
            Notifications notifications = new Notifications(UID);

            // Show notifications form
            notifications.Show();
        }
    }
}
