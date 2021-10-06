using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Loqui
{
    class DataHandling
    {
        private Dictionary<string, Dictionary<string, string>> messages = new Dictionary<string, Dictionary<string, string>>();

        public void StoreData(string username1, string username2, string sendingUsername, string message, DateTime timeStamp)
        {
            string key = username1 + username2;
            try
            {
                Dictionary<string, string> temp;
                if (messages.ContainsKey(sendingUsername))
                {
                    temp = messages[sendingUsername];
                }
                else
                {
                    temp = new Dictionary<string, string>();
                }
                temp.Add(sendingUsername, timeStamp + ": " + sendingUsername + Environment.NewLine + message + "u");
                if(messages.ContainsKey(key))
                {
                    messages[key] = temp;
                }
                else
                {
                    messages.Add(key, temp);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Dictionary loading error", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CheckForMessage(string username1, string username2, string sendingUsername, TextBox textBox)
        {
            try
            {
                string message = messages[username1 + username2][sendingUsername];
                if (message[message.Length - 1] == 'u')
                {
                    textBox.AppendText(messages[username1 + username2][sendingUsername] = message.Substring(0, message.Length - 1) + Environment.NewLine);
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
