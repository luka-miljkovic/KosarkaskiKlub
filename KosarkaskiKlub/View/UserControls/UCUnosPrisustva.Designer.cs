namespace View.UserControls
{
    partial class UCUnosPrisustva
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatumTreninga = new System.Windows.Forms.TextBox();
            this.btnPretraziTreninge = new System.Windows.Forms.Button();
            this.dgvTreninzi = new System.Windows.Forms.DataGridView();
            this.dgvClanovi = new System.Windows.Forms.DataGridView();
            this.btnSacuvajPrisustva = new System.Windows.Forms.Button();
            this.btnPrikaziClanove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreninzi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanovi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unos prisustva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unesite datum treninga";
            // 
            // txtDatumTreninga
            // 
            this.txtDatumTreninga.Location = new System.Drawing.Point(202, 73);
            this.txtDatumTreninga.Name = "txtDatumTreninga";
            this.txtDatumTreninga.Size = new System.Drawing.Size(100, 22);
            this.txtDatumTreninga.TabIndex = 2;
            // 
            // btnPretraziTreninge
            // 
            this.btnPretraziTreninge.Location = new System.Drawing.Point(44, 107);
            this.btnPretraziTreninge.Name = "btnPretraziTreninge";
            this.btnPretraziTreninge.Size = new System.Drawing.Size(83, 27);
            this.btnPretraziTreninge.TabIndex = 3;
            this.btnPretraziTreninge.Text = "Pretrazi";
            this.btnPretraziTreninge.UseVisualStyleBackColor = true;
            this.btnPretraziTreninge.Click += new System.EventHandler(this.btnPretraziTreninge_Click);
            // 
            // dgvTreninzi
            // 
            this.dgvTreninzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreninzi.Location = new System.Drawing.Point(44, 145);
            this.dgvTreninzi.Name = "dgvTreninzi";
            this.dgvTreninzi.RowHeadersVisible = false;
            this.dgvTreninzi.RowHeadersWidth = 51;
            this.dgvTreninzi.RowTemplate.Height = 24;
            this.dgvTreninzi.Size = new System.Drawing.Size(856, 138);
            this.dgvTreninzi.TabIndex = 4;
            // 
            // dgvClanovi
            // 
            this.dgvClanovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanovi.Location = new System.Drawing.Point(44, 356);
            this.dgvClanovi.Name = "dgvClanovi";
            this.dgvClanovi.RowHeadersVisible = false;
            this.dgvClanovi.RowHeadersWidth = 51;
            this.dgvClanovi.RowTemplate.Height = 24;
            this.dgvClanovi.Size = new System.Drawing.Size(520, 163);
            this.dgvClanovi.TabIndex = 5;
            // 
            // btnSacuvajPrisustva
            // 
            this.btnSacuvajPrisustva.Location = new System.Drawing.Point(44, 546);
            this.btnSacuvajPrisustva.Name = "btnSacuvajPrisustva";
            this.btnSacuvajPrisustva.Size = new System.Drawing.Size(152, 31);
            this.btnSacuvajPrisustva.TabIndex = 6;
            this.btnSacuvajPrisustva.Text = "Sacuvaj prisustva";
            this.btnSacuvajPrisustva.UseVisualStyleBackColor = true;
            this.btnSacuvajPrisustva.Click += new System.EventHandler(this.btnSacuvajPrisustva_Click);
            // 
            // btnPrikaziClanove
            // 
            this.btnPrikaziClanove.Location = new System.Drawing.Point(44, 305);
            this.btnPrikaziClanove.Name = "btnPrikaziClanove";
            this.btnPrikaziClanove.Size = new System.Drawing.Size(258, 29);
            this.btnPrikaziClanove.TabIndex = 7;
            this.btnPrikaziClanove.Text = "Prikazi clanove za odabranu grupu";
            this.btnPrikaziClanove.UseVisualStyleBackColor = true;
            this.btnPrikaziClanove.Click += new System.EventHandler(this.btnPrikaziClanove_Click);
            // 
            // UCUnosPrisustva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPrikaziClanove);
            this.Controls.Add(this.btnSacuvajPrisustva);
            this.Controls.Add(this.dgvClanovi);
            this.Controls.Add(this.dgvTreninzi);
            this.Controls.Add(this.btnPretraziTreninge);
            this.Controls.Add(this.txtDatumTreninga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCUnosPrisustva";
            this.Size = new System.Drawing.Size(938, 632);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreninzi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDatumTreninga;
        private System.Windows.Forms.Button btnPretraziTreninge;
        private System.Windows.Forms.DataGridView dgvTreninzi;
        private System.Windows.Forms.DataGridView dgvClanovi;
        private System.Windows.Forms.Button btnSacuvajPrisustva;
        private System.Windows.Forms.Button btnPrikaziClanove;
    }
}
