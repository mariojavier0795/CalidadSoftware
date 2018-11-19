using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace PROYECTO_SIGSJC.Modelo
{
    
    public class Asamblea
    {
        SqlConnection conn;

        private int idAsamblea { get; set; }
        private string nombreDeAsamblea { get; set; }
        private DateTime fechaAsamblea { get; set; }
        private int numeroDeAsistentes { get; set; }
        private string descripcion { get; set; }
        private float valorDePago { get; set; }
        private float valorDePagoConMulta { get; set; }

        public Asamblea(int idAsamblea, string nombreDeAsamblea, DateTime fechaAsamblea, int numeroDeAsistentes, string descripcion, float valorDePago, float valorDePagoConMulta)
        {
            this.idAsamblea = idAsamblea;
            this.nombreDeAsamblea = nombreDeAsamblea ?? throw new ArgumentNullException(nameof(nombreDeAsamblea));
            this.fechaAsamblea = fechaAsamblea;
            this.numeroDeAsistentes = numeroDeAsistentes;
            this.descripcion = descripcion ?? throw new ArgumentNullException(nameof(descripcion));
            this.valorDePago = valorDePago;
            this.valorDePagoConMulta = valorDePagoConMulta;
        }



    }
}
