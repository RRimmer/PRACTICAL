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
    public partial class Algoritm_Task1_F : Form
    {
        public Algoritm_Task1_F()
        {
            InitializeComponent();
        }

        private void Calc_B_Click(object sender, EventArgs e)
        {
            int[,] matr = new int[Matr_DGV.RowCount, Matr_DGV.ColumnCount];
            int i, j;
            for (i = 0; i < Matr_DGV.RowCount; i++)
            {
                int s = -1;
                for (j = 0; j < Matr_DGV.ColumnCount; j++)
                {
                    s += 2;
                    Matr_DGV[j, i].Value = s;
                }
                    
            }
        }

        private void Count_NUD_ValueChanged(object sender, EventArgs e)
        {
            Matr_DGV.RowCount = Convert.ToInt32(Count_NUD.Value);
            Matr_DGV.ColumnCount = Convert.ToInt32(Count_NUD.Value);
        }

        private void Algoritm_Task1_F_Load(object sender, EventArgs e)
        {
            Matr_DGV.RowCount = Convert.ToInt32(Count_NUD.Value);
            Matr_DGV.ColumnCount = Convert.ToInt32(Count_NUD.Value);
        }

        private void вернутьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }
    }
}
