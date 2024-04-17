using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OKFKS_n3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap bp = new Bitmap(PB1.Width, PB1.Height);
            PB1.Image= bp;
            Graphics gr = Graphics.FromImage(bp);
            SolidBrush solidBrush = new SolidBrush(Color.Purple);
            gr.FillRectangle(solidBrush, 0, 0, PB1.Width, PB1.Height);
            PB1.Refresh();
        }

        public void DrawFigures()
        {
            Graphics gr = Graphics.FromImage(PB1.Image);
            SolidBrush solidBrush = new SolidBrush(Color.Purple);
            gr.FillRectangle(solidBrush, 0, 0, PB1.Width, PB1.Height);
            PB1.Refresh();

            for (int i = 0; i < LB1.Items.Count; i++)   
            {
                Figura fg1 = LB1.Items[i] as Figura;
                fg1.Draw();
            }
            PB1.Refresh();
        }

        private void B_Add_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            if(f.ShowDialog() == DialogResult.OK)
            {
                int x = Convert.ToInt32(f.TB_X.Text);
                int y = Convert.ToInt32(f.TB_Y.Text);
                int h = Convert.ToInt32(f.TB_H.Text);
                Figura fg = new Figura(x, y, h, PB1);
                LB1.Items.Add(fg);
                DrawFigures();
            }
        }

        private void B_Deleted_Click(object sender, EventArgs e)
        {

            if (LB1.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали элемент!");
            }
            else
            {
                LB1.Items.RemoveAt(LB1.SelectedIndex);
                DrawFigures();
            }
        }

        private void B_Edit_Click(object sender, EventArgs e)
        {
            if (LB1.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали объект для редактирования");
            }
            else
            {
                Form2 f = new Form2();
                Figura figura = LB1.SelectedItem as Figura;
                f.TB_X.Text = figura.x.ToString();
                f.TB_Y.Text = figura.y.ToString();
                f.TB_H.Text = figura.h.ToString();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    int x = Convert.ToInt32(f.TB_X.Text);
                    int y = Convert.ToInt32(f.TB_Y.Text);
                    int h = Convert.ToInt32(f.TB_H.Text);
                    figura.x = x;
                    figura.y = y;
                    figura.h = h;
                    figura.Draw();
                    DrawFigures();
                }
            }
        }
    }
}
