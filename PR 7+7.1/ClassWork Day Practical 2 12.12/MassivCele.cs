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
    public partial class MassivCele : Form
    {
        public MassivCele()
        {
            InitializeComponent();
        }

        private void вернутсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }

        private void Calc_B_Click(object sender, EventArgs e)
        {
            /*Определение кол-во элементов массива*/
            int count = Source_TB.Lines.Length;
            int[] mas = new int[count];
            /*Заполнение массива*/
            for (int i = 0; i < count; i++)
            {
                mas[i] = Convert.ToInt32(Source_TB.Lines[i]);
            }
            /*Поиск максимального значения*/
            int max = mas[0];
            int maxIndex = 0;

            for (int i = 1; i < count; i++)
            {
                if (max < mas[i])
                {
                    max = mas[i];
                    maxIndex = i;
                }
            }
            /*Замена 0 до макс значения*/
            for (int i = 0; i < maxIndex; i++)
            {
                mas[i] = 0;
            }
            /*Вывод результата*/
            Dest_TB.Clear(); /*Удаление старых строк*/
            /*Добавление новых строк в цикле. 
             * Для перехода на новую строку использовано значение Environment.NewLine*/
            for (int i = 0; i < count; i++)
            {
                Dest_TB.AppendText(mas[i] + Environment.NewLine);
            }
        }
    }
}
