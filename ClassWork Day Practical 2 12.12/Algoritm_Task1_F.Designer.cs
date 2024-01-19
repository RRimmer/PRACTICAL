namespace ClassWork_Day_Practical_2_12._12
{
    partial class Algoritm_Task1_F
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
            this.Calc_B = new System.Windows.Forms.Button();
            this.Matr_DGV = new System.Windows.Forms.DataGridView();
            this.Count_L = new System.Windows.Forms.Label();
            this.Matr_L = new System.Windows.Forms.Label();
            this.Count_NUD = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.вернутьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Matr_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Count_NUD)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calc_B
            // 
            this.Calc_B.Location = new System.Drawing.Point(142, 302);
            this.Calc_B.Name = "Calc_B";
            this.Calc_B.Size = new System.Drawing.Size(119, 41);
            this.Calc_B.TabIndex = 7;
            this.Calc_B.Text = "Расчет";
            this.Calc_B.UseVisualStyleBackColor = true;
            this.Calc_B.Click += new System.EventHandler(this.Calc_B_Click);
            // 
            // Matr_DGV
            // 
            this.Matr_DGV.AllowUserToAddRows = false;
            this.Matr_DGV.AllowUserToDeleteRows = false;
            this.Matr_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Matr_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Matr_DGV.ColumnHeadersVisible = false;
            this.Matr_DGV.Location = new System.Drawing.Point(17, 103);
            this.Matr_DGV.Name = "Matr_DGV";
            this.Matr_DGV.RowHeadersVisible = false;
            this.Matr_DGV.RowHeadersWidth = 51;
            this.Matr_DGV.RowTemplate.Height = 24;
            this.Matr_DGV.Size = new System.Drawing.Size(370, 193);
            this.Matr_DGV.TabIndex = 6;
            // 
            // Count_L
            // 
            this.Count_L.AutoSize = true;
            this.Count_L.Location = new System.Drawing.Point(12, 41);
            this.Count_L.Name = "Count_L";
            this.Count_L.Size = new System.Drawing.Size(322, 29);
            this.Count_L.TabIndex = 4;
            this.Count_L.Text = "Размер исходной матрицы";
            // 
            // Matr_L
            // 
            this.Matr_L.AutoSize = true;
            this.Matr_L.Location = new System.Drawing.Point(12, 70);
            this.Matr_L.Name = "Matr_L";
            this.Matr_L.Size = new System.Drawing.Size(226, 29);
            this.Matr_L.TabIndex = 5;
            this.Matr_L.Text = "Исходная матрица";
            // 
            // Count_NUD
            // 
            this.Count_NUD.Location = new System.Drawing.Point(340, 39);
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
            this.Count_NUD.TabIndex = 8;
            this.Count_NUD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Count_NUD.ValueChanged += new System.EventHandler(this.Count_NUD_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вернутьсяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(397, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // вернутьсяToolStripMenuItem
            // 
            this.вернутьсяToolStripMenuItem.Name = "вернутьсяToolStripMenuItem";
            this.вернутьсяToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.вернутьсяToolStripMenuItem.Text = "Вернуться";
            this.вернутьсяToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяToolStripMenuItem_Click);
            // 
            // Algoritm_Task1_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(397, 583);
            this.Controls.Add(this.Count_NUD);
            this.Controls.Add(this.Calc_B);
            this.Controls.Add(this.Matr_DGV);
            this.Controls.Add(this.Count_L);
            this.Controls.Add(this.Matr_L);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Algoritm_Task1_F";
            this.Text = "Algoritm_Task1_F";
            this.Load += new System.EventHandler(this.Algoritm_Task1_F_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Matr_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Count_NUD)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calc_B;
        private System.Windows.Forms.DataGridView Matr_DGV;
        private System.Windows.Forms.Label Count_L;
        private System.Windows.Forms.Label Matr_L;
        private System.Windows.Forms.NumericUpDown Count_NUD;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяToolStripMenuItem;
    }
}