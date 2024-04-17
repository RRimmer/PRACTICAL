namespace OKFKS_n3
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
            this.PB1 = new System.Windows.Forms.PictureBox();
            this.LB1 = new System.Windows.Forms.ListBox();
            this.B_Add = new System.Windows.Forms.Button();
            this.B_Deleted = new System.Windows.Forms.Button();
            this.B_Edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            this.SuspendLayout();
            // 
            // PB1
            // 
            this.PB1.Location = new System.Drawing.Point(14, 14);
            this.PB1.Margin = new System.Windows.Forms.Padding(5);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(916, 678);
            this.PB1.TabIndex = 0;
            this.PB1.TabStop = false;
            // 
            // LB1
            // 
            this.LB1.FormattingEnabled = true;
            this.LB1.ItemHeight = 29;
            this.LB1.Location = new System.Drawing.Point(938, 14);
            this.LB1.Name = "LB1";
            this.LB1.Size = new System.Drawing.Size(416, 236);
            this.LB1.TabIndex = 1;
            // 
            // B_Add
            // 
            this.B_Add.Location = new System.Drawing.Point(938, 256);
            this.B_Add.Name = "B_Add";
            this.B_Add.Size = new System.Drawing.Size(151, 60);
            this.B_Add.TabIndex = 2;
            this.B_Add.Text = "Добавить";
            this.B_Add.UseVisualStyleBackColor = true;
            this.B_Add.Click += new System.EventHandler(this.B_Add_Click);
            // 
            // B_Deleted
            // 
            this.B_Deleted.Location = new System.Drawing.Point(1095, 256);
            this.B_Deleted.Name = "B_Deleted";
            this.B_Deleted.Size = new System.Drawing.Size(162, 60);
            this.B_Deleted.TabIndex = 3;
            this.B_Deleted.Text = "Удалить";
            this.B_Deleted.UseVisualStyleBackColor = true;
            this.B_Deleted.Click += new System.EventHandler(this.B_Deleted_Click);
            // 
            // B_Edit
            // 
            this.B_Edit.Location = new System.Drawing.Point(938, 322);
            this.B_Edit.Name = "B_Edit";
            this.B_Edit.Size = new System.Drawing.Size(319, 60);
            this.B_Edit.TabIndex = 4;
            this.B_Edit.Text = "Редактирование";
            this.B_Edit.UseVisualStyleBackColor = true;
            this.B_Edit.Click += new System.EventHandler(this.B_Edit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 706);
            this.Controls.Add(this.B_Edit);
            this.Controls.Add(this.B_Deleted);
            this.Controls.Add(this.B_Add);
            this.Controls.Add(this.LB1);
            this.Controls.Add(this.PB1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB1;
        private System.Windows.Forms.ListBox LB1;
        private System.Windows.Forms.Button B_Add;
        private System.Windows.Forms.Button B_Deleted;
        private System.Windows.Forms.Button B_Edit;
    }
}

