﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Controller;
using Domen;

namespace View.UserControls
{
    public partial class UCUnosPrisustva : UserControl
    {
        UnosPrisustvaController unosPrisustvaController;
        public UCUnosPrisustva(Controller.UnosPrisustvaController unosPrisustvaController)
        {
            InitializeComponent();
            this.unosPrisustvaController = unosPrisustvaController;
            this.dtpDatumTreninga.Value = Convert.ToDateTime("10.10.2020");
        }

        private void btnPretraziTreninge_Click(object sender, EventArgs e)
        {
            unosPrisustvaController.PretraziTreninge(dtpDatumTreninga, dgvTreninzi, txtNazivGrupe, cbDatum, cbNaziv);
        }

        private void btnSacuvajPrisustva_Click(object sender, EventArgs e)
        {
            unosPrisustvaController.SacuvajPrisustva(dgvClanovi);
        }

        private void dgvTreninzi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            unosPrisustvaController.PrikaziClanove(dgvTreninzi, dgvClanovi, btnSacuvajPrisustva);
        }
    }
}
