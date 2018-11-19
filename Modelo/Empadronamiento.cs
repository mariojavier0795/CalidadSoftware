using System;
using System.Data.SqlClient;

namespace PROYECTO_SIGSJC.Modelo
{
    class Empadronamiento
    {
        SqlConnection conn;
        private int idEmpadronamiento { get; set; }
        private string nombreDeEmpadronamiento { get; set; }
        private DateTime fechaEmpadronamiento { get; set; }
        private int numeroDeAsistentes { get; set; }
        private string descripcion { get; set; }
        private float valorDePago { get; set; }
        private float valorDePagoConMulta { get; set; }

        public Empadronamiento(int idEmpadronamiento, string nombreDeEmpadronamiento, DateTime fechaEmpadronamiento, int numeroDeAsistentes, string descripcion, float valorDePago, float valorDePagoConMulta)
        {
            this.idEmpadronamiento = idEmpadronamiento;
            this.nombreDeEmpadronamiento = nombreDeEmpadronamiento ?? throw new ArgumentNullException(nameof(nombreDeEmpadronamiento));
            this.fechaEmpadronamiento = fechaEmpadronamiento;
            this.numeroDeAsistentes = numeroDeAsistentes;
            this.descripcion = descripcion ?? throw new ArgumentNullException(nameof(descripcion));
            this.valorDePago = valorDePago;
            this.valorDePagoConMulta = valorDePagoConMulta;
        }




    }
}
