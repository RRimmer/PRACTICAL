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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void B_Enter_Click(object sender, EventArgs e)
        {

            string enterlogin = TB_Login.Text;
            string enterpass = TB_Pass.Text;

            string correctlogin = "1";
            string correctpass = "1";
            if (enterlogin == correctlogin && enterpass == correctpass)
            {
                Form2 f = new Form2();
                f.Show();
                this.Visible = false;
            }
            else
            {
                LoadF loadF = new LoadF();
                loadF.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void B_Guest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы вошли как Гость", "Гость", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Form3 form3 = new Form3();
            form3.Show();
            this.Visible = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Width = trackBar1.Value*9;
            pictureBox1.Height = trackBar1.Value*9;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RB_Sum.Checked)
            {
                int A = Convert.ToInt32(TB_Cal_A.Text);
                int B = Convert.ToInt32(TB_Cal_B.Text);
                int C = A + B;
                TB_Cal_Result.Text = C.ToString();
            }
            if (RB_Minus.Checked)
            {
                int A = Convert.ToInt32(TB_Cal_A.Text);
                int B = Convert.ToInt32(TB_Cal_B.Text);
                int C = A - B;
                TB_Cal_Result.Text = C.ToString();
            }
            if (RB_Mult.Checked)
            {
                int A = Convert.ToInt32(TB_Cal_A.Text);
                int B = Convert.ToInt32(TB_Cal_B.Text);
                int C = A * B;
                TB_Cal_Result.Text = C.ToString();
            }
            if (RB_Split.Checked)
            {
                int A = Convert.ToInt32(TB_Cal_A.Text);
                int B = Convert.ToInt32(TB_Cal_B.Text);
                int C = A / B;
                TB_Cal_Result.Text = C.ToString();
            }
        }

        private void B_Cal_other_Click(object sender, EventArgs e)
        {
            Cal_Combo F = new Cal_Combo();
            F.Show();
            this.Visible = false;
        }

        private void B_Calendar_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar();
            calendar.Show();
            this.Visible = false;
        }

        private void B_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TB_Login.Focus();
            TB_Pass.Focus();
        }
    }
}
