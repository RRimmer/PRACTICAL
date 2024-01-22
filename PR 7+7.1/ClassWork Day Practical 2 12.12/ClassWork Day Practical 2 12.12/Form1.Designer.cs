namespace ClassWork_Day_Practical_2_12._12
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.L_ElectrYch = new System.Windows.Forms.Label();
            this.TB_Login = new System.Windows.Forms.TextBox();
            this.L_Login = new System.Windows.Forms.Label();
            this.L_Pass = new System.Windows.Forms.Label();
            this.TB_Pass = new System.Windows.Forms.TextBox();
            this.B_Enter = new System.Windows.Forms.Button();
            this.B_Guest = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.B_Cal_other = new System.Windows.Forms.Button();
            this.B_Cal_Result = new System.Windows.Forms.Button();
            this.RB_Split = new System.Windows.Forms.RadioButton();
            this.RB_Mult = new System.Windows.Forms.RadioButton();
            this.RB_Minus = new System.Windows.Forms.RadioButton();
            this.RB_Sum = new System.Windows.Forms.RadioButton();
            this.Cal_L_Result = new System.Windows.Forms.Label();
            this.Cal_L_B = new System.Windows.Forms.Label();
            this.Cal_L_A = new System.Windows.Forms.Label();
            this.TB_Cal_Result = new System.Windows.Forms.TextBox();
            this.TB_Cal_B = new System.Windows.Forms.TextBox();
            this.TB_Cal_A = new System.Windows.Forms.TextBox();
            this.B_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(165, 79);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // L_ElectrYch
            // 
            this.L_ElectrYch.AutoSize = true;
            this.L_ElectrYch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_ElectrYch.Location = new System.Drawing.Point(114, 173);
            this.L_ElectrYch.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.L_ElectrYch.Name = "L_ElectrYch";
            this.L_ElectrYch.Size = new System.Drawing.Size(208, 25);
            this.L_ElectrYch.TabIndex = 1;
            this.L_ElectrYch.Text = "Электронный ученик";
            // 
            // TB_Login
            // 
            this.TB_Login.Location = new System.Drawing.Point(85, 285);
            this.TB_Login.Name = "TB_Login";
            this.TB_Login.Size = new System.Drawing.Size(272, 34);
            this.TB_Login.TabIndex = 2;
            this.TB_Login.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // L_Login
            // 
            this.L_Login.AutoSize = true;
            this.L_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_Login.Location = new System.Drawing.Point(80, 257);
            this.L_Login.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.L_Login.Name = "L_Login";
            this.L_Login.Size = new System.Drawing.Size(68, 25);
            this.L_Login.TabIndex = 1;
            this.L_Login.Text = "Логин";
            // 
            // L_Pass
            // 
            this.L_Pass.AutoSize = true;
            this.L_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_Pass.Location = new System.Drawing.Point(80, 337);
            this.L_Pass.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.L_Pass.Name = "L_Pass";
            this.L_Pass.Size = new System.Drawing.Size(80, 25);
            this.L_Pass.TabIndex = 1;
            this.L_Pass.Text = "Пароль";
            // 
            // TB_Pass
            // 
            this.TB_Pass.Location = new System.Drawing.Point(85, 365);
            this.TB_Pass.Name = "TB_Pass";
            this.TB_Pass.Size = new System.Drawing.Size(272, 34);
            this.TB_Pass.TabIndex = 3;
            this.TB_Pass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // B_Enter
            // 
            this.B_Enter.BackColor = System.Drawing.Color.CornflowerBlue;
            this.B_Enter.Location = new System.Drawing.Point(85, 405);
            this.B_Enter.Name = "B_Enter";
            this.B_Enter.Size = new System.Drawing.Size(272, 39);
            this.B_Enter.TabIndex = 3;
            this.B_Enter.Text = "Войти";
            this.B_Enter.UseVisualStyleBackColor = false;
            this.B_Enter.Click += new System.EventHandler(this.B_Enter_Click);
            // 
            // B_Guest
            // 
            this.B_Guest.BackColor = System.Drawing.Color.CornflowerBlue;
            this.B_Guest.Location = new System.Drawing.Point(85, 451);
            this.B_Guest.Name = "B_Guest";
            this.B_Guest.Size = new System.Drawing.Size(272, 39);
            this.B_Guest.TabIndex = 3;
            this.B_Guest.Text = "Гость";
            this.B_Guest.UseVisualStyleBackColor = false;
            this.B_Guest.Click += new System.EventHandler(this.B_Guest_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(109, 15);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(201, 56);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.B_Cal_other);
            this.groupBox1.Controls.Add(this.B_Cal_Result);
            this.groupBox1.Controls.Add(this.RB_Split);
            this.groupBox1.Controls.Add(this.RB_Mult);
            this.groupBox1.Controls.Add(this.RB_Minus);
            this.groupBox1.Controls.Add(this.RB_Sum);
            this.groupBox1.Controls.Add(this.Cal_L_Result);
            this.groupBox1.Controls.Add(this.Cal_L_B);
            this.groupBox1.Controls.Add(this.Cal_L_A);
            this.groupBox1.Controls.Add(this.TB_Cal_Result);
            this.groupBox1.Controls.Add(this.TB_Cal_B);
            this.groupBox1.Controls.Add(this.TB_Cal_A);
            this.groupBox1.Location = new System.Drawing.Point(424, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 474);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Калькулятор";
            // 
            // B_Cal_other
            // 
            this.B_Cal_other.Location = new System.Drawing.Point(36, 399);
            this.B_Cal_other.Name = "B_Cal_other";
            this.B_Cal_other.Size = new System.Drawing.Size(329, 47);
            this.B_Cal_other.TabIndex = 3;
            this.B_Cal_other.Text = "Другой формат";
            this.B_Cal_other.UseVisualStyleBackColor = true;
            this.B_Cal_other.Click += new System.EventHandler(this.B_Cal_other_Click);
            // 
            // B_Cal_Result
            // 
            this.B_Cal_Result.Location = new System.Drawing.Point(33, 257);
            this.B_Cal_Result.Name = "B_Cal_Result";
            this.B_Cal_Result.Size = new System.Drawing.Size(329, 47);
            this.B_Cal_Result.TabIndex = 3;
            this.B_Cal_Result.Text = "Вычислить";
            this.B_Cal_Result.UseVisualStyleBackColor = true;
            this.B_Cal_Result.Click += new System.EventHandler(this.button1_Click);
            // 
            // RB_Split
            // 
            this.RB_Split.AutoSize = true;
            this.RB_Split.Location = new System.Drawing.Point(208, 206);
            this.RB_Split.Name = "RB_Split";
            this.RB_Split.Size = new System.Drawing.Size(154, 33);
            this.RB_Split.TabIndex = 2;
            this.RB_Split.TabStop = true;
            this.RB_Split.Text = "Разделить";
            this.RB_Split.UseVisualStyleBackColor = true;
            // 
            // RB_Mult
            // 
            this.RB_Mult.AutoSize = true;
            this.RB_Mult.Location = new System.Drawing.Point(208, 158);
            this.RB_Mult.Name = "RB_Mult";
            this.RB_Mult.Size = new System.Drawing.Size(157, 33);
            this.RB_Mult.TabIndex = 2;
            this.RB_Mult.TabStop = true;
            this.RB_Mult.Text = "Умножить";
            this.RB_Mult.UseVisualStyleBackColor = true;
            // 
            // RB_Minus
            // 
            this.RB_Minus.AutoSize = true;
            this.RB_Minus.Location = new System.Drawing.Point(33, 206);
            this.RB_Minus.Name = "RB_Minus";
            this.RB_Minus.Size = new System.Drawing.Size(129, 33);
            this.RB_Minus.TabIndex = 2;
            this.RB_Minus.TabStop = true;
            this.RB_Minus.Text = "Вычесть";
            this.RB_Minus.UseVisualStyleBackColor = true;
            // 
            // RB_Sum
            // 
            this.RB_Sum.AutoSize = true;
            this.RB_Sum.Location = new System.Drawing.Point(33, 158);
            this.RB_Sum.Name = "RB_Sum";
            this.RB_Sum.Size = new System.Drawing.Size(136, 33);
            this.RB_Sum.TabIndex = 2;
            this.RB_Sum.TabStop = true;
            this.RB_Sum.Text = "Сложить";
            this.RB_Sum.UseVisualStyleBackColor = true;
            // 
            // Cal_L_Result
            // 
            this.Cal_L_Result.AutoSize = true;
            this.Cal_L_Result.Location = new System.Drawing.Point(28, 339);
            this.Cal_L_Result.Name = "Cal_L_Result";
            this.Cal_L_Result.Size = new System.Drawing.Size(128, 29);
            this.Cal_L_Result.TabIndex = 1;
            this.Cal_L_Result.Text = "Результат";
            // 
            // Cal_L_B
            // 
            this.Cal_L_B.AutoSize = true;
            this.Cal_L_B.Location = new System.Drawing.Point(28, 92);
            this.Cal_L_B.Name = "Cal_L_B";
            this.Cal_L_B.Size = new System.Drawing.Size(204, 29);
            this.Cal_L_B.TabIndex = 1;
            this.Cal_L_B.Text = "Введите число В";
            // 
            // Cal_L_A
            // 
            this.Cal_L_A.AutoSize = true;
            this.Cal_L_A.Location = new System.Drawing.Point(28, 52);
            this.Cal_L_A.Name = "Cal_L_A";
            this.Cal_L_A.Size = new System.Drawing.Size(203, 29);
            this.Cal_L_A.TabIndex = 1;
            this.Cal_L_A.Text = "Введите число А";
            // 
            // TB_Cal_Result
            // 
            this.TB_Cal_Result.Location = new System.Drawing.Point(162, 339);
            this.TB_Cal_Result.Name = "TB_Cal_Result";
            this.TB_Cal_Result.ReadOnly = true;
            this.TB_Cal_Result.Size = new System.Drawing.Size(175, 34);
            this.TB_Cal_Result.TabIndex = 0;
            // 
            // TB_Cal_B
            // 
            this.TB_Cal_B.Location = new System.Drawing.Point(237, 92);
            this.TB_Cal_B.Name = "TB_Cal_B";
            this.TB_Cal_B.Size = new System.Drawing.Size(100, 34);
            this.TB_Cal_B.TabIndex = 0;
            // 
            // TB_Cal_A
            // 
            this.TB_Cal_A.Location = new System.Drawing.Point(237, 52);
            this.TB_Cal_A.Name = "TB_Cal_A";
            this.TB_Cal_A.Size = new System.Drawing.Size(100, 34);
            this.TB_Cal_A.TabIndex = 0;
            // 
            // B_Exit
            // 
            this.B_Exit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.B_Exit.Location = new System.Drawing.Point(85, 496);
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.Size = new System.Drawing.Size(272, 39);
            this.B_Exit.TabIndex = 3;
            this.B_Exit.Text = "Выход";
            this.B_Exit.UseVisualStyleBackColor = false;
            this.B_Exit.Click += new System.EventHandler(this.B_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(833, 547);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.B_Exit);
            this.Controls.Add(this.B_Guest);
            this.Controls.Add(this.B_Enter);
            this.Controls.Add(this.TB_Pass);
            this.Controls.Add(this.TB_Login);
            this.Controls.Add(this.L_Pass);
            this.Controls.Add(this.L_Login);
            this.Controls.Add(this.L_ElectrYch);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Электронный ученик";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label L_ElectrYch;
        private System.Windows.Forms.TextBox TB_Login;
        private System.Windows.Forms.Label L_Login;
        private System.Windows.Forms.Label L_Pass;
        private System.Windows.Forms.TextBox TB_Pass;
        private System.Windows.Forms.Button B_Enter;
        private System.Windows.Forms.Button B_Guest;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TB_Cal_B;
        private System.Windows.Forms.TextBox TB_Cal_A;
        private System.Windows.Forms.RadioButton RB_Split;
        private System.Windows.Forms.RadioButton RB_Mult;
        private System.Windows.Forms.RadioButton RB_Minus;
        private System.Windows.Forms.RadioButton RB_Sum;
        private System.Windows.Forms.Label Cal_L_B;
        private System.Windows.Forms.Label Cal_L_A;
        private System.Windows.Forms.Button B_Cal_other;
        private System.Windows.Forms.Button B_Cal_Result;
        private System.Windows.Forms.Label Cal_L_Result;
        private System.Windows.Forms.TextBox TB_Cal_Result;
        private System.Windows.Forms.Button B_Exit;
    }
}

