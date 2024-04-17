using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ClassWork_Day_Practical_2_12._12
{
    public partial class KlassFIO : Form
    {
        
        struct Students
        {
            public string FIO;
            public int ClassNumber;
            public string ClassIndex;
            public string Progress;
        }

        List<Students> list_students = new List<Students>();

        public KlassFIO()
        {
            InitializeComponent();
        }

        private void B_Add_Click(object sender, EventArgs e)
        {
            KlassFIOdannie Dialog = new KlassFIOdannie();
            Dialog.Text = "Добавление ученика";
            Dialog.TB_Fio.Text = "";
            Dialog.TB_ClassNumber.Text = "";
            Dialog.TB_ClassIndex.Text = "";
            Dialog.TB_Progress.Text = "";

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                Students s = new Students();
                s.FIO = Dialog.TB_Fio.Text.Trim();
                s.ClassNumber = Convert.ToInt32(Dialog.TB_ClassNumber.Text);
                s.ClassIndex = Dialog.TB_ClassIndex.Text.Trim();
                s.Progress = Dialog.TB_Progress.Text.Trim();
                list_students.Add(s);

                DGV_List.RowCount = list_students.Count;
                for (int i = 0; i < list_students.Count; i++)
                {
                    DGV_List[0, i].Value = list_students[i].FIO;
                    DGV_List[1, i].Value = list_students[i].ClassNumber.ToString();
                    DGV_List[2, i].Value = list_students[i].ClassIndex.ToString();
                    DGV_List[3, i].Value = list_students[i].Progress;
                }
            }
        }

        private void B_Delete_Click(object sender, EventArgs e)
        {
            if (DGV_List.CurrentRow != null)
            {
                list_students.RemoveAt(DGV_List.CurrentRow.Index);

                DialogResult result = MessageBox.Show("", "Точно удалить элемент?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.OK)
                {

                    DGV_List.RowCount = list_students.Count;
                    for (int i = 0; i < list_students.Count; i++)
                    {
                        DGV_List[0, i].Value = list_students[i].FIO;
                        DGV_List[1, i].Value = list_students[i].ClassNumber.ToString();
                        DGV_List[2, i].Value = list_students[i].ClassIndex.ToString();
                        DGV_List[3, i].Value = list_students[i].Progress;
                    }
                }
            }
            else
            {
                MessageBox.Show("Вы не выделили строку");
            }
        }

        private void B_Edit_Click(object sender, EventArgs e)
        {
            KlassFIOdannie Dialog = new KlassFIOdannie();
            int n = DGV_List.CurrentRow.Index;
            Dialog.TB_Fio.Text = DGV_List[0, n].Value.ToString();
            Dialog.TB_ClassNumber.Text = DGV_List[1, n].Value.ToString();
            Dialog.TB_ClassIndex.Text = DGV_List[2, n].Value.ToString();
            Dialog.TB_Progress.Text = DGV_List[3, n].Value.ToString();

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                Students s = new Students();
                s.FIO = Dialog.TB_Fio.Text.Trim();
                s.ClassNumber = Convert.ToInt32(Dialog.TB_ClassNumber.Text);
                s.ClassIndex = Dialog.TB_ClassIndex.Text.Trim();
                s.Progress = Dialog.TB_Progress.Text.Trim();
                list_students[n]= s;

                DGV_List.RowCount = list_students.Count;
                for (int i = 0; i < list_students.Count; i++)
                {
                    DGV_List[0, i].Value = list_students[i].FIO;
                    DGV_List[1, i].Value = list_students[i].ClassNumber.ToString();
                    DGV_List[2, i].Value = list_students[i].ClassIndex.ToString();
                    DGV_List[3, i].Value = list_students[i].Progress;
                }
            }
        }

        private void B_SaveChanges_Click(object sender, EventArgs e)
        {
            KlassFIOdannie Dialog = new KlassFIOdannie();
            Dialog.Text = "Изменение данных книги";

            Students s = new Students();
            Dialog.TB_Fio.Text = s.FIO;
            Dialog.TB_ClassNumber.Text = s.ClassNumber.ToString();
            Dialog.TB_ClassIndex.Text = s.ClassIndex;
            Dialog.TB_Progress.Text = s.Progress;

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                s.FIO = Dialog.TB_Fio.Text.Trim();
                s.ClassNumber = Convert.ToInt32(Dialog.TB_ClassNumber.Text);
                s.ClassIndex = Dialog.TB_ClassIndex.Text.Trim();
                s.Progress = Dialog.TB_Progress.Text.Trim();
                list_students[DGV_List.CurrentRow.Index] = s;

                DGV_List.RowCount = list_students.Count;
                for (int i = 0; i < list_students.Count; i++)
                {
                    DGV_List[0, i].Value = list_students[i].FIO;
                    DGV_List[1, i].Value = list_students[i].ClassNumber.ToString();
                    DGV_List[2, i].Value = list_students[i].ClassIndex.ToString();
                    DGV_List[3, i].Value = list_students[i].Progress;
                }
            }
        }

        private void DGV_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = DGV_List.CurrentRow.Index;
            KlassFIOdannie Dialog = new KlassFIOdannie();
            Dialog.TB_Fio.Text = DGV_List[0, n].Value.ToString();
            Dialog.TB_ClassNumber.Text = DGV_List[1, n].Value.ToString();
            Dialog.TB_ClassIndex.Text = DGV_List[2, n].Value.ToString();
            Dialog.TB_Progress.Text = DGV_List[3, n].Value.ToString();
            B_SaveChanges.Visible = true;
        }

        private void B_Save_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("1.txt");
            for(int i = 0; i < list_students.Count;  i++)
            {
                sw.WriteLine(DGV_List[0, i].Value.ToString());
                sw.WriteLine(DGV_List[1, i].Value.ToString());
                sw.WriteLine(DGV_List[2, i].Value.ToString());
                sw.WriteLine(DGV_List[3, i].Value.ToString());
            }
            sw.Close();
        }

        private void B_Load_Click(object sender, EventArgs e)
        {
            list_students.Clear();
            StreamReader sr = new StreamReader("1.txt");
            while(sr.EndOfStream == false)
            {
                Students s = new Students();
                s.FIO = sr.ReadLine();
                s.ClassNumber = Convert.ToInt32(sr.ReadLine());
                s.ClassIndex = sr.ReadLine();
                s.Progress = sr.ReadLine();
                list_students.Add(s);
            }

            DGV_List.RowCount = list_students.Count;
            for (int i = 0; i < list_students.Count; i++)
            {
                DGV_List[0, i].Value = list_students[i].FIO;
                DGV_List[1, i].Value = list_students[i].ClassNumber.ToString();
                DGV_List[2, i].Value = list_students[i].ClassIndex.ToString();
                DGV_List[3, i].Value = list_students[i].Progress;
            }

            sr.Close();
        }

        private void B_Sort_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < list_students.Count; i++)
            {
                for (int  j = 0; j < list_students.Count -i -1; j++)
                {
                    if (list_students[j].ClassNumber < list_students[j+ 1].ClassNumber)
                    {
                        Students s = list_students[j];
                        list_students[j] = list_students[j+ 1];
                        list_students[j+ 1] = s;
                    }
                }
            }
            DGV_List.RowCount = list_students.Count;
            for (int i = 0; i < list_students.Count;i++)
            {
                DGV_List[0, i].Value = list_students[i].FIO;
                DGV_List[1, i].Value= list_students[i].ClassNumber.ToString();
            }
        }
    }
}
