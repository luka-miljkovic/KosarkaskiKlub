namespace View
{
    partial class FrmMain
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.grupaZaTreniranjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosNoveGrupeZaTreniranjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clanKlubaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upisNovogClanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evidencijaClanarineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prisustvoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unesiPrisustvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.menuStrip1);
            this.pnlMain.Location = new System.Drawing.Point(4, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(900, 898);
            this.pnlMain.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grupaZaTreniranjeToolStripMenuItem,
            this.clanKlubaToolStripMenuItem,
            this.prisustvoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // grupaZaTreniranjeToolStripMenuItem
            // 
            this.grupaZaTreniranjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosNoveGrupeZaTreniranjeToolStripMenuItem});
            this.grupaZaTreniranjeToolStripMenuItem.Name = "grupaZaTreniranjeToolStripMenuItem";
            this.grupaZaTreniranjeToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.grupaZaTreniranjeToolStripMenuItem.Text = "Grupa za treniranje";
            // 
            // unosNoveGrupeZaTreniranjeToolStripMenuItem
            // 
            this.unosNoveGrupeZaTreniranjeToolStripMenuItem.Name = "unosNoveGrupeZaTreniranjeToolStripMenuItem";
            this.unosNoveGrupeZaTreniranjeToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.unosNoveGrupeZaTreniranjeToolStripMenuItem.Text = "Unos nove grupe za treniranje";
            this.unosNoveGrupeZaTreniranjeToolStripMenuItem.Click += new System.EventHandler(this.unosNoveGrupeZaTreniranjeToolStripMenuItem_Click);
            // 
            // clanKlubaToolStripMenuItem
            // 
            this.clanKlubaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.upisNovogClanaToolStripMenuItem,
            this.evidencijaClanarineToolStripMenuItem});
            this.clanKlubaToolStripMenuItem.Name = "clanKlubaToolStripMenuItem";
            this.clanKlubaToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.clanKlubaToolStripMenuItem.Text = "Clan kluba";
            // 
            // upisNovogClanaToolStripMenuItem
            // 
            this.upisNovogClanaToolStripMenuItem.Name = "upisNovogClanaToolStripMenuItem";
            this.upisNovogClanaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.upisNovogClanaToolStripMenuItem.Text = "Upis novog clana";
            this.upisNovogClanaToolStripMenuItem.Click += new System.EventHandler(this.upisNovogClanaToolStripMenuItem_Click);
            // 
            // evidencijaClanarineToolStripMenuItem
            // 
            this.evidencijaClanarineToolStripMenuItem.Name = "evidencijaClanarineToolStripMenuItem";
            this.evidencijaClanarineToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.evidencijaClanarineToolStripMenuItem.Text = "Evidencija clanarine";
            this.evidencijaClanarineToolStripMenuItem.Click += new System.EventHandler(this.evidencijaClanarineToolStripMenuItem_Click);
            // 
            // prisustvoToolStripMenuItem
            // 
            this.prisustvoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unesiPrisustvaToolStripMenuItem});
            this.prisustvoToolStripMenuItem.Name = "prisustvoToolStripMenuItem";
            this.prisustvoToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.prisustvoToolStripMenuItem.Text = "Prisustvo";
            // 
            // unesiPrisustvaToolStripMenuItem
            // 
            this.unesiPrisustvaToolStripMenuItem.Name = "unesiPrisustvaToolStripMenuItem";
            this.unesiPrisustvaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.unesiPrisustvaToolStripMenuItem.Text = "Unesi prisustva";
            this.unesiPrisustvaToolStripMenuItem.Click += new System.EventHandler(this.unesiPrisustvaToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 895);
            this.Controls.Add(this.pnlMain);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem grupaZaTreniranjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosNoveGrupeZaTreniranjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clanKlubaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upisNovogClanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evidencijaClanarineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prisustvoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unesiPrisustvaToolStripMenuItem;
    }
}