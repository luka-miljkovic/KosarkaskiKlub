namespace View.UserControls
{
    partial class UCPrikazGrupeZaTreniranje
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
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtNazivGrupe = new System.Windows.Forms.TextBox();
            this.txtTrener = new System.Windows.Forms.TextBox();
            this.txtDatumFormiranja = new System.Windows.Forms.TextBox();
            this.txtUzrast = new System.Windows.Forms.TextBox();
            this.txtIdGrupe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvClanovi = new System.Windows.Forms.DataGridView();
            this.dgvGrupe = new System.Windows.Forms.DataGridView();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.dgvTreninzi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreninzi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prikaz grupe za treniranje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unesite naziv grupe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(653, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Naziv grupe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(653, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum formiranja:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(653, 469);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Uzrast:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(653, 499);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Trener:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(653, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "ID grupe:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(177, 66);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(189, 22);
            this.txtNaziv.TabIndex = 7;
            // 
            // txtNazivGrupe
            // 
            this.txtNazivGrupe.Location = new System.Drawing.Point(793, 393);
            this.txtNazivGrupe.Name = "txtNazivGrupe";
            this.txtNazivGrupe.ReadOnly = true;
            this.txtNazivGrupe.Size = new System.Drawing.Size(112, 22);
            this.txtNazivGrupe.TabIndex = 8;
            // 
            // txtTrener
            // 
            this.txtTrener.Location = new System.Drawing.Point(793, 496);
            this.txtTrener.Name = "txtTrener";
            this.txtTrener.ReadOnly = true;
            this.txtTrener.Size = new System.Drawing.Size(112, 22);
            this.txtTrener.TabIndex = 9;
            // 
            // txtDatumFormiranja
            // 
            this.txtDatumFormiranja.Location = new System.Drawing.Point(793, 427);
            this.txtDatumFormiranja.Name = "txtDatumFormiranja";
            this.txtDatumFormiranja.ReadOnly = true;
            this.txtDatumFormiranja.Size = new System.Drawing.Size(112, 22);
            this.txtDatumFormiranja.TabIndex = 9;
            // 
            // txtUzrast
            // 
            this.txtUzrast.Location = new System.Drawing.Point(793, 464);
            this.txtUzrast.Name = "txtUzrast";
            this.txtUzrast.ReadOnly = true;
            this.txtUzrast.Size = new System.Drawing.Size(112, 22);
            this.txtUzrast.TabIndex = 10;
            // 
            // txtIdGrupe
            // 
            this.txtIdGrupe.Location = new System.Drawing.Point(793, 355);
            this.txtIdGrupe.Name = "txtIdGrupe";
            this.txtIdGrupe.ReadOnly = true;
            this.txtIdGrupe.Size = new System.Drawing.Size(112, 22);
            this.txtIdGrupe.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Prikaz članova:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 575);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Prikaz treninga:";
            // 
            // dgvClanovi
            // 
            this.dgvClanovi.AllowUserToAddRows = false;
            this.dgvClanovi.AllowUserToDeleteRows = false;
            this.dgvClanovi.AllowUserToOrderColumns = true;
            this.dgvClanovi.AllowUserToResizeColumns = false;
            this.dgvClanovi.AllowUserToResizeRows = false;
            this.dgvClanovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanovi.Location = new System.Drawing.Point(34, 379);
            this.dgvClanovi.Name = "dgvClanovi";
            this.dgvClanovi.ReadOnly = true;
            this.dgvClanovi.RowHeadersVisible = false;
            this.dgvClanovi.RowHeadersWidth = 51;
            this.dgvClanovi.RowTemplate.Height = 24;
            this.dgvClanovi.Size = new System.Drawing.Size(571, 150);
            this.dgvClanovi.TabIndex = 14;
            // 
            // dgvGrupe
            // 
            this.dgvGrupe.AllowUserToAddRows = false;
            this.dgvGrupe.AllowUserToDeleteRows = false;
            this.dgvGrupe.AllowUserToResizeColumns = false;
            this.dgvGrupe.AllowUserToResizeRows = false;
            this.dgvGrupe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupe.Location = new System.Drawing.Point(37, 155);
            this.dgvGrupe.Name = "dgvGrupe";
            this.dgvGrupe.ReadOnly = true;
            this.dgvGrupe.RowHeadersVisible = false;
            this.dgvGrupe.RowHeadersWidth = 51;
            this.dgvGrupe.RowTemplate.Height = 24;
            this.dgvGrupe.Size = new System.Drawing.Size(568, 150);
            this.dgvGrupe.TabIndex = 16;
            this.dgvGrupe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrupe_CellClick);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(37, 103);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(86, 27);
            this.btnPretrazi.TabIndex = 17;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // dgvTreninzi
            // 
            this.dgvTreninzi.AllowUserToAddRows = false;
            this.dgvTreninzi.AllowUserToDeleteRows = false;
            this.dgvTreninzi.AllowUserToOrderColumns = true;
            this.dgvTreninzi.AllowUserToResizeColumns = false;
            this.dgvTreninzi.AllowUserToResizeRows = false;
            this.dgvTreninzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreninzi.Location = new System.Drawing.Point(34, 613);
            this.dgvTreninzi.Name = "dgvTreninzi";
            this.dgvTreninzi.ReadOnly = true;
            this.dgvTreninzi.RowHeadersVisible = false;
            this.dgvTreninzi.RowHeadersWidth = 51;
            this.dgvTreninzi.RowTemplate.Height = 24;
            this.dgvTreninzi.Size = new System.Drawing.Size(754, 150);
            this.dgvTreninzi.TabIndex = 18;
            // 
            // UCPrikazGrupeZaTreniranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTreninzi);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.dgvGrupe);
            this.Controls.Add(this.dgvClanovi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIdGrupe);
            this.Controls.Add(this.txtUzrast);
            this.Controls.Add(this.txtDatumFormiranja);
            this.Controls.Add(this.txtTrener);
            this.Controls.Add(this.txtNazivGrupe);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCPrikazGrupeZaTreniranje";
            this.Size = new System.Drawing.Size(952, 1224);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupe)).EndInit();
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
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtNazivGrupe;
        private System.Windows.Forms.TextBox txtTrener;
        private System.Windows.Forms.TextBox txtDatumFormiranja;
        private System.Windows.Forms.TextBox txtUzrast;
        private System.Windows.Forms.TextBox txtIdGrupe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvClanovi;
        private System.Windows.Forms.DataGridView dgvGrupe;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.DataGridView dgvTreninzi;
    }
}
