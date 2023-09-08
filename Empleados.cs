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
    class Empleados
    {
        string cadena; 
        OleDbConnection conector;
        OleDbCommand Comando;
        OleDbDataAdapter Adaptador;
        DataTable tabla; 
        public Empleados()
        {
            cadena = "provider=microsoft.jet.oledb.4.0;data source=EMPRESA.mdb"; 
            conector = new OleDbConnection(cadena);
            Comando = new OleDbCommand();
            Comando.Connection = conector;
            Comando.CommandType = CommandType.TableDirect;
            Comando.CommandText = "Empleados";
            Adaptador = new OleDbDataAdapter(Comando);
            tabla = new DataTable();
            Adaptador.Fill(tabla);  
        }
        public void ver(DataGridView Grilla)  
        {
            Grilla.DataSource = tabla; 
        }      

    }
}
