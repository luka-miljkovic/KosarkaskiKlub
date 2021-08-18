namespace View.UserControls
{
    partial class UCIzmenaTreninga
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDatumTreningaIzbor = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumTreninga = new System.Windows.Forms.DateTimePicker();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.btnSacuvajIzmene = new System.Windows.Forms.Button();
            this.dgvTreninzi = new System.Windows.Forms.DataGridView();
            this.cmbGrupe = new System.Windows.Forms.ComboBox();
            this.cmbSale = new System.Windows.Forms.ComboBox();
            this.txtVremeOd = new System.Windows.Forms.TextBox();
            this.txtVremeDo = new System.Windows.Forms.TextBox();
            this.txtDanTreninga = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreninzi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Izmena treninga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unesite datum treninga:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grupa za treniranje:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vreme od:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vreme do:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Datum treninga:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 496);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Dan treninga:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 529);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Sala:";
            // 
            // dtpDatumTreningaIzbor
            // 
            this.dtpDatumTreningaIzbor.Location = new System.Drawing.Point(210, 100);
            this.dtpDatumTreningaIzbor.Name = "dtpDatumTreningaIzbor";
            this.dtpDatumTreningaIzbor.Size = new System.Drawing.Size(285, 22);
            this.dtpDatumTreningaIzbor.TabIndex = 8;
            // 
            // dtpDatumTreninga
            // 
            this.dtpDatumTreninga.Location = new System.Drawing.Point(210, 456);
            this.dtpDatumTreninga.Name = "dtpDatumTreninga";
            this.dtpDatumTreninga.Size = new System.Drawing.Size(285, 22);
            this.dtpDatumTreninga.TabIndex = 9;
            this.dtpDatumTreninga.ValueChanged += new System.EventHandler(this.dtpDatumTreninga_ValueChanged);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(49, 135);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(135, 27);
            this.btnPretrazi.TabIndex = 10;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // btnSacuvajIzmene
            // 
            this.btnSacuvajIzmene.Location = new System.Drawing.Point(49, 572);
            this.btnSacuvajIzmene.Name = "btnSacuvajIzmene";
            this.btnSacuvajIzmene.Size = new System.Drawing.Size(135, 28);
            this.btnSacuvajIzmene.TabIndex = 11;
            this.btnSacuvajIzmene.Text = "Sačuvaj izmene";
            this.btnSacuvajIzmene.UseVisualStyleBackColor = true;
            this.btnSacuvajIzmene.Click += new System.EventHandler(this.btnSacuvajIzmene_Click);
            // 
            // dgvTreninzi
            // 
            this.dgvTreninzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreninzi.Location = new System.Drawing.Point(49, 180);
            this.dgvTreninzi.Name = "dgvTreninzi";
            this.dgvTreninzi.RowHeadersWidth = 51;
            this.dgvTreninzi.RowTemplate.Height = 24;
            this.dgvTreninzi.Size = new System.Drawing.Size(446, 150);
            this.dgvTreninzi.TabIndex = 12;
            this.dgvTreninzi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTreninzi_CellContentClick);
            // 
            // cmbGrupe
            // 
            this.cmbGrupe.FormattingEnabled = true;
            this.cmbGrupe.Location = new System.Drawing.Point(210, 346);
            this.cmbGrupe.Name = "cmbGrupe";
            this.cmbGrupe.Size = new System.Drawing.Size(285, 24);
            this.cmbGrupe.TabIndex = 13;
            // 
            // cmbSale
            // 
            this.cmbSale.FormattingEnabled = true;
            this.cmbSale.Location = new System.Drawing.Point(210, 522);
            this.cmbSale.Name = "cmbSale";
            this.cmbSale.Size = new System.Drawing.Size(132, 24);
            this.cmbSale.TabIndex = 14;
            // 
            // txtVremeOd
            // 
            this.txtVremeOd.Location = new System.Drawing.Point(210, 386);
            this.txtVremeOd.Name = "txtVremeOd";
            this.txtVremeOd.Size = new System.Drawing.Size(132, 22);
            this.txtVremeOd.TabIndex = 15;
            // 
            // txtVremeDo
            // 
            this.txtVremeDo.Location = new System.Drawing.Point(210, 419);
            this.txtVremeDo.Name = "txtVremeDo";
            this.txtVremeDo.Size = new System.Drawing.Size(132, 22);
            this.txtVremeDo.TabIndex = 16;
            // 
            // txtDanTreninga
            // 
            this.txtDanTreninga.Enabled = false;
            this.txtDanTreninga.Location = new System.Drawing.Point(210, 491);
            this.txtDanTreninga.Name = "txtDanTreninga";
            this.txtDanTreninga.Size = new System.Drawing.Size(132, 22);
            this.txtDanTreninga.TabIndex = 17;
            // 
            // UCIzmenaTreninga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDanTreninga);
            this.Controls.Add(this.txtVremeDo);
            this.Controls.Add(this.txtVremeOd);
            this.Controls.Add(this.cmbSale);
            this.Controls.Add(this.cmbGrupe);
            this.Controls.Add(this.dgvTreninzi);
            this.Controls.Add(this.btnSacuvajIzmene);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.dtpDatumTreninga);
            this.Controls.Add(this.dtpDatumTreningaIzbor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCIzmenaTreninga";
            this.Size = new System.Drawing.Size(792, 648);
            this.Load += new System.EventHandler(this.UCIzmenaTreninga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreninzi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDatumTreningaIzbor;
        private System.Windows.Forms.DateTimePicker dtpDatumTreninga;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Button btnSacuvajIzmene;
        private System.Windows.Forms.DataGridView dgvTreninzi;
        private System.Windows.Forms.ComboBox cmbGrupe;
        private System.Windows.Forms.ComboBox cmbSale;
        private System.Windows.Forms.TextBox txtVremeOd;
        private System.Windows.Forms.TextBox txtVremeDo;
        private System.Windows.Forms.TextBox txtDanTreninga;
    }
}
