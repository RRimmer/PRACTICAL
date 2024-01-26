namespace ClassWork_Day_Practical_2_12._12
{
    partial class StandartAlgoritm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StandartAlgoritm));
            this.Matr_L = new System.Windows.Forms.Label();
            this.Count_L = new System.Windows.Forms.Label();
            this.Mas_L = new System.Windows.Forms.Label();
            this.Count_NUD = new System.Windows.Forms.NumericUpDown();
            this.Matr_DGV = new System.Windows.Forms.DataGridView();
            this.Mas_DGV = new System.Windows.Forms.DataGridView();
            this.Calc_B = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.вернутсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Count_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matr_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mas_DGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Matr_L
            // 
            this.Matr_L.AutoSize = true;
            this.Matr_L.Location = new System.Drawing.Point(12, 57);
            this.Matr_L.Name = "Matr_L";
            this.Matr_L.Size = new System.Drawing.Size(226, 29);
            this.Matr_L.TabIndex = 0;
            this.Matr_L.Text = "Исходная матрица";
            // 
            // Count_L
            // 
            this.Count_L.AutoSize = true;
            this.Count_L.Location = new System.Drawing.Point(12, 28);
            this.Count_L.Name = "Count_L";
            this.Count_L.Size = new System.Drawing.Size(322, 29);
            this.Count_L.TabIndex = 0;
            this.Count_L.Text = "Размер исходной матрицы";
            // 
            // Mas_L
            // 
            this.Mas_L.AutoSize = true;
            this.Mas_L.Location = new System.Drawing.Point(12, 543);
            this.Mas_L.Name = "Mas_L";
            this.Mas_L.Size = new System.Drawing.Size(241, 29);
            this.Mas_L.TabIndex = 0;
            this.Mas_L.Text = "Полученный массив";
            // 
            // Count_NUD
            // 
            this.Count_NUD.Location = new System.Drawing.Point(340, 31);
            this.Count_NUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Count_NUD.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Count_NUD.Name = "Count_NUD";
            this.Count_NUD.Size = new System.Drawing.Size(47, 34);
            this.Count_NUD.TabIndex = 1;
            this.Count_NUD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Count_NUD.ValueChanged += new System.EventHandler(this.Count_NUD_ValueChanged);
            // 
            // Matr_DGV
            // 
            this.Matr_DGV.AllowUserToAddRows = false;
            this.Matr_DGV.AllowUserToDeleteRows = false;
            this.Matr_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Matr_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Matr_DGV.ColumnHeadersVisible = false;
            this.Matr_DGV.Location = new System.Drawing.Point(17, 90);
            this.Matr_DGV.Name = "Matr_DGV";
            this.Matr_DGV.RowHeadersVisible = false;
            this.Matr_DGV.RowHeadersWidth = 51;
            this.Matr_DGV.RowTemplate.Height = 24;
            this.Matr_DGV.Size = new System.Drawing.Size(370, 193);
            this.Matr_DGV.TabIndex = 2;
            // 
            // Mas_DGV
            // 
            this.Mas_DGV.AllowUserToAddRows = false;
            this.Mas_DGV.AllowUserToDeleteRows = false;
            this.Mas_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Mas_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Mas_DGV.ColumnHeadersVisible = false;
            this.Mas_DGV.Location = new System.Drawing.Point(17, 336);
            this.Mas_DGV.Name = "Mas_DGV";
            this.Mas_DGV.ReadOnly = true;
            this.Mas_DGV.RowHeadersVisible = false;
            this.Mas_DGV.RowHeadersWidth = 51;
            this.Mas_DGV.RowTemplate.Height = 24;
            this.Mas_DGV.Size = new System.Drawing.Size(370, 193);
            this.Mas_DGV.TabIndex = 2;
            // 
            // Calc_B
            // 
            this.Calc_B.Location = new System.Drawing.Point(142, 289);
            this.Calc_B.Name = "Calc_B";
            this.Calc_B.Size = new System.Drawing.Size(119, 41);
            this.Calc_B.TabIndex = 3;
            this.Calc_B.Text = "Расчет";
            this.Calc_B.UseVisualStyleBackColor = true;
            this.Calc_B.Click += new System.EventHandler(this.Calc_B_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вернутсяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(397, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // вернутсяToolStripMenuItem
            // 
            this.вернутсяToolStripMenuItem.Name = "вернутсяToolStripMenuItem";
            this.вернутсяToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.вернутсяToolStripMenuItem.Text = "Вернутся";
            this.вернутсяToolStripMenuItem.Click += new System.EventHandler(this.вернутсяToolStripMenuItem_Click);
            // 
            // StandartAlgoritm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(397, 583);
            this.Controls.Add(this.Calc_B);
            this.Controls.Add(this.Mas_DGV);
            this.Controls.Add(this.Matr_DGV);
            this.Controls.Add(this.Count_NUD);
            this.Controls.Add(this.Mas_L);
            this.Controls.Add(this.Count_L);
            this.Controls.Add(this.Matr_L);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "StandartAlgoritm";
            this.Text = "Algorithm";
            this.Load += new System.EventHandler(this.StandartAlgoritm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Count_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matr_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mas_DGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Matr_L;
        private System.Windows.Forms.Label Count_L;
        private System.Windows.Forms.Label Mas_L;
        private System.Windows.Forms.NumericUpDown Count_NUD;
        private System.Windows.Forms.DataGridView Matr_DGV;
        private System.Windows.Forms.DataGridView Mas_DGV;
        private System.Windows.Forms.Button Calc_B;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem вернутсяToolStripMenuItem;
    }
}