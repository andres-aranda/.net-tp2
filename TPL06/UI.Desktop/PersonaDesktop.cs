﻿using Academia.Data.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia.UI.Desktop
{
    public partial class PersonaDesktop : Form
    {
        public PersonaDesktop()
        {
            InitializeComponent();
        }

        private void PerosnaDesktop_Load(object sender, EventArgs e)
        {
            Mapeo();
        }
        private void Mapeo()
        {
            using (EntidadesTP2 db = new EntidadesTP2())
            {
                this.cmbPlan.DataSource = db.planes.ToList();
                this.cmbPlan.DisplayMember = "desc_plan";
                this.cmbPlan.ValueMember = "id_plan";
            }
        }

    }
}
