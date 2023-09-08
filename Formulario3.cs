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
    public partial class frmFormulario3 : Form
    {
        public frmFormulario3()
        {
            InitializeComponent();
        }

        private void Formulario3_Load(object sender, EventArgs e)
        {
            Empleados oEmpleados = new Empleados();
            oEmpleados.verExe(dgvForm3);  
        }

        private void cmdForm4_Click(object sender, EventArgs e)
        {
            frmFormulario4 Formulario4 = new frmFormulario4();
            Formulario4.ShowDialog();
        }
    }
}
