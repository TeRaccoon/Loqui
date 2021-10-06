using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Net;

namespace Loqui.src.dataHandling
{

    class uploadData
    {
        public uploadData()
        {
            //Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //IPEndPoint destinationEndPoint = new IPEndPoint(IPAddress.Parse("192.168.56.101"), Convert.ToInt32(50920));

            //try
            //{
            //    socket.Connect(destinationEndPoint);
            //    MessageBox.Show("Connection to server succesful");
            //}
            //catch
            //{
            //    MessageBox.Show("Failed to connect to server");
            //}
        }

        // Tests if the server is online 
        public void PingServerTest()
        {
            Ping pingObj = null;

            try
            {
                pingObj = new Ping();
                PingReply reply = pingObj.Send("192.168.56.101");

                MessageBox.Show("Success");

            }
            catch (PingException)
            {
                MessageBox.Show("Failed");
            }
            finally
            {
                if (pingObj != null)
                {
                    pingObj.Dispose();
                }
            }
        }
    }
}
