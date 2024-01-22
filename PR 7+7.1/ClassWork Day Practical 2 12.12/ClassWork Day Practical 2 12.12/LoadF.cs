using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWork_Day_Practical_2_12._12
{
    public partial class LoadF : Form
    {
        public LoadF()
        {
            InitializeComponent();
        }

        private void LoadF_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value + 10 > 100)
            {
                timer1.Enabled = false;
                this.Visible = false;
                MessageBox.Show("Неверный логин или пароль");
            }
            else
            {
                progressBar1.Value += 10;
                toolStripStatusLabel1.Text = progressBar1.Value.ToString() + " %"; 
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
