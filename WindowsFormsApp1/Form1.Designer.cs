namespace WindowsFormsApp1
{
    partial class FrmIsGuvenligi
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kişiBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tespitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kişiBilgileriToolStripMenuItem,
            this.tespitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(787, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kişiBilgileriToolStripMenuItem
            // 
            this.kişiBilgileriToolStripMenuItem.Name = "kişiBilgileriToolStripMenuItem";
            this.kişiBilgileriToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.kişiBilgileriToolStripMenuItem.Text = "&Kişi Bilgileri";
            this.kişiBilgileriToolStripMenuItem.Click += new System.EventHandler(this.kişiBilgileriToolStripMenuItem_Click);
            // 
            // tespitToolStripMenuItem
            // 
            this.tespitToolStripMenuItem.Name = "tespitToolStripMenuItem";
            this.tespitToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.tespitToolStripMenuItem.Text = "&Tespitler";
            this.tespitToolStripMenuItem.Click += new System.EventHandler(this.tespitToolStripMenuItem_Click);
            // 
            // FrmIsGuvenligi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 603);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmIsGuvenligi";
            this.Text = "İş Güvenliği Denetim ve Eğitim Formu (SMAT)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kişiBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tespitToolStripMenuItem;
    }
}

