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
    public partial class frmFormulario4 : Form
    {
        public frmFormulario4()
        {
            InitializeComponent();
        }

        private void Formulario4_Load(object sender, EventArgs e)
        {
            Sectores oSectores = new Sectores();
            oSectores.ver(cboSeleccione); 
        }

        private void cboSeleccione_SelectedIndexChanged(object sender, EventArgs e)
        {
            Empleados oEmpleados = new Empleados();
            oEmpleados.ver(dgvForm4, Convert.ToInt32(cboSeleccione.SelectedValue));  
        }
    }
}
