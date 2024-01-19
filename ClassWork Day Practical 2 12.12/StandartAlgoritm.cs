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
    public partial class StandartAlgoritm : Form
    {
        public StandartAlgoritm()
        {
            InitializeComponent();
        }

        private void Calc_B_Click(object sender, EventArgs e)
        {
            double[] mas = new double[Mas_DGV.ColumnCount];
            int[,] matr = new int[Matr_DGV.RowCount, Matr_DGV.ColumnCount];
            int i, j;
            for (i = 0; i < Matr_DGV.RowCount; i++)
            {
                for (j = 0; j < Matr_DGV.ColumnCount; j++)
                {
                    matr[i, j] = Convert.ToInt32(Matr_DGV[j, i].Value);

                }
            }
            for (i = 0; i < Matr_DGV.RowCount; i++)
            {
                mas[i] = 0;
                for (j = 0; j < Matr_DGV.ColumnCount; j++)
                {
                    mas[i] += matr[i, j];
                }
                mas[i] /= Matr_DGV.ColumnCount;
            }

            double temp;
            for(i = 0; i < Matr_DGV.ColumnCount - 1; i++)
                for (j = i + 1; j < Matr_DGV.ColumnCount; j++)
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
            
            for (i = 0; i < Matr_DGV.ColumnCount; i++)
            {
                Mas_DGV[i, 0].Value = mas[i];
            }
        }

        private void вернутсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }

        private void Count_NUD_ValueChanged(object sender, EventArgs e)
        {
            Matr_DGV.RowCount = Convert.ToInt32(Count_NUD.Value);
            Matr_DGV.ColumnCount = Convert.ToInt32(Count_NUD.Value);
            Mas_DGV.ColumnCount = Convert.ToInt32(Count_NUD.Value);
        }

        private void StandartAlgoritm_Load(object sender, EventArgs e)
        {
            Matr_DGV.RowCount = Convert.ToInt32(Count_NUD.Value);
            Matr_DGV.ColumnCount = Convert.ToInt32(Count_NUD.Value);
            Mas_DGV.RowCount = 1;
            Mas_DGV.ColumnCount = Convert.ToInt32(Count_NUD.Value);
        }
    }
}
