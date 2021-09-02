namespace View.UserControls
{
    partial class UCEvidencijaClanarine
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
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.dgvClanKluba = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGodina = new System.Windows.Forms.TextBox();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.btnSacuvajUplatu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.dtpDatumUplate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdClanaKluba = new System.Windows.Forms.TextBox();
            this.txtImePrezimeClana = new System.Windows.Forms.TextBox();
            this.cmbMesec = new System.Windows.Forms.ComboBox();
            this.dgvClanarine = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanKluba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanarine)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime i prezime člana:";
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImePrezime.Location = new System.Drawing.Point(243, 72);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.Size = new System.Drawing.Size(164, 32);
            this.txtImePrezime.TabIndex = 1;
            // 
            // dgvClanKluba
            // 
            this.dgvClanKluba.AllowUserToAddRows = false;
            this.dgvClanKluba.AllowUserToDeleteRows = false;
            this.dgvClanKluba.AllowUserToResizeColumns = false;
            this.dgvClanKluba.AllowUserToResizeRows = false;
            this.dgvClanKluba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanKluba.Location = new System.Drawing.Point(46, 171);
            this.dgvClanKluba.Name = "dgvClanKluba";
            this.dgvClanKluba.ReadOnly = true;
            this.dgvClanKluba.RowHeadersVisible = false;
            this.dgvClanKluba.RowHeadersWidth = 51;
            this.dgvClanKluba.RowTemplate.Height = 24;
            this.dgvClanKluba.Size = new System.Drawing.Size(698, 150);
            this.dgvClanKluba.TabIndex = 2;
            this.dgvClanKluba.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClanKluba_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mesec:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Godina:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Datum uplate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Iznos uplate:";
            // 
            // txtGodina
            // 
            this.txtGodina.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGodina.Location = new System.Drawing.Point(190, 385);
            this.txtGodina.Name = "txtGodina";
            this.txtGodina.Size = new System.Drawing.Size(217, 32);
            this.txtGodina.TabIndex = 8;
            // 
            // txtIznos
            // 
            this.txtIznos.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIznos.Location = new System.Drawing.Point(190, 459);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(217, 32);
            this.txtIznos.TabIndex = 10;
            // 
            // btnSacuvajUplatu
            // 
            this.btnSacuvajUplatu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSacuvajUplatu.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvajUplatu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSacuvajUplatu.Location = new System.Drawing.Point(46, 507);
            this.btnSacuvajUplatu.Name = "btnSacuvajUplatu";
            this.btnSacuvajUplatu.Size = new System.Drawing.Size(175, 40);
            this.btnSacuvajUplatu.TabIndex = 11;
            this.btnSacuvajUplatu.Text = "Sačuvaj uplatu";
            this.btnSacuvajUplatu.UseVisualStyleBackColor = false;
            this.btnSacuvajUplatu.Click += new System.EventHandler(this.btnSacuvajUplatu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(19, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(393, 35);
            this.label6.TabIndex = 12;
            this.label6.Text = "Evidentiranje plaćanja članarine";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPretrazi.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPretrazi.Location = new System.Drawing.Point(46, 116);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(175, 40);
            this.btnPretrazi.TabIndex = 13;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // dtpDatumUplate
            // 
            this.dtpDatumUplate.CustomFormat = "dd.MM.yyyy.";
            this.dtpDatumUplate.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumUplate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumUplate.Location = new System.Drawing.Point(190, 422);
            this.dtpDatumUplate.Name = "dtpDatumUplate";
            this.dtpDatumUplate.Size = new System.Drawing.Size(217, 32);
            this.dtpDatumUplate.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(436, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "ID člana kluba:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(436, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ime prezime:";
            // 
            // txtIdClanaKluba
            // 
            this.txtIdClanaKluba.Enabled = false;
            this.txtIdClanaKluba.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdClanaKluba.Location = new System.Drawing.Point(578, 347);
            this.txtIdClanaKluba.Name = "txtIdClanaKluba";
            this.txtIdClanaKluba.ReadOnly = true;
            this.txtIdClanaKluba.Size = new System.Drawing.Size(166, 32);
            this.txtIdClanaKluba.TabIndex = 17;
            // 
            // txtImePrezimeClana
            // 
            this.txtImePrezimeClana.Enabled = false;
            this.txtImePrezimeClana.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImePrezimeClana.Location = new System.Drawing.Point(578, 386);
            this.txtImePrezimeClana.Name = "txtImePrezimeClana";
            this.txtImePrezimeClana.ReadOnly = true;
            this.txtImePrezimeClana.Size = new System.Drawing.Size(166, 32);
            this.txtImePrezimeClana.TabIndex = 18;
            // 
            // cmbMesec
            // 
            this.cmbMesec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMesec.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMesec.FormattingEnabled = true;
            this.cmbMesec.Items.AddRange(new object[] {
            "Januar",
            "Februar",
            "Mart",
            "April",
            "Maj",
            "Jun",
            "Jul",
            "Avgust",
            "Septembar",
            "Oktobar",
            "Novembar",
            "Decembar"});
            this.cmbMesec.Location = new System.Drawing.Point(190, 348);
            this.cmbMesec.Name = "cmbMesec";
            this.cmbMesec.Size = new System.Drawing.Size(217, 32);
            this.cmbMesec.TabIndex = 19;
            // 
            // dgvClanarine
            // 
            this.dgvClanarine.AllowUserToAddRows = false;
            this.dgvClanarine.AllowUserToDeleteRows = false;
            this.dgvClanarine.AllowUserToResizeColumns = false;
            this.dgvClanarine.AllowUserToResizeRows = false;
            this.dgvClanarine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanarine.Location = new System.Drawing.Point(440, 497);
            this.dgvClanarine.Name = "dgvClanarine";
            this.dgvClanarine.ReadOnly = true;
            this.dgvClanarine.RowHeadersVisible = false;
            this.dgvClanarine.RowHeadersWidth = 51;
            this.dgvClanarine.RowTemplate.Height = 24;
            this.dgvClanarine.Size = new System.Drawing.Size(582, 150);
            this.dgvClanarine.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(436, 461);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(217, 24);
            this.label9.TabIndex = 21;
            this.label9.Text = "Prikaz plaćenih članarina";
            // 
            // UCEvidencijaClanarine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvClanarine);
            this.Controls.Add(this.cmbMesec);
            this.Controls.Add(this.txtImePrezimeClana);
            this.Controls.Add(this.txtIdClanaKluba);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDatumUplate);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSacuvajUplatu);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.txtGodina);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvClanKluba);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.label1);
            this.Name = "UCEvidencijaClanarine";
            this.Size = new System.Drawing.Size(1058, 739);
            this.Load += new System.EventHandler(this.UCEvidencijaClanarine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanKluba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanarine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImePrezime;
        private System.Windows.Forms.DataGridView dgvClanKluba;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGodina;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.Button btnSacuvajUplatu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.DateTimePicker dtpDatumUplate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdClanaKluba;
        private System.Windows.Forms.TextBox txtImePrezimeClana;
        private System.Windows.Forms.ComboBox cmbMesec;
        private System.Windows.Forms.DataGridView dgvClanarine;
        private System.Windows.Forms.Label label9;
    }
}
