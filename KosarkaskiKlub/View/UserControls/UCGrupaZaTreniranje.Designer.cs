namespace View.UserControls
{
    partial class UCGrupaZaTreniranje
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmbUzrast = new System.Windows.Forms.ComboBox();
            this.txtNazivGrupe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDodajTrening = new System.Windows.Forms.Button();
            this.btnObrisiTrening = new System.Windows.Forms.Button();
            this.cmbSale = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvTreninzi = new System.Windows.Forms.DataGridView();
            this.txtVremeDo = new System.Windows.Forms.TextBox();
            this.txtVremeOd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDanTreninga = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreninzi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unos nove grupe za treniranje";
            // 
            // cmbUzrast
            // 
            this.cmbUzrast.BackColor = System.Drawing.SystemColors.Window;
            this.cmbUzrast.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUzrast.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbUzrast.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUzrast.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbUzrast.Items.AddRange(new object[] {
            "skola kosarke",
            "mladji pioniri",
            "pioniri",
            "juniori",
            "seniori"});
            this.cmbUzrast.Location = new System.Drawing.Point(143, 105);
            this.cmbUzrast.Name = "cmbUzrast";
            this.cmbUzrast.Size = new System.Drawing.Size(121, 24);
            this.cmbUzrast.TabIndex = 7;
            // 
            // txtNazivGrupe
            // 
            this.txtNazivGrupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNazivGrupe.Location = new System.Drawing.Point(143, 68);
            this.txtNazivGrupe.Name = "txtNazivGrupe";
            this.txtNazivGrupe.Size = new System.Drawing.Size(121, 22);
            this.txtNazivGrupe.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Uzrast:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Naziv grupe:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDodajTrening);
            this.groupBox1.Controls.Add(this.btnObrisiTrening);
            this.groupBox1.Controls.Add(this.cmbSale);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dgvTreninzi);
            this.groupBox1.Controls.Add(this.txtVremeDo);
            this.groupBox1.Controls.Add(this.txtVremeOd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbDanTreninga);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 391);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos treninga";
            // 
            // btnDodajTrening
            // 
            this.btnDodajTrening.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajTrening.Location = new System.Drawing.Point(25, 202);
            this.btnDodajTrening.Name = "btnDodajTrening";
            this.btnDodajTrening.Size = new System.Drawing.Size(135, 30);
            this.btnDodajTrening.TabIndex = 15;
            this.btnDodajTrening.Text = "Dodaj trening";
            this.btnDodajTrening.UseVisualStyleBackColor = true;
            this.btnDodajTrening.Click += new System.EventHandler(this.btnDodajTrening_Click);
            // 
            // btnObrisiTrening
            // 
            this.btnObrisiTrening.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiTrening.Location = new System.Drawing.Point(181, 202);
            this.btnObrisiTrening.Name = "btnObrisiTrening";
            this.btnObrisiTrening.Size = new System.Drawing.Size(130, 30);
            this.btnObrisiTrening.TabIndex = 14;
            this.btnObrisiTrening.Text = "Obriši trening";
            this.btnObrisiTrening.UseVisualStyleBackColor = true;
            this.btnObrisiTrening.Click += new System.EventHandler(this.btnObrisiTrening_Click);
            // 
            // cmbSale
            // 
            this.cmbSale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSale.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSale.FormattingEnabled = true;
            this.cmbSale.Location = new System.Drawing.Point(181, 151);
            this.cmbSale.Name = "cmbSale";
            this.cmbSale.Size = new System.Drawing.Size(135, 24);
            this.cmbSale.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Sala:";
            // 
            // dgvTreninzi
            // 
            this.dgvTreninzi.AllowUserToAddRows = false;
            this.dgvTreninzi.AllowUserToDeleteRows = false;
            this.dgvTreninzi.AllowUserToResizeColumns = false;
            this.dgvTreninzi.AllowUserToResizeRows = false;
            this.dgvTreninzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreninzi.Location = new System.Drawing.Point(25, 251);
            this.dgvTreninzi.Name = "dgvTreninzi";
            this.dgvTreninzi.ReadOnly = true;
            this.dgvTreninzi.RowHeadersWidth = 51;
            this.dgvTreninzi.RowTemplate.Height = 24;
            this.dgvTreninzi.Size = new System.Drawing.Size(496, 116);
            this.dgvTreninzi.TabIndex = 10;
            this.dgvTreninzi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTreninzi_CellClick);
            // 
            // txtVremeDo
            // 
            this.txtVremeDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVremeDo.Location = new System.Drawing.Point(181, 110);
            this.txtVremeDo.Name = "txtVremeDo";
            this.txtVremeDo.Size = new System.Drawing.Size(135, 22);
            this.txtVremeDo.TabIndex = 7;
            // 
            // txtVremeOd
            // 
            this.txtVremeOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVremeOd.Location = new System.Drawing.Point(181, 75);
            this.txtVremeOd.Name = "txtVremeOd";
            this.txtVremeOd.Size = new System.Drawing.Size(135, 22);
            this.txtVremeOd.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Vreme do:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Vreme od:";
            // 
            // cmbDanTreninga
            // 
            this.cmbDanTreninga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDanTreninga.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbDanTreninga.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDanTreninga.FormattingEnabled = true;
            this.cmbDanTreninga.Items.AddRange(new object[] {
            "ponedeljak",
            "utorak",
            "sreda",
            "cetvrtak",
            "petak",
            "subota",
            "nedelja"});
            this.cmbDanTreninga.Location = new System.Drawing.Point(181, 34);
            this.cmbDanTreninga.Name = "cmbDanTreninga";
            this.cmbDanTreninga.Size = new System.Drawing.Size(135, 24);
            this.cmbDanTreninga.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Dan treninga:";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Location = new System.Drawing.Point(49, 550);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(130, 30);
            this.btnSacuvaj.TabIndex = 9;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(326, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Datum od:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(326, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Datum do:";
            // 
            // dtpDatumOd
            // 
            this.dtpDatumOd.CustomFormat = "dd.MM.yyyy.";
            this.dtpDatumOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumOd.Location = new System.Drawing.Point(412, 65);
            this.dtpDatumOd.Name = "dtpDatumOd";
            this.dtpDatumOd.Size = new System.Drawing.Size(133, 22);
            this.dtpDatumOd.TabIndex = 12;
            // 
            // dtpDatumDo
            // 
            this.dtpDatumDo.CustomFormat = "dd.MM.yyyy.";
            this.dtpDatumDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumDo.Location = new System.Drawing.Point(412, 99);
            this.dtpDatumDo.Name = "dtpDatumDo";
            this.dtpDatumDo.Size = new System.Drawing.Size(133, 22);
            this.dtpDatumDo.TabIndex = 13;
            // 
            // UCGrupaZaTreniranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpDatumDo);
            this.Controls.Add(this.dtpDatumOd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbUzrast);
            this.Controls.Add(this.txtNazivGrupe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCGrupaZaTreniranje";
            this.Size = new System.Drawing.Size(904, 762);
            this.Load += new System.EventHandler(this.UCGrupaZaTreniranje_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreninzi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbUzrast;
        private System.Windows.Forms.TextBox txtNazivGrupe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTreninzi;
        private System.Windows.Forms.TextBox txtVremeDo;
        private System.Windows.Forms.TextBox txtVremeOd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDanTreninga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ComboBox cmbSale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDatumOd;
        private System.Windows.Forms.DateTimePicker dtpDatumDo;
        private System.Windows.Forms.Button btnDodajTrening;
        private System.Windows.Forms.Button btnObrisiTrening;
    }
}
