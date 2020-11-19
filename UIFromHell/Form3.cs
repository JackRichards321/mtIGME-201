using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIFromHell
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void duckClicked(object sender, EventArgs e)
        {
            duckPicture.Visible = false;
            crapLabel.Visible = true;
            //delayThread();
        }

        private void delayThread()
        {
            var thread = new Thread(() =>
            {
                Thread.Sleep(500);
                textUpdate1();
                Thread.Sleep(500);
                textUpdate2();
                imageUpdate();
            });
            thread.Start();
        }

        private void textUpdate1()
        {
            threadLabel.Text = "Wait, I can hear it! it's coming back!";
        }

        private void textUpdate2()
        {
            threadLabel.Text = "It's getting closer!";
        }

        private void imageUpdate()
        {
            duckPicture2.Visible = true;
        }
    }
}
