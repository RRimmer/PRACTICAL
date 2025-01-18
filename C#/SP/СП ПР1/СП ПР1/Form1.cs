using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СП_ПР1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DGV_OC.Rows.Add("Версия Windows", Environment.OSVersion);
            DGV_OC.Rows.Add("64 Bit ОС", Environment.Is64BitOperatingSystem);
            DGV_OC.Rows.Add("Имя ПК", Environment.MachineName);
            DGV_OC.Rows.Add("Число ЦП", Environment.ProcessorCount);
            DGV_OC.Rows.Add("Системная папка", Environment.SystemDirectory);
            DGV_OC.Rows.Add("Логические диски", string.Join(" ", Environment.GetLogicalDrives()));
        }

        private void B_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
