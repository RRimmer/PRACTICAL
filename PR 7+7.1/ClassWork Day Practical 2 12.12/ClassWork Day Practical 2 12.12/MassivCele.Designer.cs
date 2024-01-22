namespace ClassWork_Day_Practical_2_12._12
{
    partial class MassivCele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MassivCele));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.вернутсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Source_L = new System.Windows.Forms.Label();
            this.Source_TB = new System.Windows.Forms.TextBox();
            this.Dest_L = new System.Windows.Forms.Label();
            this.Dest_TB = new System.Windows.Forms.TextBox();
            this.Calc_B = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вернутсяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(14, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(719, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // вернутсяToolStripMenuItem
            // 
            this.вернутсяToolStripMenuItem.Name = "вернутсяToolStripMenuItem";
            this.вернутсяToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.вернутсяToolStripMenuItem.Text = "Вернутся";
            this.вернутсяToolStripMenuItem.Click += new System.EventHandler(this.вернутсяToolStripMenuItem_Click);
            // 
            // Source_L
            // 
            this.Source_L.AutoSize = true;
            this.Source_L.Location = new System.Drawing.Point(4, 36);
            this.Source_L.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Source_L.Name = "Source_L";
            this.Source_L.Size = new System.Drawing.Size(215, 29);
            this.Source_L.TabIndex = 1;
            this.Source_L.Text = "Исходный массив";
            // 
            // Source_TB
            // 
            this.Source_TB.Location = new System.Drawing.Point(9, 68);
            this.Source_TB.Multiline = true;
            this.Source_TB.Name = "Source_TB";
            this.Source_TB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Source_TB.Size = new System.Drawing.Size(307, 185);
            this.Source_TB.TabIndex = 2;
            // 
            // Dest_L
            // 
            this.Dest_L.AutoSize = true;
            this.Dest_L.Location = new System.Drawing.Point(321, 36);
            this.Dest_L.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Dest_L.Name = "Dest_L";
            this.Dest_L.Size = new System.Drawing.Size(312, 29);
            this.Dest_L.TabIndex = 1;
            this.Dest_L.Text = "Преоброзованный массив";
            // 
            // Dest_TB
            // 
            this.Dest_TB.Location = new System.Drawing.Point(326, 68);
            this.Dest_TB.Multiline = true;
            this.Dest_TB.Name = "Dest_TB";
            this.Dest_TB.ReadOnly = true;
            this.Dest_TB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dest_TB.Size = new System.Drawing.Size(307, 185);
            this.Dest_TB.TabIndex = 2;
            // 
            // Calc_B
            // 
            this.Calc_B.Location = new System.Drawing.Point(42, 259);
            this.Calc_B.Name = "Calc_B";
            this.Calc_B.Size = new System.Drawing.Size(219, 39);
            this.Calc_B.TabIndex = 3;
            this.Calc_B.Text = "Переоброзовать";
            this.Calc_B.UseVisualStyleBackColor = true;
            this.Calc_B.Click += new System.EventHandler(this.Calc_B_Click);
            // 
            // MassivCele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(719, 357);
            this.Controls.Add(this.Calc_B);
            this.Controls.Add(this.Dest_TB);
            this.Controls.Add(this.Source_TB);
            this.Controls.Add(this.Dest_L);
            this.Controls.Add(this.Source_L);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "MassivCele";
            this.Text = "MassivCele";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem вернутсяToolStripMenuItem;
        private System.Windows.Forms.Label Source_L;
        private System.Windows.Forms.TextBox Source_TB;
        private System.Windows.Forms.Label Dest_L;
        private System.Windows.Forms.TextBox Dest_TB;
        private System.Windows.Forms.Button Calc_B;
    }
}