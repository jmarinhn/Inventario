using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Agreagar la libreria Mysql dentro de la Rerencias del proyecto inventario1
using MySql.Data.MySqlClient;


namespace Inventario
{
    public class BDComun
    {
        public static MySqlConnection ObtenerConexion()
        {

            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=maestroclie; Uid=root; pwd=root; SslMode=none;");
            conectar.Open();
            return conectar;


        }

    }
}
