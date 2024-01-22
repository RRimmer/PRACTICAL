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
    public partial class Cal_Combo : Form
    {
        public Cal_Combo()
        {
            InitializeComponent();
        }

        private void B_Cal_other_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void B_Cal_Result_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите из выпадающего списка что делать с A и B");
            }
            if (comboBox1.SelectedIndex == 0)
            {
                int A = Convert.ToInt32(TB_Cal_A.Text);
                int B = Convert.ToInt32(TB_Cal_B.Text);
                int C = A + B;
                TB_Cal_Result.Text = C.ToString();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                int A = Convert.ToInt32(TB_Cal_A.Text);
                int B = Convert.ToInt32(TB_Cal_B.Text);
                int C = A - B;
                TB_Cal_Result.Text = C.ToString();
            }
            if (comboBox1.SelectedIndex == 2)
            {
                int A = Convert.ToInt32(TB_Cal_A.Text);
                int B = Convert.ToInt32(TB_Cal_B.Text);
                int C = A * B;
                TB_Cal_Result.Text = C.ToString();
            }
            if (comboBox1.SelectedIndex == 3)
            {
                int A = Convert.ToInt32(TB_Cal_A.Text);
                int B = Convert.ToInt32(TB_Cal_B.Text);
                int C = A / B;
                TB_Cal_Result.Text = C.ToString();
            }
        }
    }
}
