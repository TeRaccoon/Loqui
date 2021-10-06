using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Loqui.src.design
{
    class Animate
    {
        Thread animationThread;
        Label label;

        public Animate()
        {
            //animationThread = new Thread(AnimateLabel)
            //{
            //    Name = "AnimationThread"
            //};
        }

        public void StartAnimationThread()
        {
            animationThread.Start();
        }

        public void SetAnimationLabel(Label label)
        {
            this.label = label;
        }

        public void AnimateLabel(Form form, string labelText)
        {
            string labelRestore = labelText;
            Random random = new Random();
            int[] animationArray = new int[labelRestore.Length];
            for (int i = 0; i < animationArray.Length - 1; i++)
            {
                int index = random.Next(0, labelRestore.Length);
                while (animationArray.Contains(index))
                {
                    index = random.Next(0, labelRestore.Length);
                }
                animationArray[i] = index;
            }

            char[] labelArray = new char[animationArray.Length];
            string spaces = string.Empty;

            for (int i = 0; i < animationArray.Length; i++)
            {
                labelArray[i] = ' ';
            }


            foreach (int index in animationArray)
            {
                labelArray[index] = labelRestore[index];
                string str = new string(labelArray);
                label.Text = str;
                form.Refresh();
                Thread.Sleep(random.Next(0, 200));
            }
            label.Text = labelRestore;
        }
    }
}
