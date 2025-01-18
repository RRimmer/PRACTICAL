namespace СП_ПР1
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
            this.DGV_OC = new System.Windows.Forms.DataGridView();
            this.B_Exit = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_OC)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_OC
            // 
            this.DGV_OC.AllowUserToAddRows = false;
            this.DGV_OC.AllowUserToDeleteRows = false;
            this.DGV_OC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_OC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.DGV_OC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_OC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DGV_OC.Location = new System.Drawing.Point(12, 12);
            this.DGV_OC.Name = "DGV_OC";
            this.DGV_OC.RowHeadersVisible = false;
            this.DGV_OC.RowHeadersWidth = 51;
            this.DGV_OC.RowTemplate.Height = 24;
            this.DGV_OC.Size = new System.Drawing.Size(714, 334);
            this.DGV_OC.TabIndex = 0;
            // 
            // B_Exit
            // 
            this.B_Exit.Location = new System.Drawing.Point(12, 352);
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.Size = new System.Drawing.Size(714, 50);
            this.B_Exit.TabIndex = 1;
            this.B_Exit.Text = "Выход";
            this.B_Exit.UseVisualStyleBackColor = true;
            this.B_Exit.Click += new System.EventHandler(this.B_Exit_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Свойство";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Значение";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 403);
            this.Controls.Add(this.B_Exit);
            this.Controls.Add(this.DGV_OC);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_OC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_OC;
        private System.Windows.Forms.Button B_Exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

