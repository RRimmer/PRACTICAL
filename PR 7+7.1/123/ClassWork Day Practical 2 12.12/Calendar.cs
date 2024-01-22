using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWork_Day_Practical_2_12._12
{
    public partial class Calendar : Form
    {
        public Calendar()
        {
            InitializeComponent();
        }

        private void B_Calendar_Back_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Close();
        }

        private void B_take_datetimep_Click(object sender, EventArgs e)
        {
            TB_TakeDateTimePic.Text = dateTimePicker1.Text;
        }

        private void B_Take_Calendar_Click(object sender, EventArgs e)
        {
            TB_TakeCalendar.Text = monthCalendar1.SelectionStart.ToString()+" - "+monthCalendar1.SelectionEnd.ToString();
        }
    }
}
