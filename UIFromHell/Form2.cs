using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIFromHell
{
    public partial class Quiz : Form
    {
        public Quiz()
        {
            InitializeComponent();
        }

        private void Quiz_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void quizLabel_Click(object sender, EventArgs e)
        {

        }

        private void sevenChanged(object sender, EventArgs e)
        {
            if (hairButton3.Checked == true)
            {
                this.Close();
                Form3 lastPage = new Form3();
                lastPage.Show();
            }
        }

        private void avgChanged(object sender, EventArgs e)
        {
            if (mathButton3.Checked == true)
            {
                this.Close();
                Form3 lastPage = new Form3();
                lastPage.Show();
            }
        }
    }
}
