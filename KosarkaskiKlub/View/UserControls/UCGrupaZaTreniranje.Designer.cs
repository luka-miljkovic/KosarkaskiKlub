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
            this.cmbSale = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvTreninzi = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDodajTrenong = new System.Windows.Forms.Button();
            this.txtVremeDo = new System.Windows.Forms.TextBox();
            this.txtVremeOd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDanTreninga = new System.Windows.Forms.ComboBox();
            this.txtRBTreninga = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreninzi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grupa za treniranje";
            // 
            // cmbUzrast
            // 
            this.cmbUzrast.FormattingEnabled = true;
            this.cmbUzrast.Items.AddRange(new object[] {
            "skola kosarke",
            "mladji pioniri",
            "pioniri",
            "juniori",
            "seniori"});
            this.cmbUzrast.Location = new System.Drawing.Point(154, 104);
            this.cmbUzrast.Name = "cmbUzrast";
            this.cmbUzrast.Size = new System.Drawing.Size(121, 24);
            this.cmbUzrast.TabIndex = 7;
            // 
            // txtNazivGrupe
            // 
            this.txtNazivGrupe.Location = new System.Drawing.Point(154, 69);
            this.txtNazivGrupe.Name = "txtNazivGrupe";
            this.txtNazivGrupe.Size = new System.Drawing.Size(121, 22);
            this.txtNazivGrupe.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Uzrast:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Naziv grupe:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSale);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dgvTreninzi);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnDodajTrenong);
            this.groupBox1.Controls.Add(this.txtVremeDo);
            this.groupBox1.Controls.Add(this.txtVremeOd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbDanTreninga);
            this.groupBox1.Controls.Add(this.txtRBTreninga);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(35, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 440);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos treninga";
            // 
            // cmbSale
            // 
            this.cmbSale.FormattingEnabled = true;
            this.cmbSale.Location = new System.Drawing.Point(180, 180);
            this.cmbSale.Name = "cmbSale";
            this.cmbSale.Size = new System.Drawing.Size(135, 24);
            this.cmbSale.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Sala:";
            // 
            // dgvTreninzi
            // 
            this.dgvTreninzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreninzi.Location = new System.Drawing.Point(25, 274);
            this.dgvTreninzi.Name = "dgvTreninzi";
            this.dgvTreninzi.RowHeadersVisible = false;
            this.dgvTreninzi.RowHeadersWidth = 51;
            this.dgvTreninzi.RowTemplate.Height = 24;
            this.dgvTreninzi.Size = new System.Drawing.Size(681, 150);
            this.dgvTreninzi.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(180, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 33);
            this.button2.TabIndex = 9;
            this.button2.Text = "Obrisi trening";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDodajTrenong
            // 
            this.btnDodajTrenong.Location = new System.Drawing.Point(25, 235);
            this.btnDodajTrenong.Name = "btnDodajTrenong";
            this.btnDodajTrenong.Size = new System.Drawing.Size(130, 33);
            this.btnDodajTrenong.TabIndex = 8;
            this.btnDodajTrenong.Text = "Dodaj trening";
            this.btnDodajTrenong.UseVisualStyleBackColor = true;
            this.btnDodajTrenong.Click += new System.EventHandler(this.btnDodajTrenong_Click);
            // 
            // txtVremeDo
            // 
            this.txtVremeDo.Location = new System.Drawing.Point(180, 142);
            this.txtVremeDo.Name = "txtVremeDo";
            this.txtVremeDo.Size = new System.Drawing.Size(135, 22);
            this.txtVremeDo.TabIndex = 7;
            // 
            // txtVremeOd
            // 
            this.txtVremeOd.Location = new System.Drawing.Point(180, 109);
            this.txtVremeOd.Name = "txtVremeOd";
            this.txtVremeOd.Size = new System.Drawing.Size(135, 22);
            this.txtVremeOd.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Vreme do:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Vreme od:";
            // 
            // cmbDanTreninga
            // 
            this.cmbDanTreninga.FormattingEnabled = true;
            this.cmbDanTreninga.Items.AddRange(new object[] {
            "ponedeljak",
            "utorak",
            "sreda",
            "cetvrtak",
            "petak",
            "subota",
            "nedelja"});
            this.cmbDanTreninga.Location = new System.Drawing.Point(180, 70);
            this.cmbDanTreninga.Name = "cmbDanTreninga";
            this.cmbDanTreninga.Size = new System.Drawing.Size(135, 24);
            this.cmbDanTreninga.TabIndex = 3;
            // 
            // txtRBTreninga
            // 
            this.txtRBTreninga.Location = new System.Drawing.Point(180, 32);
            this.txtRBTreninga.Name = "txtRBTreninga";
            this.txtRBTreninga.Size = new System.Drawing.Size(135, 22);
            this.txtRBTreninga.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Dan treninga:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Redni broj treninga:";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Location = new System.Drawing.Point(60, 589);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(130, 33);
            this.btnSacuvaj.TabIndex = 9;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // UCGrupaZaTreniranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbUzrast);
            this.Controls.Add(this.txtNazivGrupe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCGrupaZaTreniranje";
            this.Size = new System.Drawing.Size(764, 635);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDodajTrenong;
        private System.Windows.Forms.TextBox txtVremeDo;
        private System.Windows.Forms.TextBox txtVremeOd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDanTreninga;
        private System.Windows.Forms.TextBox txtRBTreninga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ComboBox cmbSale;
        private System.Windows.Forms.Label label8;
    }
}
