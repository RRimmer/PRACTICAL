namespace ClassWork_Day_Practical_2_12._12
{
    partial class Cal_Combo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cal_Combo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.B_Cal_other = new System.Windows.Forms.Button();
            this.B_Cal_Result = new System.Windows.Forms.Button();
            this.Cal_L_Result = new System.Windows.Forms.Label();
            this.Cal_L_B = new System.Windows.Forms.Label();
            this.Cal_L_A = new System.Windows.Forms.Label();
            this.TB_Cal_Result = new System.Windows.Forms.TextBox();
            this.TB_Cal_B = new System.Windows.Forms.TextBox();
            this.TB_Cal_A = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.B_Cal_other);
            this.groupBox1.Controls.Add(this.B_Cal_Result);
            this.groupBox1.Controls.Add(this.Cal_L_Result);
            this.groupBox1.Controls.Add(this.Cal_L_B);
            this.groupBox1.Controls.Add(this.Cal_L_A);
            this.groupBox1.Controls.Add(this.TB_Cal_Result);
            this.groupBox1.Controls.Add(this.TB_Cal_B);
            this.groupBox1.Controls.Add(this.TB_Cal_A);
            this.groupBox1.Location = new System.Drawing.Point(14, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(474, 406);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Калькулятор";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Сложение",
            "Вычитание",
            "Умножение",
            "Деление"});
            this.comboBox1.Location = new System.Drawing.Point(34, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(401, 37);
            this.comboBox1.TabIndex = 4;
            // 
            // B_Cal_other
            // 
            this.B_Cal_other.Location = new System.Drawing.Point(33, 304);
            this.B_Cal_other.Margin = new System.Windows.Forms.Padding(5);
            this.B_Cal_other.Name = "B_Cal_other";
            this.B_Cal_other.Size = new System.Drawing.Size(401, 53);
            this.B_Cal_other.TabIndex = 3;
            this.B_Cal_other.Text = "Вернутся на Главную";
            this.B_Cal_other.UseVisualStyleBackColor = true;
            this.B_Cal_other.Click += new System.EventHandler(this.B_Cal_other_Click);
            // 
            // B_Cal_Result
            // 
            this.B_Cal_Result.Location = new System.Drawing.Point(33, 182);
            this.B_Cal_Result.Margin = new System.Windows.Forms.Padding(5);
            this.B_Cal_Result.Name = "B_Cal_Result";
            this.B_Cal_Result.Size = new System.Drawing.Size(401, 42);
            this.B_Cal_Result.TabIndex = 3;
            this.B_Cal_Result.Text = "Вычеслить";
            this.B_Cal_Result.UseVisualStyleBackColor = true;
            this.B_Cal_Result.Click += new System.EventHandler(this.B_Cal_Result_Click);
            // 
            // Cal_L_Result
            // 
            this.Cal_L_Result.AutoSize = true;
            this.Cal_L_Result.Location = new System.Drawing.Point(28, 251);
            this.Cal_L_Result.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Cal_L_Result.Name = "Cal_L_Result";
            this.Cal_L_Result.Size = new System.Drawing.Size(128, 29);
            this.Cal_L_Result.TabIndex = 1;
            this.Cal_L_Result.Text = "Результат";
            // 
            // Cal_L_B
            // 
            this.Cal_L_B.AutoSize = true;
            this.Cal_L_B.Location = new System.Drawing.Point(28, 88);
            this.Cal_L_B.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Cal_L_B.Name = "Cal_L_B";
            this.Cal_L_B.Size = new System.Drawing.Size(204, 29);
            this.Cal_L_B.TabIndex = 1;
            this.Cal_L_B.Text = "Введите число В";
            // 
            // Cal_L_A
            // 
            this.Cal_L_A.AutoSize = true;
            this.Cal_L_A.Location = new System.Drawing.Point(29, 44);
            this.Cal_L_A.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Cal_L_A.Name = "Cal_L_A";
            this.Cal_L_A.Size = new System.Drawing.Size(203, 29);
            this.Cal_L_A.TabIndex = 1;
            this.Cal_L_A.Text = "Введите число А";
            // 
            // TB_Cal_Result
            // 
            this.TB_Cal_Result.Location = new System.Drawing.Point(166, 248);
            this.TB_Cal_Result.Margin = new System.Windows.Forms.Padding(5);
            this.TB_Cal_Result.Name = "TB_Cal_Result";
            this.TB_Cal_Result.ReadOnly = true;
            this.TB_Cal_Result.Size = new System.Drawing.Size(268, 34);
            this.TB_Cal_Result.TabIndex = 0;
            // 
            // TB_Cal_B
            // 
            this.TB_Cal_B.Location = new System.Drawing.Point(263, 85);
            this.TB_Cal_B.Margin = new System.Windows.Forms.Padding(5);
            this.TB_Cal_B.Name = "TB_Cal_B";
            this.TB_Cal_B.Size = new System.Drawing.Size(172, 34);
            this.TB_Cal_B.TabIndex = 0;
            // 
            // TB_Cal_A
            // 
            this.TB_Cal_A.Location = new System.Drawing.Point(263, 39);
            this.TB_Cal_A.Margin = new System.Windows.Forms.Padding(5);
            this.TB_Cal_A.Name = "TB_Cal_A";
            this.TB_Cal_A.Size = new System.Drawing.Size(172, 34);
            this.TB_Cal_A.TabIndex = 0;
            // 
            // Cal_Combo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 421);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Cal_Combo";
            this.Text = "Калькулятор другой";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button B_Cal_other;
        private System.Windows.Forms.Button B_Cal_Result;
        private System.Windows.Forms.Label Cal_L_Result;
        private System.Windows.Forms.Label Cal_L_B;
        private System.Windows.Forms.Label Cal_L_A;
        private System.Windows.Forms.TextBox TB_Cal_Result;
        private System.Windows.Forms.TextBox TB_Cal_B;
        private System.Windows.Forms.TextBox TB_Cal_A;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}