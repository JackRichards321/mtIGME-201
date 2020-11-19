using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presidents
{
    public partial class PresidentsForm : Form 
    {
        public PresidentsForm()
        {
            InitializeComponent();
        }

        private void PresidentsForm_Load(object sender, EventArgs e)
        {
            timerBar.Value = 1200;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void presButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (harrisonRadio.Checked)
            {
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/Benjamin_Harrison");
                presImage.Image = Presidents.Properties.Resources.BenjaminHarrison;
            }
            else if (fdrRadio.Checked)
            {
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/Franklin_Roosevelt");
                presImage.Image = Presidents.Properties.Resources.FranklinDRoosevelt;
            }
            else if (clintonRadio.Checked)
            {
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/William_Clinton");
                presImage.Image = Presidents.Properties.Resources.WilliamJClinton;
            }
            else if (buchananRadio.Checked)
            {
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/James_Buchanan");
                presImage.Image = Presidents.Properties.Resources.JamesBuchanan;
            }
            else if (pierceRadio.Checked)
            {
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/Franklin_Pierce");
                presImage.Image = Presidents.Properties.Resources.FranklinPierce;
            }
            else if (bushRadio.Checked)
            {
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/George_W._Bush");
                presImage.Image = Presidents.Properties.Resources.GeorgeWBush;
            }
            else if (obamaRadio.Checked)
            {
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/Barack_Obama");
                presImage.Image = Presidents.Properties.Resources.BarackObama;
            }
            else if (kennedyRadio.Checked)
            {
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/John_Kennedy");
                presImage.Image = Presidents.Properties.Resources.JohnFKennedy;
            }
            else if (mckinleyRadio.Checked)
            {
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/William_McKinley");
                presImage.Image = Presidents.Properties.Resources.WilliamMcKinley;
            }
            else if (reaganRadio.Checked)
            {
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/Ronald_Reagan");
                presImage.Image = Presidents.Properties.Resources.RonaldReagan;
            }
            else if (eisenhowerRadio.Checked)
            {
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/Dwight_Eisenhower");
                presImage.Image = Presidents.Properties.Resources.DwightDEisenhower;
            }
            else if (burenRadio.Checked)
            {
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/Martin_VanBuren");
                presImage.Image = Presidents.Properties.Resources.MartinVanBuren;
            }
            else if (washingtonRadio.Checked)
            {
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/George_Washington");
                presImage.Image = Presidents.Properties.Resources.GeorgeWashington;
            }
            else if (adamsRadio.Checked)
            {
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/John_Adams");
                presImage.Image = Presidents.Properties.Resources.JohnAdams;
            }
            else if (teddyRadio.Checked)
            {
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/Theodore_Roosevelt");
                presImage.Image = Presidents.Properties.Resources.TheodoreRoosevelt;
            }
            else if (jeffersonRadio.Checked)
            {
                webBrowser.Url = new Uri("https://en.m.wikipedia.org/wiki/Thomas_Jefferson");
                presImage.Image = Presidents.Properties.Resources.ThomasJefferson;
            }

        }

        private void partyButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (allRadio.Checked)
            {
                harrisonRadio.Visible = true;
                fdrRadio.Visible = true;
                clintonRadio.Visible = true;
                buchananRadio.Visible = true;
                pierceRadio.Visible = true;
                bushRadio.Visible = true;
                obamaRadio.Visible = true;
                kennedyRadio.Visible = true;
                mckinleyRadio.Visible = true;
                reaganRadio.Visible = true;
                eisenhowerRadio.Visible = true;
                burenRadio.Visible = true;
                washingtonRadio.Visible = true;
                adamsRadio.Visible = true;
                teddyRadio.Visible = true;
                jeffersonRadio.Visible = true;
            } 
            else if (democratRadio.Checked)
            {
                harrisonRadio.Visible = false;
                fdrRadio.Visible = true;
                clintonRadio.Visible = true;
                buchananRadio.Visible = true;
                pierceRadio.Visible = true;
                bushRadio.Visible = false;
                obamaRadio.Visible = true;
                kennedyRadio.Visible = true;
                mckinleyRadio.Visible = false;
                reaganRadio.Visible = false;
                eisenhowerRadio.Visible = false;
                burenRadio.Visible = true;
                washingtonRadio.Visible = false;
                adamsRadio.Visible = false;
                teddyRadio.Visible = false;
                jeffersonRadio.Visible = false;
            }
            else if (republicanRadio.Checked)
            {
                harrisonRadio.Visible = true;
                fdrRadio.Visible = false;
                clintonRadio.Visible = false;
                buchananRadio.Visible = false;
                pierceRadio.Visible = false;
                bushRadio.Visible = true;
                obamaRadio.Visible = false;
                kennedyRadio.Visible = false;
                mckinleyRadio.Visible = true;
                reaganRadio.Visible = true;
                eisenhowerRadio.Visible = true;
                burenRadio.Visible = false;
                washingtonRadio.Visible = false;
                adamsRadio.Visible = false;
                teddyRadio.Visible = true;
                jeffersonRadio.Visible = true;
            }
            else if (drRadio.Checked)
            {
                harrisonRadio.Visible = false;
                fdrRadio.Visible = false;
                clintonRadio.Visible = false;
                buchananRadio.Visible = false;
                pierceRadio.Visible = false;
                bushRadio.Visible = false;
                obamaRadio.Visible = false;
                kennedyRadio.Visible = false;
                mckinleyRadio.Visible = false;
                reaganRadio.Visible = false;
                eisenhowerRadio.Visible = false;
                burenRadio.Visible = false;
                washingtonRadio.Visible = false;
                adamsRadio.Visible = false;
                teddyRadio.Visible = false;
                jeffersonRadio.Visible = true;
            } 
            else if (federalistRadio.Checked)
            {
                harrisonRadio.Visible = false;
                fdrRadio.Visible = false;
                clintonRadio.Visible = false;
                buchananRadio.Visible = false;
                pierceRadio.Visible = false;
                bushRadio.Visible = false;
                obamaRadio.Visible = false;
                kennedyRadio.Visible = false;
                mckinleyRadio.Visible = false;
                reaganRadio.Visible = false;
                eisenhowerRadio.Visible = false;
                burenRadio.Visible = false;
                washingtonRadio.Visible = true;
                adamsRadio.Visible = true;
                teddyRadio.Visible = false;
                jeffersonRadio.Visible = false;
            }
        }

        private void allRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void filterLabel_Click(object sender, EventArgs e)
        {

        }

        private void partyPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureEnter(object sender, EventArgs e)
        {
            presImage.Width = 250;
            presImage.Height = 381;
            presImage.BringToFront();
        }

        private void pictureLeave(object sender, EventArgs e)
        {
            presImage.Width = 124;
            presImage.Height = 189;
        }

        private void harrisonTextChange(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            int x = Int32.Parse(tb.Text);
            if (x != 23)
            {
                presError.SetError(harrisonText, "That is the wrong number.");
            }
            else if (x == 23)
            {
                presError.SetError(harrisonText, "");
            }

            // reset the timer if it is disabled
            if (!timer.Enabled)
            {
                timer.Enabled = true;
            }
        }

        private void fdrTextChange(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            int x = Int32.Parse(tb.Text);
            if (x != 32)
            {
                presError.SetError(fdrText, "That is the wrong number.");
            }
            else if (x == 32)
            {
                presError.SetError(fdrText, "");
            }


            // reset the timer if it is disabled
            if (!timer.Enabled)
            {
                timer.Enabled = true;
            }
        }

        private void clintonTextChange(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            int x = Int32.Parse(tb.Text);
            if (x != 42)
            {
                presError.SetError(clintonText, "That is the wrong number.");
            }
            else if (x == 42)
            {
                presError.SetError(clintonText, "");
            }

            // reset the timer if it is disabled
            if (!timer.Enabled)
            {
                timer.Enabled = true;
            }
        }

        private void buchananTextChange(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            int x = Int32.Parse(tb.Text);
            if (x != 15)
            {
                presError.SetError(buchananText, "That is the wrong number.");
            }
            else if (x == 15)
            {
                presError.SetError(buchananText, "");
            }

            // reset the timer if it is disabled
            if (!timer.Enabled)
            {
                timer.Enabled = true;
            }
        }

        private void pierceTextChange(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            int x = Int32.Parse(tb.Text);
            if (x != 14)
            {
                presError.SetError(pierceText, "That is the wrong number.");
            }
            else if (x == 14)
            {
                presError.SetError(pierceText, "");
            }

            // reset the timer if it is disabled
            if (!timer.Enabled)
            {
                timer.Enabled = true;
            }
        }

        private void bushTextChange(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            int x = Int32.Parse(tb.Text);
            if (x != 43)
            {
                presError.SetError(bushText, "That is the wrong number.");
            }
            else if (x == 43)
            {
                presError.SetError(bushText, "");
            }

            // reset the timer if it is disabled
            if (!timer.Enabled)
            {
                timer.Enabled = true;
            }
        }

        private void obamaTextChange(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            int x = Int32.Parse(tb.Text);
            if (x != 44)
            {
                presError.SetError(obamaText, "That is the wrong number.");
            }
            else if (x == 44)
            {
                presError.SetError(obamaText, "");
            }

            // reset the timer if it is disabled
            if (!timer.Enabled)
            {
                timer.Enabled = true;
            }
        }

        private void kennedyTextChange(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            int x = Int32.Parse(tb.Text);
            if (x != 35)
            {
                presError.SetError(kennedyText, "That is the wrong number.");
            }
            else if (x == 35)
            {
                presError.SetError(kennedyText, "");
            }

            // reset the timer if it is disabled
            if (!timer.Enabled)
            {
                timer.Enabled = true;
            }
        }

        private void mckinleyTextChange(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            int x = Int32.Parse(tb.Text);
            if (x != 25)
            {
                presError.SetError(mckinleyText, "That is the wrong number.");
            }
            else if (x == 25)
            {
                presError.SetError(mckinleyText, "");
            }

            // reset the timer if it is disabled
            if (!timer.Enabled)
            {
                timer.Enabled = true;
            }
        }

        private void reaganTextChange(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            int x = Int32.Parse(tb.Text);
            if (x != 40)
            {
                presError.SetError(reaganText, "That is the wrong number.");
            }
            else if (x == 40)
            {
                presError.SetError(reaganText, "");
            }

            // reset the timer if it is disabled
            if (!timer.Enabled)
            {
                timer.Enabled = true;
            }
        }

        private void eisenhowerTextChange(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            int x = Int32.Parse(tb.Text);
            if (x != 34)
            {
                presError.SetError(eisenhowerText, "That is the wrong number.");
            }
            else if (x == 34)
            {
                presError.SetError(eisenhowerText, "");
            }

            // reset the timer if it is disabled
            if (!timer.Enabled)
            {
                timer.Enabled = true;
            }
        }

        private void burenTextChange(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            int x = Int32.Parse(tb.Text);
            if (x != 8)
            {
                presError.SetError(burenText, "That is the wrong number.");
            }
            else if (x == 8)
            {
                presError.SetError(burenText, "");
            }

            // reset the timer if it is disabled
            if (!timer.Enabled)
            {
                timer.Enabled = true;
            }
        }

        private void washingtonTextChange(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            int x = Int32.Parse(tb.Text);
            if (x != 1)
            {
                presError.SetError(washingtonText, "That is the wrong number.");
            }
            else if (x == 1)
            {
                presError.SetError(washingtonText, "");
            }

            // reset the timer if it is disabled
            if (!timer.Enabled)
            {
                timer.Enabled = true;
            }
        }

        private void adamsTextChange(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            int x = Int32.Parse(tb.Text);
            if (x != 2)
            {
                presError.SetError(adamsText, "That is the wrong number.");
            } 
            else if (x == 2)
            {
                presError.SetError(adamsText, "");
            }

            // reset the timer if it is disabled
            if (!timer.Enabled)
            {
                timer.Enabled = true;
            }
        }

        private void teddyTextChange(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            int x = Int32.Parse(tb.Text);
            if (x != 26)
            {
                presError.SetError(teddyText, "That is the wrong number.");
            }
            else if (x == 26)
            {
                presError.SetError(teddyText, "");
            }

            // reset the timer if it is disabled
            if (!timer.Enabled)
            {
                timer.Enabled = true;
            }
        }

        private void jeffersonTextChange(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            int x = Int32.Parse(tb.Text);
            if (x != 3)
            {
                presError.SetError(jeffersonText, "That is the wrong number.");
            }
            else if (x == 3)
            {
                presError.SetError(jeffersonText, "");
            }

            // reset the timer if it is disabled
            if (!timer.Enabled)
            {
                timer.Enabled = true;
            }
        }

        private void timerDone(object sender, EventArgs e)
        {
            harrisonText.Text = "0";
            fdrText.Text = "0";
            clintonText.Text = "0";
            buchananText.Text = "0";
            pierceText.Text = "0";
            bushText.Text = "0";
            obamaText.Text = "0";
            kennedyText.Text = "0";
            mckinleyText.Text = "0";
            reaganText.Text = "0";
            eisenhowerText.Text = "0";
            burenText.Text = "0";
            washingtonText.Text = "0";
            adamsText.Text = "0";
            teddyText.Text = "0";
            jeffersonText.Text = "0";


        }

        private void tick(object sender, EventArgs e)
        {
            bool finished = Int32.Parse(harrisonText.Text) == 23 && Int32.Parse(fdrText.Text) == 32 && Int32.Parse(clintonText.Text) == 42 &&
                Int32.Parse(buchananText.Text) == 15 && Int32.Parse(pierceText.Text) == 14 && Int32.Parse(bushText.Text) == 43 &&
                Int32.Parse(obamaText.Text) == 44 && Int32.Parse(kennedyText.Text) == 35 && Int32.Parse(mckinleyText.Text) == 25 &&
                Int32.Parse(reaganText.Text) == 40 && Int32.Parse(eisenhowerText.Text) == 34 && Int32.Parse(burenText.Text) == 8 &&
                Int32.Parse(washingtonText.Text) == 1 && Int32.Parse(adamsText.Text) == 2 && Int32.Parse(teddyText.Text) == 26 &&
                Int32.Parse(jeffersonText.Text) == 3;

            if (finished)
            {
                timer.Stop();
                webBrowser.Url = new Uri("https://www.youtube.com/watch?v=18212B4yfLg");
            }
            else if (timerBar.Value > 0)
            {
                timerBar.Value -= 5;
            } 
            else if (timerBar.Value == 0 && !finished)
            {
                timerBar.Value = 1200;
                timer.Stop();
                exitBtn.Enabled = true;
            }
        }
    }
}
