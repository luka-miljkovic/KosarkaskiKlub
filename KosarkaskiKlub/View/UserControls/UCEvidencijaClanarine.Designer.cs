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
            this.txtMesec = new System.Windows.Forms.TextBox();
            this.txtGodina = new System.Windows.Forms.TextBox();
            this.txtDatumUplate = new System.Windows.Forms.TextBox();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.btnSacuvajUplatu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPretrazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanKluba)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime i prezime clana";
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Location = new System.Drawing.Point(190, 77);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.Size = new System.Drawing.Size(164, 22);
            this.txtImePrezime.TabIndex = 1;
            // 
            // dgvClanKluba
            // 
            this.dgvClanKluba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanKluba.Location = new System.Drawing.Point(45, 145);
            this.dgvClanKluba.Name = "dgvClanKluba";
            this.dgvClanKluba.RowHeadersWidth = 51;
            this.dgvClanKluba.RowTemplate.Height = 24;
            this.dgvClanKluba.Size = new System.Drawing.Size(542, 150);
            this.dgvClanKluba.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mesec";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Godina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Datum uplate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Iznos uplate";
            // 
            // txtMesec
            // 
            this.txtMesec.Location = new System.Drawing.Point(171, 313);
            this.txtMesec.Name = "txtMesec";
            this.txtMesec.Size = new System.Drawing.Size(100, 22);
            this.txtMesec.TabIndex = 7;
            // 
            // txtGodina
            // 
            this.txtGodina.Location = new System.Drawing.Point(171, 347);
            this.txtGodina.Name = "txtGodina";
            this.txtGodina.Size = new System.Drawing.Size(100, 22);
            this.txtGodina.TabIndex = 8;
            // 
            // txtDatumUplate
            // 
            this.txtDatumUplate.Location = new System.Drawing.Point(171, 385);
            this.txtDatumUplate.Name = "txtDatumUplate";
            this.txtDatumUplate.Size = new System.Drawing.Size(100, 22);
            this.txtDatumUplate.TabIndex = 9;
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(171, 422);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(100, 22);
            this.txtIznos.TabIndex = 10;
            // 
            // btnSacuvajUplatu
            // 
            this.btnSacuvajUplatu.Location = new System.Drawing.Point(69, 499);
            this.btnSacuvajUplatu.Name = "btnSacuvajUplatu";
            this.btnSacuvajUplatu.Size = new System.Drawing.Size(146, 34);
            this.btnSacuvajUplatu.TabIndex = 11;
            this.btnSacuvajUplatu.Text = "Sacuvaj uplatu";
            this.btnSacuvajUplatu.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Evidentiranje clanarine";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(46, 106);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 25);
            this.btnPretrazi.TabIndex = 13;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // UCEvidencijaClanarine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSacuvajUplatu);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.txtDatumUplate);
            this.Controls.Add(this.txtGodina);
            this.Controls.Add(this.txtMesec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvClanKluba);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.label1);
            this.Name = "UCEvidencijaClanarine";
            this.Size = new System.Drawing.Size(632, 598);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanKluba)).EndInit();
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
        private System.Windows.Forms.TextBox txtMesec;
        private System.Windows.Forms.TextBox txtGodina;
        private System.Windows.Forms.TextBox txtDatumUplate;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.Button btnSacuvajUplatu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPretrazi;
    }
}
