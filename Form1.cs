﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            Empleados oEmpleados = new Empleados();
            oEmpleados.ver(dgvGrilla);   
        }

        private void cmdIr_Click(object sender, EventArgs e)
        {
            frmFormulario2 Formulario2 = new frmFormulario2(); 
                Formulario2.ShowDialog(); 
        }
    }
}
