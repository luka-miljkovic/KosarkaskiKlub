namespace View.UserControls
{
    partial class UCIzmenaClanaKluba
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
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.dgvClanoviKluba = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtImePrezimeIzmena = new System.Windows.Forms.TextBox();
            this.txtNazivSkole = new System.Windows.Forms.TextBox();
            this.cmbGrupa = new System.Windows.Forms.ComboBox();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumUpisa = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanoviKluba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime i prezime člana:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime i prezime:";
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImePrezime.Location = new System.Drawing.Point(242, 69);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.Size = new System.Drawing.Size(206, 32);
            this.txtImePrezime.TabIndex = 2;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPretrazi.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPretrazi.Location = new System.Drawing.Point(44, 113);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(175, 40);
            this.btnPretrazi.TabIndex = 3;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // dgvClanoviKluba
            // 
            this.dgvClanoviKluba.AllowUserToAddRows = false;
            this.dgvClanoviKluba.AllowUserToResizeColumns = false;
            this.dgvClanoviKluba.AllowUserToResizeRows = false;
            this.dgvClanoviKluba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanoviKluba.Location = new System.Drawing.Point(44, 167);
            this.dgvClanoviKluba.Name = "dgvClanoviKluba";
            this.dgvClanoviKluba.ReadOnly = true;
            this.dgvClanoviKluba.RowHeadersVisible = false;
            this.dgvClanoviKluba.RowHeadersWidth = 51;
            this.dgvClanoviKluba.RowTemplate.Height = 24;
            this.dgvClanoviKluba.Size = new System.Drawing.Size(721, 150);
            this.dgvClanoviKluba.TabIndex = 5;
            this.dgvClanoviKluba.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClanoviKluba_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datum rođenja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Datum upisa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 514);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Naziv škole:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 554);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Grupa za treniranje:";
            // 
            // txtImePrezimeIzmena
            // 
            this.txtImePrezimeIzmena.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImePrezimeIzmena.Location = new System.Drawing.Point(242, 386);
            this.txtImePrezimeIzmena.Name = "txtImePrezimeIzmena";
            this.txtImePrezimeIzmena.Size = new System.Drawing.Size(206, 32);
            this.txtImePrezimeIzmena.TabIndex = 10;
            // 
            // txtNazivSkole
            // 
            this.txtNazivSkole.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNazivSkole.Location = new System.Drawing.Point(242, 506);
            this.txtNazivSkole.Name = "txtNazivSkole";
            this.txtNazivSkole.Size = new System.Drawing.Size(206, 32);
            this.txtNazivSkole.TabIndex = 11;
            // 
            // cmbGrupa
            // 
            this.cmbGrupa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupa.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrupa.FormattingEnabled = true;
            this.cmbGrupa.Location = new System.Drawing.Point(242, 546);
            this.cmbGrupa.Name = "cmbGrupa";
            this.cmbGrupa.Size = new System.Drawing.Size(206, 32);
            this.cmbGrupa.TabIndex = 12;
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.CustomFormat = "dd.MM.yyyy.";
            this.dtpDatumRodjenja.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(242, 426);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(206, 32);
            this.dtpDatumRodjenja.TabIndex = 13;
            // 
            // dtpDatumUpisa
            // 
            this.dtpDatumUpisa.CustomFormat = "dd.MM.yyyy.";
            this.dtpDatumUpisa.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumUpisa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumUpisa.Location = new System.Drawing.Point(242, 466);
            this.dtpDatumUpisa.Name = "dtpDatumUpisa";
            this.dtpDatumUpisa.Size = new System.Drawing.Size(206, 32);
            this.dtpDatumUpisa.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Location = new System.Drawing.Point(19, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 35);
            this.label7.TabIndex = 15;
            this.label7.Text = "Izmena člana kluba";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSacuvaj.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSacuvaj.Location = new System.Drawing.Point(44, 613);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(175, 40);
            this.btnSacuvaj.TabIndex = 16;
            this.btnSacuvaj.Text = "Sačuvaj izmene";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "ID člana kluba:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(242, 346);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(206, 32);
            this.txtId.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::View.Properties.Resources.undraw_basketball_agx4;
            this.pictureBox1.Location = new System.Drawing.Point(513, 346);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(577, 422);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // UCIzmenaClanaKluba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDatumUpisa);
            this.Controls.Add(this.dtpDatumRodjenja);
            this.Controls.Add(this.cmbGrupa);
            this.Controls.Add(this.txtNazivSkole);
            this.Controls.Add(this.txtImePrezimeIzmena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvClanoviKluba);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCIzmenaClanaKluba";
            this.Size = new System.Drawing.Size(1093, 810);
            this.Load += new System.EventHandler(this.UCIzmenaClanaKluba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanoviKluba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImePrezime;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.DataGridView dgvClanoviKluba;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtImePrezimeIzmena;
        private System.Windows.Forms.TextBox txtNazivSkole;
        private System.Windows.Forms.ComboBox cmbGrupa;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.DateTimePicker dtpDatumUpisa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
