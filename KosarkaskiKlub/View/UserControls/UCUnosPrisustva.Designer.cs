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
            this.btnPretraziTreninge = new System.Windows.Forms.Button();
            this.dgvTreninzi = new System.Windows.Forms.DataGridView();
            this.dgvClanovi = new System.Windows.Forms.DataGridView();
            this.btnSacuvajPrisustva = new System.Windows.Forms.Button();
            this.dtpDatumTreninga = new System.Windows.Forms.DateTimePicker();
            this.lblPrisustvo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNazivGrupe = new System.Windows.Forms.TextBox();
            this.cbDatum = new System.Windows.Forms.CheckBox();
            this.cbNaziv = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDatumTreninga = new System.Windows.Forms.TextBox();
            this.txtGrupa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVremeDo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreninzi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unos prisustva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unesite datum treninga:";
            // 
            // btnPretraziTreninge
            // 
            this.btnPretraziTreninge.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPretraziTreninge.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretraziTreninge.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPretraziTreninge.Location = new System.Drawing.Point(44, 125);
            this.btnPretraziTreninge.Name = "btnPretraziTreninge";
            this.btnPretraziTreninge.Size = new System.Drawing.Size(178, 40);
            this.btnPretraziTreninge.TabIndex = 3;
            this.btnPretraziTreninge.Text = "Pretrazi";
            this.btnPretraziTreninge.UseVisualStyleBackColor = false;
            this.btnPretraziTreninge.Click += new System.EventHandler(this.btnPretraziTreninge_Click);
            // 
            // dgvTreninzi
            // 
            this.dgvTreninzi.AllowUserToAddRows = false;
            this.dgvTreninzi.AllowUserToDeleteRows = false;
            this.dgvTreninzi.AllowUserToResizeColumns = false;
            this.dgvTreninzi.AllowUserToResizeRows = false;
            this.dgvTreninzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreninzi.Location = new System.Drawing.Point(44, 177);
            this.dgvTreninzi.Name = "dgvTreninzi";
            this.dgvTreninzi.ReadOnly = true;
            this.dgvTreninzi.RowHeadersVisible = false;
            this.dgvTreninzi.RowHeadersWidth = 51;
            this.dgvTreninzi.RowTemplate.Height = 24;
            this.dgvTreninzi.Size = new System.Drawing.Size(822, 138);
            this.dgvTreninzi.TabIndex = 4;
            this.dgvTreninzi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTreninzi_CellClick);
            // 
            // dgvClanovi
            // 
            this.dgvClanovi.AllowUserToAddRows = false;
            this.dgvClanovi.AllowUserToDeleteRows = false;
            this.dgvClanovi.AllowUserToOrderColumns = true;
            this.dgvClanovi.AllowUserToResizeColumns = false;
            this.dgvClanovi.AllowUserToResizeRows = false;
            this.dgvClanovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanovi.Location = new System.Drawing.Point(45, 536);
            this.dgvClanovi.Name = "dgvClanovi";
            this.dgvClanovi.RowHeadersVisible = false;
            this.dgvClanovi.RowHeadersWidth = 51;
            this.dgvClanovi.RowTemplate.Height = 24;
            this.dgvClanovi.Size = new System.Drawing.Size(426, 163);
            this.dgvClanovi.TabIndex = 5;
            // 
            // btnSacuvajPrisustva
            // 
            this.btnSacuvajPrisustva.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSacuvajPrisustva.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvajPrisustva.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSacuvajPrisustva.Location = new System.Drawing.Point(44, 720);
            this.btnSacuvajPrisustva.Name = "btnSacuvajPrisustva";
            this.btnSacuvajPrisustva.Size = new System.Drawing.Size(210, 40);
            this.btnSacuvajPrisustva.TabIndex = 6;
            this.btnSacuvajPrisustva.Text = "Sacuvaj prisustva";
            this.btnSacuvajPrisustva.UseVisualStyleBackColor = false;
            this.btnSacuvajPrisustva.Click += new System.EventHandler(this.btnSacuvajPrisustva_Click);
            // 
            // dtpDatumTreninga
            // 
            this.dtpDatumTreninga.CustomFormat = "dd.MM.yyyy.";
            this.dtpDatumTreninga.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumTreninga.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumTreninga.Location = new System.Drawing.Point(272, 51);
            this.dtpDatumTreninga.Name = "dtpDatumTreninga";
            this.dtpDatumTreninga.Size = new System.Drawing.Size(199, 32);
            this.dtpDatumTreninga.TabIndex = 8;
            // 
            // lblPrisustvo
            // 
            this.lblPrisustvo.AutoSize = true;
            this.lblPrisustvo.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrisustvo.Location = new System.Drawing.Point(41, 497);
            this.lblPrisustvo.Name = "lblPrisustvo";
            this.lblPrisustvo.Size = new System.Drawing.Size(134, 24);
            this.lblPrisustvo.TabIndex = 9;
            this.lblPrisustvo.Text = "Unos prisustva";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Unesite naziv grupe:";
            // 
            // txtNazivGrupe
            // 
            this.txtNazivGrupe.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNazivGrupe.Location = new System.Drawing.Point(272, 85);
            this.txtNazivGrupe.Name = "txtNazivGrupe";
            this.txtNazivGrupe.Size = new System.Drawing.Size(199, 32);
            this.txtNazivGrupe.TabIndex = 11;
            // 
            // cbDatum
            // 
            this.cbDatum.AutoSize = true;
            this.cbDatum.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDatum.Location = new System.Drawing.Point(477, 53);
            this.cbDatum.Name = "cbDatum";
            this.cbDatum.Size = new System.Drawing.Size(333, 28);
            this.cbDatum.TabIndex = 12;
            this.cbDatum.Text = "Uključite datum treninga u pretragu";
            this.cbDatum.UseVisualStyleBackColor = true;
            // 
            // cbNaziv
            // 
            this.cbNaziv.AutoSize = true;
            this.cbNaziv.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNaziv.Location = new System.Drawing.Point(477, 86);
            this.cbNaziv.Name = "cbNaziv";
            this.cbNaziv.Size = new System.Drawing.Size(301, 28);
            this.cbNaziv.TabIndex = 13;
            this.cbNaziv.Text = "Uključite naziv grupe u pretragu";
            this.cbNaziv.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::View.Properties.Resources.undraw_Done_checking_re_6vyx_2;
            this.pictureBox1.Location = new System.Drawing.Point(508, 337);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(775, 491);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Datum treninga:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Grupa:";
            // 
            // txtDatumTreninga
            // 
            this.txtDatumTreninga.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatumTreninga.Location = new System.Drawing.Point(204, 357);
            this.txtDatumTreninga.Name = "txtDatumTreninga";
            this.txtDatumTreninga.ReadOnly = true;
            this.txtDatumTreninga.Size = new System.Drawing.Size(239, 32);
            this.txtDatumTreninga.TabIndex = 17;
            this.txtDatumTreninga.TextChanged += new System.EventHandler(this.txtDatumTreninga_TextChanged);
            // 
            // txtGrupa
            // 
            this.txtGrupa.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrupa.Location = new System.Drawing.Point(204, 427);
            this.txtGrupa.Name = "txtGrupa";
            this.txtGrupa.ReadOnly = true;
            this.txtGrupa.Size = new System.Drawing.Size(239, 32);
            this.txtGrupa.TabIndex = 18;
            this.txtGrupa.TextChanged += new System.EventHandler(this.txtGrupa_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Vreme:";
            // 
            // txtVremeDo
            // 
            this.txtVremeDo.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVremeDo.Location = new System.Drawing.Point(204, 392);
            this.txtVremeDo.Name = "txtVremeDo";
            this.txtVremeDo.ReadOnly = true;
            this.txtVremeDo.Size = new System.Drawing.Size(239, 32);
            this.txtVremeDo.TabIndex = 21;
            this.txtVremeDo.TextChanged += new System.EventHandler(this.txtVremeDo_TextChanged);
            // 
            // UCUnosPrisustva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtVremeDo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGrupa);
            this.Controls.Add(this.txtDatumTreninga);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbNaziv);
            this.Controls.Add(this.cbDatum);
            this.Controls.Add(this.txtNazivGrupe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPrisustvo);
            this.Controls.Add(this.dtpDatumTreninga);
            this.Controls.Add(this.btnSacuvajPrisustva);
            this.Controls.Add(this.dgvClanovi);
            this.Controls.Add(this.dgvTreninzi);
            this.Controls.Add(this.btnPretraziTreninge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCUnosPrisustva";
            this.Size = new System.Drawing.Size(1200, 857);
            this.Load += new System.EventHandler(this.UCUnosPrisustva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreninzi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPretraziTreninge;
        private System.Windows.Forms.DataGridView dgvTreninzi;
        private System.Windows.Forms.DataGridView dgvClanovi;
        private System.Windows.Forms.Button btnSacuvajPrisustva;
        private System.Windows.Forms.DateTimePicker dtpDatumTreninga;
        private System.Windows.Forms.Label lblPrisustvo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNazivGrupe;
        private System.Windows.Forms.CheckBox cbDatum;
        private System.Windows.Forms.CheckBox cbNaziv;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDatumTreninga;
        private System.Windows.Forms.TextBox txtGrupa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVremeDo;
    }
}
