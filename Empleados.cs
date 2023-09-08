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
        public void ver(ComboBox Combo)
        {
            Combo.DisplayMember = "nombre";
            Combo.ValueMember = "dni";
            Combo.DataSource = tabla; 
        }
        public void ver(ListBox Nombre) 
        {
            Nombre.DisplayMember = "nombre";
            Nombre.ValueMember = "dni";
            Nombre.DataSource = tabla; 
        }
        public void verExe(DataGridView Grilla)
        {
            Grilla.Columns.Clear(); 
            Grilla.Columns.Add("c1", "dni");
            Grilla.Columns.Add("c2", "nombre");

            foreach (DataRow fila in tabla.Rows) 
            {
                Grilla.Rows.Add(fila["dni"], fila["nombre"]); 
            }      
        }
        public void ver(DataGridView Grilla, int Sector)
        {
            Grilla.Rows.Clear(); 
            foreach (DataRow fila in tabla.Rows)
            {
                if(fila["sector"].ToString() == Sector.ToString())
                {
                    Grilla.Rows.Add(fila["dni"], fila["nombre"], fila["sueldo"]);
                } 
                
            }
        }

    }
}
