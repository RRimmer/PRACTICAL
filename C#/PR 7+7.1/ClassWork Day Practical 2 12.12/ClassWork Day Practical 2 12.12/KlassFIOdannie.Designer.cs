namespace ClassWork_Day_Practical_2_12._12
{
    partial class KlassFIOdannie
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Progress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_ClassIndex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_ClassNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Fio = new System.Windows.Forms.TextBox();
            this.B_Ok = new System.Windows.Forms.Button();
            this.B_Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TB_Progress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TB_ClassIndex);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TB_ClassNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TB_Fio);
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 332);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные об ученике";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Признак успеваемости";
            // 
            // TB_Progress
            // 
            this.TB_Progress.Location = new System.Drawing.Point(6, 279);
            this.TB_Progress.Name = "TB_Progress";
            this.TB_Progress.Size = new System.Drawing.Size(313, 34);
            this.TB_Progress.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Индекс класса";
            // 
            // TB_ClassIndex
            // 
            this.TB_ClassIndex.Location = new System.Drawing.Point(6, 210);
            this.TB_ClassIndex.Name = "TB_ClassIndex";
            this.TB_ClassIndex.Size = new System.Drawing.Size(313, 34);
            this.TB_ClassIndex.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Номер класса";
            // 
            // TB_ClassNumber
            // 
            this.TB_ClassNumber.Location = new System.Drawing.Point(6, 141);
            this.TB_ClassNumber.Name = "TB_ClassNumber";
            this.TB_ClassNumber.Size = new System.Drawing.Size(313, 34);
            this.TB_ClassNumber.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "ФИО";
            // 
            // TB_Fio
            // 
            this.TB_Fio.Location = new System.Drawing.Point(5, 72);
            this.TB_Fio.Name = "TB_Fio";
            this.TB_Fio.Size = new System.Drawing.Size(313, 34);
            this.TB_Fio.TabIndex = 7;
            // 
            // B_Ok
            // 
            this.B_Ok.Location = new System.Drawing.Point(1, 340);
            this.B_Ok.Name = "B_Ok";
            this.B_Ok.Size = new System.Drawing.Size(105, 50);
            this.B_Ok.TabIndex = 8;
            this.B_Ok.Text = "Ok";
            this.B_Ok.UseVisualStyleBackColor = true;
            // 
            // B_Cancel
            // 
            this.B_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.B_Cancel.Location = new System.Drawing.Point(198, 340);
            this.B_Cancel.Name = "B_Cancel";
            this.B_Cancel.Size = new System.Drawing.Size(131, 50);
            this.B_Cancel.TabIndex = 17;
            this.B_Cancel.Text = "Отмена";
            this.B_Cancel.UseVisualStyleBackColor = true;
            // 
            // KlassFIOdannie
            // 
            this.AcceptButton = this.B_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CancelButton = this.B_Cancel;
            this.ClientSize = new System.Drawing.Size(331, 395);
            this.Controls.Add(this.B_Cancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.B_Ok);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "KlassFIOdannie";
            this.Text = "KlassFIOdannie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KlassFIOdannie_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button B_Ok;
        public System.Windows.Forms.TextBox TB_Progress;
        public System.Windows.Forms.TextBox TB_ClassIndex;
        public System.Windows.Forms.TextBox TB_ClassNumber;
        public System.Windows.Forms.TextBox TB_Fio;
        private System.Windows.Forms.Button B_Cancel;
    }
}