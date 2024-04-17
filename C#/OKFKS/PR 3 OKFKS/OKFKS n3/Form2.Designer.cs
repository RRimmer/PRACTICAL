namespace OKFKS_n3
{
    partial class Form2
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
            this.L_X = new System.Windows.Forms.Label();
            this.B_OK = new System.Windows.Forms.Button();
            this.TB_X = new System.Windows.Forms.TextBox();
            this.TB_Y = new System.Windows.Forms.TextBox();
            this.L_Y = new System.Windows.Forms.Label();
            this.TB_H = new System.Windows.Forms.TextBox();
            this.L_H = new System.Windows.Forms.Label();
            this.B_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_X
            // 
            this.L_X.AutoSize = true;
            this.L_X.Location = new System.Drawing.Point(58, 31);
            this.L_X.Name = "L_X";
            this.L_X.Size = new System.Drawing.Size(30, 29);
            this.L_X.TabIndex = 0;
            this.L_X.Text = "X";
            // 
            // B_OK
            // 
            this.B_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.B_OK.Location = new System.Drawing.Point(12, 223);
            this.B_OK.Name = "B_OK";
            this.B_OK.Size = new System.Drawing.Size(86, 40);
            this.B_OK.TabIndex = 1;
            this.B_OK.Text = "OK";
            this.B_OK.UseVisualStyleBackColor = true;
            // 
            // TB_X
            // 
            this.TB_X.Location = new System.Drawing.Point(119, 26);
            this.TB_X.Name = "TB_X";
            this.TB_X.Size = new System.Drawing.Size(100, 34);
            this.TB_X.TabIndex = 2;
            // 
            // TB_Y
            // 
            this.TB_Y.Location = new System.Drawing.Point(119, 82);
            this.TB_Y.Name = "TB_Y";
            this.TB_Y.Size = new System.Drawing.Size(100, 34);
            this.TB_Y.TabIndex = 4;
            // 
            // L_Y
            // 
            this.L_Y.AutoSize = true;
            this.L_Y.Location = new System.Drawing.Point(58, 87);
            this.L_Y.Name = "L_Y";
            this.L_Y.Size = new System.Drawing.Size(29, 29);
            this.L_Y.TabIndex = 3;
            this.L_Y.Text = "Y";
            // 
            // TB_H
            // 
            this.TB_H.Location = new System.Drawing.Point(119, 136);
            this.TB_H.Name = "TB_H";
            this.TB_H.Size = new System.Drawing.Size(100, 34);
            this.TB_H.TabIndex = 6;
            // 
            // L_H
            // 
            this.L_H.AutoSize = true;
            this.L_H.Location = new System.Drawing.Point(58, 141);
            this.L_H.Name = "L_H";
            this.L_H.Size = new System.Drawing.Size(30, 29);
            this.L_H.TabIndex = 5;
            this.L_H.Text = "H";
            // 
            // B_Cancel
            // 
            this.B_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.B_Cancel.Location = new System.Drawing.Point(158, 223);
            this.B_Cancel.Name = "B_Cancel";
            this.B_Cancel.Size = new System.Drawing.Size(117, 40);
            this.B_Cancel.TabIndex = 7;
            this.B_Cancel.Text = "Отмена";
            this.B_Cancel.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AcceptButton = this.B_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.B_Cancel;
            this.ClientSize = new System.Drawing.Size(287, 275);
            this.Controls.Add(this.B_Cancel);
            this.Controls.Add(this.TB_H);
            this.Controls.Add(this.L_H);
            this.Controls.Add(this.TB_Y);
            this.Controls.Add(this.L_Y);
            this.Controls.Add(this.TB_X);
            this.Controls.Add(this.B_OK);
            this.Controls.Add(this.L_X);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label L_X;
        public System.Windows.Forms.Button B_OK;
        public System.Windows.Forms.TextBox TB_X;
        public System.Windows.Forms.TextBox TB_Y;
        public System.Windows.Forms.Label L_Y;
        public System.Windows.Forms.TextBox TB_H;
        public System.Windows.Forms.Label L_H;
        public System.Windows.Forms.Button B_Cancel;
    }
}