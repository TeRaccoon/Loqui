using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Loqui
{
    class Design
    {
        /// <summary>
        /// This Function is called to invert the colour of contorls and set background image based on "bool darkMode";
        /// </summary>
        public void ChangeDisplayMode(Form form, bool darkMode, string lightModeBackground, string darkModeBackground)
        {
            if (darkMode)
            {
                // Set image to dark version 
                Image backgroundImage = new Bitmap(darkModeBackground);
                form.BackgroundImage = backgroundImage;

                // goes through all control items and inverts them 
                foreach (Control item in form.Controls)
                {
                    if (item.BackColor != Color.Transparent)
                    {
                        item.BackColor = Color.Black;
                    }
                    item.ForeColor = Color.White;
                }
            }
            else
            {
                // Set image to light version
                Image backgroundImage = new Bitmap(lightModeBackground);
                form.BackgroundImage = backgroundImage;

                // goes through all control items and inverts them 
                foreach (Control item in form.Controls)
                {
                    if (item.BackColor != Color.Transparent)
                    {
                        item.BackColor = Color.White;
                    }
                    item.ForeColor = Color.Black;
                }

            }
        }
        // This function contorls colour mode 
        public void ButtonColour(Button button, bool onLeave, bool checkedDarkMode)
        {
            // If checkbox clicked dark mode begins 
            if (checkedDarkMode)
            {
                // If mouse hovers over button change  
                if (!onLeave)
                {
                    button.BackColor = Color.FromArgb(80, 80, 80);
                }
                if (onLeave)
                {
                    button.BackColor = Color.Black;
                }

            }
        }
    }
}
