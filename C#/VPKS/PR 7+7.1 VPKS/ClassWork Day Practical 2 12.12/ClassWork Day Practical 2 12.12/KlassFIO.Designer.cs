namespace ClassWork_Day_Practical_2_12._12
{
    partial class KlassFIO
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
            this.B_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.B_Delete = new System.Windows.Forms.Button();
            this.B_Save = new System.Windows.Forms.Button();
            this.B_Load = new System.Windows.Forms.Button();
            this.DGV_List = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Sort = new System.Windows.Forms.Button();
            this.B_SaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_List)).BeginInit();
            this.SuspendLayout();
            // 
            // B_Add
            // 
            this.B_Add.Location = new System.Drawing.Point(700, 41);
            this.B_Add.Name = "B_Add";
            this.B_Add.Size = new System.Drawing.Size(204, 50);
            this.B_Add.TabIndex = 0;
            this.B_Add.Text = "Добавить";
            this.B_Add.UseVisualStyleBackColor = true;
            this.B_Add.Click += new System.EventHandler(this.B_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список учеников";
            // 
            // B_Delete
            // 
            this.B_Delete.Location = new System.Drawing.Point(700, 97);
            this.B_Delete.Name = "B_Delete";
            this.B_Delete.Size = new System.Drawing.Size(204, 50);
            this.B_Delete.TabIndex = 4;
            this.B_Delete.Text = "Удалить";
            this.B_Delete.UseVisualStyleBackColor = true;
            this.B_Delete.Click += new System.EventHandler(this.B_Delete_Click);
            // 
            // B_Save
            // 
            this.B_Save.Location = new System.Drawing.Point(8, 397);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(204, 50);
            this.B_Save.TabIndex = 5;
            this.B_Save.Text = "Сохранить";
            this.B_Save.UseVisualStyleBackColor = true;
            this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
            // 
            // B_Load
            // 
            this.B_Load.Location = new System.Drawing.Point(490, 397);
            this.B_Load.Name = "B_Load";
            this.B_Load.Size = new System.Drawing.Size(204, 50);
            this.B_Load.TabIndex = 6;
            this.B_Load.Text = "Загрузить";
            this.B_Load.UseVisualStyleBackColor = true;
            this.B_Load.Click += new System.EventHandler(this.B_Load_Click);
            // 
            // DGV_List
            // 
            this.DGV_List.AllowUserToAddRows = false;
            this.DGV_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DGV_List.Location = new System.Drawing.Point(12, 41);
            this.DGV_List.Name = "DGV_List";
            this.DGV_List.RowHeadersVisible = false;
            this.DGV_List.RowHeadersWidth = 51;
            this.DGV_List.RowTemplate.Height = 24;
            this.DGV_List.Size = new System.Drawing.Size(682, 350);
            this.DGV_List.TabIndex = 2;
            this.DGV_List.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_List_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "ФИО";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Номер класса";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Индекс класса";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Признак успеваемости";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 148;
            // 
            // B_Sort
            // 
            this.B_Sort.Location = new System.Drawing.Point(701, 154);
            this.B_Sort.Name = "B_Sort";
            this.B_Sort.Size = new System.Drawing.Size(204, 50);
            this.B_Sort.TabIndex = 10;
            this.B_Sort.Text = "Сортировать";
            this.B_Sort.UseVisualStyleBackColor = true;
            this.B_Sort.Click += new System.EventHandler(this.B_Sort_Click);
            // 
            // B_SaveChanges
            // 
            this.B_SaveChanges.Location = new System.Drawing.Point(700, 313);
            this.B_SaveChanges.Name = "B_SaveChanges";
            this.B_SaveChanges.Size = new System.Drawing.Size(204, 78);
            this.B_SaveChanges.TabIndex = 11;
            this.B_SaveChanges.Text = "Сохранить изменения";
            this.B_SaveChanges.UseVisualStyleBackColor = true;
            this.B_SaveChanges.Click += new System.EventHandler(this.B_SaveChanges_Click);
            // 
            // KlassFIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(920, 459);
            this.Controls.Add(this.B_SaveChanges);
            this.Controls.Add(this.B_Sort);
            this.Controls.Add(this.B_Load);
            this.Controls.Add(this.B_Save);
            this.Controls.Add(this.B_Delete);
            this.Controls.Add(this.DGV_List);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_Add);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "KlassFIO";
            this.Text = "KlassFIO";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_Delete;
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.Button B_Load;
        private System.Windows.Forms.DataGridView DGV_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button B_Sort;
        private System.Windows.Forms.Button B_SaveChanges;
    }
}