using PROYECTO_SIGSJC.Controles;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_SIGSJC.Modelo
{
    class Prueba
    {
        SqlConnection con;


        public void mensaje()
        {
            con = ConexionBD.conectar();
            con.Open();

           

            
            

        }

    }


    
}
