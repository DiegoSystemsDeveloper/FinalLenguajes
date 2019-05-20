using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Mejora_tu_salud
{
    class BD
    {
        String conexion = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ..\..\BD\DB_Mejora_tu_salud.accdb";
        string SQL;
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        DataTable table = new DataTable();

        public DataTable ingresarAlSistema(string usuario, string contraseña)
        {
            table.Clear();
            SQL = "select usuario, contrasena from tbEmpleados where Usuario = '" + usuario + "' AND Contrasena = '" + contraseña + "'";
            adapter = new OleDbDataAdapter(SQL, conexion);
            adapter.Fill(table);
            return table;
        }
    }
}
