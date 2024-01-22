using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClassWork_Day_Practical_3_22._01
{
    public partial class pract8 : Form
    {
        public pract8()
        {
            InitializeComponent();
        }

        private void pract8_Load(object sender, EventArgs e)
        {

        }

        private void L_Name1_Click(object sender, EventArgs e)
        {

        }

        private void L_Ex1_Click(object sender, EventArgs e)
        {

        }

        private void B_CheckName_Click(object sender, EventArgs e)
        {
            string name1 = TB_Name1.Text;
            string name2 = TB_Name2.Text;

            int dlina1 = name1.Length;
            int dlina2 = name2.Length;

            if (dlina1 > dlina2)
            {
                MessageBox.Show($"Первое имя состовляет {dlina1} букв и длинее чем второе имя, там всего {dlina2} букв.");
            }
            else if (dlina1 < dlina2)
            {
                MessageBox.Show($"Второе имя состовляет {dlina2} букв и длинее чем первое имя, там всего {dlina1} букв.");
            }
            else
            {
                dlina1 = dlina2;
                MessageBox.Show($"Имена одинаковы {dlina1} букв.={dlina2} букв.");
            }
        }

        private void B_ResultSlovo_Click(object sender, EventArgs e)
        {
            string slovo1 = TB_Slovo1.Text;
            string slovo2 = TB_Slovo2.Text;

            if (slovo1.Length > 0 && slovo2.Length > 0)
            {
                if (slovo1[0] == slovo2[slovo2.Length - 1])
                {
                    MessageBox.Show("Первая буква в первом слово и \nпоследняя буква во втором слове, одинаковые.");
                }
                else
                {
                    MessageBox.Show("Неа, в начале и в конце буквы разные, \nв этих двух словах.");
                }
            }
            else
            {
                MessageBox.Show("Инвалид, напиши че нить");
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void B_ResultGlass_Click(object sender, EventArgs e)
        {
            string text = TB_Glass.Text;
            int count = CountVowels(text);

            MessageBox.Show($"Количество гласных букв: {count} шт.\nИх процент: {CalculatePercentage(text, count):F2}%");
        }

        private int CountVowels(string text)
        {
            char[] vowels = { 'а', 'я', 'у', 'ю', 'о', 'ё', 'е', 'э', 'и', 'ы' };
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = Char.ToLower(text[i]);

                if (Array.IndexOf(vowels, currentChar) != -1)
                {
                    count++;
                }
            }
            return count;
        }

        private double CalculatePercentage(string text, int vowelCount)
        {
            if (vowelCount == 0 || text.Length == 0)
            {
                return 0.0;
            }
            return (double)(text.Length * 100) / vowelCount;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s_oslovo = TB_OSlovo.Text;
            string obratno = "";
            for (int i = s_oslovo.Length - 1; i >= 0; i--)
            {
                obratno += s_oslovo[i]; 
            } 
            TB_ResultOSlovo.Text = obratno;
        }
    }
}