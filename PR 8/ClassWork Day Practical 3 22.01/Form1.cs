using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWork_Day_Practical_3_22._01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void практ8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pract8 pract8 = new pract8();
            pract8.Show();
            this.Visible = false;
        }
    }
}
