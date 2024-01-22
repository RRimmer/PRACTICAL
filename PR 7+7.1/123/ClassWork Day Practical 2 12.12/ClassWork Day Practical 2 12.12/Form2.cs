using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWork_Day_Practical_2_12._12
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Load += Form2_Load;
            pictureBox1.Visible = false;
            WB_NGGTKI.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void CalendarStripMenu_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar();
            calendar.Show();
            this.Close();
        }

        private void рисунок1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                pictureBox1.Visible = true;
                pictureBox1.Width = 300;
                pictureBox1.Height = 200;
                pictureBox1.Load(@"Medbet1.jpg");
            }
        }

        private void рисунок2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                pictureBox1.Visible = true;
                pictureBox1.Width = 300;
                pictureBox1.Height = 200;
                pictureBox1.Load(@"Medbet2.jpg");
            }
        }

        private void рисунок3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                pictureBox1.Visible = true;
                pictureBox1.Width = 300;
                pictureBox1.Height = 200;
                pictureBox1.Load(@"Medbet3.jpg");
            }
        }

        private void скрытьБраузерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WB_NGGTKI.Visible)
            {
                WB_NGGTKI.Visible = false;
            }
            else
            {
                WB_NGGTKI.Visible = true;
            }
        }

        private void закрытьВсеРисункиToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
            }
        }

        private void выходИзАккаунтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void целочисленныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MassivCele massivCele = new MassivCele();
            massivCele.Show();
            this.Close();
        }

        private void скрытьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WB_NGGTKI.Visible = false;
            pictureBox1.Visible =false;
        }

        private void стандартныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StandartAlgoritm standartAlgoritm = new StandartAlgoritm();
            standartAlgoritm.Show();
            this.Close();
        }

        private void задача1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Algoritm_Task1_F algoritm_Task1_F = new Algoritm_Task1_F();
            algoritm_Task1_F.Show();
            this.Close();
        }

        private void задача1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KlassFIO Dialog = new KlassFIO();
            Dialog.Show();
            this.Close();
        }
    }
}
