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
    public partial class page1 : Form
    {
        bool cutitout = false;

        public page1()
        {
            InitializeComponent();
        }

        private void nameTextChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            int tester = random.Next(1, 50);
            if (tester % 2 == 0)
            {
                page1Panel.BackColor = Color.FromName("Red");
                nameLabel.ForeColor = Color.FromName("Blue");
                emailLabel.ForeColor = Color.FromName("Blue");
                phoneLabel.ForeColor = Color.FromName("Blue");
                colorLabel.ForeColor = Color.FromName("Blue");
            }
            else
            {
                page1Panel.BackColor = Color.FromName("Blue");
                nameLabel.ForeColor = Color.FromName("Red");
                emailLabel.ForeColor = Color.FromName("Red");
                phoneLabel.ForeColor = Color.FromName("Red");
                colorLabel.ForeColor = Color.FromName("Red");
            }
        }

        private void emailTextChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            int tester = random.Next(1, 50);
            if (tester % 2 == 0)
            {
                page1Panel.BackColor = Color.FromName("Yellow");
                nameLabel.ForeColor = Color.FromName("Brown");
                emailLabel.ForeColor = Color.FromName("Brown");
                phoneLabel.ForeColor = Color.FromName("Brown");
                colorLabel.ForeColor = Color.FromName("Brown");
            }
            else
            {
                page1Panel.BackColor = Color.FromName("Brown");
                nameLabel.ForeColor = Color.FromName("Yellow");
                emailLabel.ForeColor = Color.FromName("Yellow");
                phoneLabel.ForeColor = Color.FromName("Yellow");
                colorLabel.ForeColor = Color.FromName("Yellow");
            }
        }

        private void phoneTextChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            int tester = random.Next(1, 50);
            if (tester % 2 == 0)
            {
                page1Panel.BackColor = Color.FromName("Pink");
                nameLabel.ForeColor = Color.FromName("Purple");
                emailLabel.ForeColor = Color.FromName("Purple");
                phoneLabel.ForeColor = Color.FromName("Purple");
                colorLabel.ForeColor = Color.FromName("Purple");
            }
            else
            {
                page1Panel.BackColor = Color.FromName("Purple");
                nameLabel.ForeColor = Color.FromName("Pink");
                emailLabel.ForeColor = Color.FromName("Pink");
                phoneLabel.ForeColor = Color.FromName("Pink");
                colorLabel.ForeColor = Color.FromName("Pink");
            }
        }

        private void colorTextChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            int tester = random.Next(1, 50);
            if (tester % 2 == 0)
            {
                page1Panel.BackColor = Color.FromName("Orange");
                nameLabel.ForeColor = Color.FromName("Green");
                emailLabel.ForeColor = Color.FromName("Green");
                phoneLabel.ForeColor = Color.FromName("Green");
                colorLabel.ForeColor = Color.FromName("Green");
            }
            else
            {
                page1Panel.BackColor = Color.FromName("Green");
                nameLabel.ForeColor = Color.FromName("Orange");
                emailLabel.ForeColor = Color.FromName("Orange");
                phoneLabel.ForeColor = Color.FromName("Orange");
                colorLabel.ForeColor = Color.FromName("Orange");
            }
        }

        private void dateChanged(object sender, EventArgs e)
        {
            if (nameLabel.Visible == true) {
                nameLabel.Visible = false;
                emailLabel.Visible = false;
                phoneLabel.Visible = false;
                colorLabel.Visible = false;
            }
            else if (nameLabel.Visible == false)
            {
                nameLabel.Visible = true;
                emailLabel.Visible = true;
                phoneLabel.Visible = true;
                colorLabel.Visible = true;
            }
        }

        private void openPage2Clicked(object sender, EventArgs e)
        {
            Quiz newQuiz = new Quiz();
            newQuiz.ShowDialog();
        }

        private void page2Enter(object sender, EventArgs e)
        {
            if (!cutitout)
            {
                open2Btn.Visible = false;
            }
            openBtnBtn.Visible = true;
        }

        private void btnBtnClicked(object sender, EventArgs e)
        {
            open2Btn.Visible = true;
            cutitout = true;
        }

        private void submitEnter(object sender, EventArgs e)
        {
            Point x = new Point(400, 200);
            submitBtn.Location = x;
        }

        private void submitClicked(object sender, EventArgs e)
        {
            nameText.Text = "";
            emailText.Text = "";
            phoneText.Text = "";
            colorText.Text = "";

            open2Btn.Enabled = true;
        }
    }
}
