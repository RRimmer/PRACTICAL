namespace ClassWork_Day_Practical_2_12._12
{
    partial class Calendar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar));
            this.B_Calendar_Back = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TB_TakeDateTimePic = new System.Windows.Forms.TextBox();
            this.B_take_datetimep = new System.Windows.Forms.Button();
            this.TB_TakeCalendar = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.B_Take_Calendar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_Calendar_Back
            // 
            this.B_Calendar_Back.Location = new System.Drawing.Point(-4, 438);
            this.B_Calendar_Back.Name = "B_Calendar_Back";
            this.B_Calendar_Back.Size = new System.Drawing.Size(268, 42);
            this.B_Calendar_Back.TabIndex = 0;
            this.B_Calendar_Back.Text = "Вернутся на Главную";
            this.B_Calendar_Back.UseVisualStyleBackColor = true;
            this.B_Calendar_Back.Click += new System.EventHandler(this.B_Calendar_Back_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(29, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(221, 34);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // TB_TakeDateTimePic
            // 
            this.TB_TakeDateTimePic.Location = new System.Drawing.Point(29, 52);
            this.TB_TakeDateTimePic.Name = "TB_TakeDateTimePic";
            this.TB_TakeDateTimePic.ReadOnly = true;
            this.TB_TakeDateTimePic.Size = new System.Drawing.Size(221, 34);
            this.TB_TakeDateTimePic.TabIndex = 2;
            // 
            // B_take_datetimep
            // 
            this.B_take_datetimep.Location = new System.Drawing.Point(29, 92);
            this.B_take_datetimep.Name = "B_take_datetimep";
            this.B_take_datetimep.Size = new System.Drawing.Size(221, 38);
            this.B_take_datetimep.TabIndex = 3;
            this.B_take_datetimep.Text = "↑Взять дату↑";
            this.B_take_datetimep.UseVisualStyleBackColor = true;
            this.B_take_datetimep.Click += new System.EventHandler(this.B_take_datetimep_Click);
            // 
            // TB_TakeCalendar
            // 
            this.TB_TakeCalendar.Location = new System.Drawing.Point(29, 181);
            this.TB_TakeCalendar.Name = "TB_TakeCalendar";
            this.TB_TakeCalendar.ReadOnly = true;
            this.TB_TakeCalendar.Size = new System.Drawing.Size(221, 34);
            this.TB_TakeCalendar.TabIndex = 4;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(42, 227);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // B_Take_Calendar
            // 
            this.B_Take_Calendar.Location = new System.Drawing.Point(29, 136);
            this.B_Take_Calendar.Name = "B_Take_Calendar";
            this.B_Take_Calendar.Size = new System.Drawing.Size(221, 38);
            this.B_Take_Calendar.TabIndex = 6;
            this.B_Take_Calendar.Text = "↓Взять дату↓";
            this.B_Take_Calendar.UseVisualStyleBackColor = true;
            this.B_Take_Calendar.Click += new System.EventHandler(this.B_Take_Calendar_Click);
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 492);
            this.Controls.Add(this.B_Take_Calendar);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.TB_TakeCalendar);
            this.Controls.Add(this.B_take_datetimep);
            this.Controls.Add(this.TB_TakeDateTimePic);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.B_Calendar_Back);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Calendar";
            this.Text = "Календарь";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Calendar_Back;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox TB_TakeDateTimePic;
        private System.Windows.Forms.Button B_take_datetimep;
        private System.Windows.Forms.TextBox TB_TakeCalendar;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button B_Take_Calendar;
    }
}