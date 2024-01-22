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
    public partial class KlassFIOdannie : Form
    {
        public KlassFIOdannie()
        {
            InitializeComponent();
        }

        private void KlassFIOdannie_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    if (TB_Fio.Text.Trim() == "")
                    {
                        TB_Fio.Focus();
                        throw new Exception("Вы не ввели ФИО");
                    }

                    int n = Convert.ToInt32(TB_ClassNumber.Text);
                    if (n < 1 || n > 11)
                        throw new Exception("Номер класса должен быть от 1 до 11");

                    if (TB_ClassIndex.Text.Trim() == "")
                    {
                        TB_ClassIndex.Focus();
                        throw new Exception("Вы не индекс класса");
                    }

                    if (TB_Progress.Text.Trim() == "")
                    {
                        TB_Progress.Focus();
                        throw new Exception("Вы не ввели признак успеваемости");
                    }
                }
                catch (FormatException)
                {
                    e.Cancel = true;
                    TB_ClassNumber.Focus();
                    MessageBox.Show("Номер класса должен быть целым числом", "Ошибка");
                }
                catch (Exception E)
                {
                    e.Cancel = true;
                    MessageBox.Show(E.Message, "Ошибка");
                }
            }
        }
    }
}
