using PROYECTO_SIGSJC.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_SIGSJC.Controles
{
    class ConexionBD
    {

        public static string ObtenerString()
        {
            return Settings.Default.conexion;

        }


        public static SqlConnection conectar()
        {
            SqlConnection cn = new SqlConnection(ObtenerString());

            //cn.Open();
            
            return cn;
        }

    }
}
