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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.grupaZaTreniranjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosNoveGrupeZaTreniranjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmenaTreningaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.članKlubaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosNovogČlanaKlubaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmenaČlanaKlunbaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evidencijaPlaćanjaČlanarineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prisustvoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evidencijaPrisustvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grupaZaTreniranjeToolStripMenuItem,
            this.članKlubaToolStripMenuItem,
            this.prisustvoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1248, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // grupaZaTreniranjeToolStripMenuItem
            // 
            this.grupaZaTreniranjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosNoveGrupeZaTreniranjeToolStripMenuItem,
            this.izmenaTreningaToolStripMenuItem});
            this.grupaZaTreniranjeToolStripMenuItem.Name = "grupaZaTreniranjeToolStripMenuItem";
            this.grupaZaTreniranjeToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.grupaZaTreniranjeToolStripMenuItem.Text = "Grupa za treniranje";
            // 
            // unosNoveGrupeZaTreniranjeToolStripMenuItem
            // 
            this.unosNoveGrupeZaTreniranjeToolStripMenuItem.Name = "unosNoveGrupeZaTreniranjeToolStripMenuItem";
            this.unosNoveGrupeZaTreniranjeToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.unosNoveGrupeZaTreniranjeToolStripMenuItem.Text = "Unos nove grupe za treniranje";
            this.unosNoveGrupeZaTreniranjeToolStripMenuItem.Click += new System.EventHandler(this.unosNoveGrupeZaTreniranjeToolStripMenuItem_Click_1);
            // 
            // izmenaTreningaToolStripMenuItem
            // 
            this.izmenaTreningaToolStripMenuItem.Name = "izmenaTreningaToolStripMenuItem";
            this.izmenaTreningaToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.izmenaTreningaToolStripMenuItem.Text = "Izmena treninga";
            this.izmenaTreningaToolStripMenuItem.Click += new System.EventHandler(this.izmenaTreningaToolStripMenuItem_Click_1);
            // 
            // članKlubaToolStripMenuItem
            // 
            this.članKlubaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosNovogČlanaKlubaToolStripMenuItem,
            this.izmenaČlanaKlunbaToolStripMenuItem,
            this.evidencijaPlaćanjaČlanarineToolStripMenuItem});
            this.članKlubaToolStripMenuItem.Name = "članKlubaToolStripMenuItem";
            this.članKlubaToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.članKlubaToolStripMenuItem.Text = "Član kluba";
            // 
            // unosNovogČlanaKlubaToolStripMenuItem
            // 
            this.unosNovogČlanaKlubaToolStripMenuItem.Name = "unosNovogČlanaKlubaToolStripMenuItem";
            this.unosNovogČlanaKlubaToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.unosNovogČlanaKlubaToolStripMenuItem.Text = "Unos novog člana kluba";
            this.unosNovogČlanaKlubaToolStripMenuItem.Click += new System.EventHandler(this.unosNovogČlanaKlubaToolStripMenuItem_Click);
            // 
            // izmenaČlanaKlunbaToolStripMenuItem
            // 
            this.izmenaČlanaKlunbaToolStripMenuItem.Name = "izmenaČlanaKlunbaToolStripMenuItem";
            this.izmenaČlanaKlunbaToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.izmenaČlanaKlunbaToolStripMenuItem.Text = "Izmena člana klunba";
            this.izmenaČlanaKlunbaToolStripMenuItem.Click += new System.EventHandler(this.izmenaČlanaKlunbaToolStripMenuItem_Click);
            // 
            // evidencijaPlaćanjaČlanarineToolStripMenuItem
            // 
            this.evidencijaPlaćanjaČlanarineToolStripMenuItem.Name = "evidencijaPlaćanjaČlanarineToolStripMenuItem";
            this.evidencijaPlaćanjaČlanarineToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.evidencijaPlaćanjaČlanarineToolStripMenuItem.Text = "Evidencija plaćanja članarine";
            this.evidencijaPlaćanjaČlanarineToolStripMenuItem.Click += new System.EventHandler(this.evidencijaPlaćanjaČlanarineToolStripMenuItem_Click);
            // 
            // prisustvoToolStripMenuItem
            // 
            this.prisustvoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evidencijaPrisustvaToolStripMenuItem});
            this.prisustvoToolStripMenuItem.Name = "prisustvoToolStripMenuItem";
            this.prisustvoToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.prisustvoToolStripMenuItem.Text = "Prisustvo";
            // 
            // evidencijaPrisustvaToolStripMenuItem
            // 
            this.evidencijaPrisustvaToolStripMenuItem.Name = "evidencijaPrisustvaToolStripMenuItem";
            this.evidencijaPrisustvaToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.evidencijaPrisustvaToolStripMenuItem.Text = "Evidencija prisustva";
            this.evidencijaPrisustvaToolStripMenuItem.Click += new System.EventHandler(this.evidencijaPrisustvaToolStripMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(0, 31);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1101, 1024);
            this.pnlMain.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 1055);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem grupaZaTreniranjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosNoveGrupeZaTreniranjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmenaTreningaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem članKlubaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosNovogČlanaKlubaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmenaČlanaKlunbaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evidencijaPlaćanjaČlanarineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prisustvoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evidencijaPrisustvaToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
    }
}