namespace Barang
{
    partial class Form1
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ukuranPakaianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ukuranSepatuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pakaianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepatuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.masterToolStripMenuItem,
            this.barangToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(748, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.warnaToolStripMenuItem,
            this.ukuranPakaianToolStripMenuItem,
            this.ukuranSepatuToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // warnaToolStripMenuItem
            // 
            this.warnaToolStripMenuItem.Name = "warnaToolStripMenuItem";
            this.warnaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.warnaToolStripMenuItem.Text = "Warna";
            this.warnaToolStripMenuItem.Click += new System.EventHandler(this.warnaToolStripMenuItem_Click);
            // 
            // ukuranPakaianToolStripMenuItem
            // 
            this.ukuranPakaianToolStripMenuItem.Name = "ukuranPakaianToolStripMenuItem";
            this.ukuranPakaianToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.ukuranPakaianToolStripMenuItem.Text = "Ukuran Pakaian";
            this.ukuranPakaianToolStripMenuItem.Click += new System.EventHandler(this.ukuranPakaianToolStripMenuItem_Click);
            // 
            // ukuranSepatuToolStripMenuItem
            // 
            this.ukuranSepatuToolStripMenuItem.Name = "ukuranSepatuToolStripMenuItem";
            this.ukuranSepatuToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.ukuranSepatuToolStripMenuItem.Text = "Ukuran Sepatu";
            this.ukuranSepatuToolStripMenuItem.Click += new System.EventHandler(this.ukuranSepatuToolStripMenuItem_Click);
            // 
            // barangToolStripMenuItem
            // 
            this.barangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pakaianToolStripMenuItem,
            this.sepatuToolStripMenuItem});
            this.barangToolStripMenuItem.Name = "barangToolStripMenuItem";
            this.barangToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.barangToolStripMenuItem.Text = "Barang";
            // 
            // pakaianToolStripMenuItem
            // 
            this.pakaianToolStripMenuItem.Name = "pakaianToolStripMenuItem";
            this.pakaianToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pakaianToolStripMenuItem.Text = "Pakaian";
            this.pakaianToolStripMenuItem.Click += new System.EventHandler(this.pakaianToolStripMenuItem_Click);
            // 
            // sepatuToolStripMenuItem
            // 
            this.sepatuToolStripMenuItem.Name = "sepatuToolStripMenuItem";
            this.sepatuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sepatuToolStripMenuItem.Text = "Sepatu";
            this.sepatuToolStripMenuItem.Click += new System.EventHandler(this.sepatuToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 407);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Data Barang";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ukuranPakaianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ukuranSepatuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pakaianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepatuToolStripMenuItem;
    }
}

