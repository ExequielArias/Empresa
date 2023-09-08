using System;
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
    public partial class frmFormulario2 : Form
    {
        public frmFormulario2()
        {
            InitializeComponent();
        }

        private void frmFormulario2_Load(object sender, EventArgs e)
        {
            Empleados oEmpleados = new Empleados();
            oEmpleados.ver(cboNombre);
            oEmpleados.ver(lstNombre);
        }

        private void cboNombre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdFrm3_Click(object sender, EventArgs e)
        {
           frmFormulario3 Formulario3 = new frmFormulario3();
            Formulario3.ShowDialog();
        }
    }
}
