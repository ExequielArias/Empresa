using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Empresa
{
    class Sectores
    {
        string cadena;
        OleDbConnection conector;
        OleDbCommand Comando;
        OleDbDataAdapter Adaptador;
        DataTable tabla;
        public Sectores()
        {
            cadena = "provider=microsoft.jet.oledb.4.0;data source=EMPRESA.mdb";
            conector = new OleDbConnection(cadena);
            Comando = new OleDbCommand();
            Comando.Connection = conector;
            Comando.CommandType = CommandType.TableDirect;
            Comando.CommandText = "Sectores";
            Adaptador = new OleDbDataAdapter(Comando);
            tabla = new DataTable();
            Adaptador.Fill(tabla);
        }
        public void ver(ComboBox Combo)
        {
            Combo.DisplayMember = "nombre";
            Combo.ValueMember = "sector";
            Combo.DataSource = tabla;
        }
    }
}
