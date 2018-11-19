using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_SIGSJC.Modelo
{
    class Minga
    {
        SqlConnection conn;
        private int idMinga { get; set; }
        private DateTime fechaMinga { get; set; }
        private string descripcion { get; set; }
        private int numeroDeAsistentes { get; set; }
        private float multaPorFaltas { get; set; }
        private float rubroAnual { get; set; }


        public int getIdMinga()
        {
            return idMinga;
        }

        public void setIdMinga(int idMinga)
        {
            this.idMinga = idMinga;
        }


        public DateTime getFechaMinga()
        {
            return fechaMinga;
        }

        public void setFechaMinga(DateTime fechaMinga)
        {
            this.fechaMinga = fechaMinga;
        }


        public string getDescripcion()
        {
            return descripcion;
        }

        public void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }


        public int getNumeroDeAsistentes()
        {
            return idMinga;
        }

        public void setNumeroDeAsistentes(int numeroDeAsistentes)
        {
            this.numeroDeAsistentes = numeroDeAsistentes;
        }

        public float getMultaPorFaltas()
        {
            return multaPorFaltas;
        }

        public void setMultaPorFaltas(float multaPorFaltas)
        {
            this.multaPorFaltas = multaPorFaltas;
        }

        public float getRubroAnual()
        {
            return multaPorFaltas;
        }

        public void setRubroAnual(float rubroanual)
        {
            this.rubroAnual = rubroanual;
        }

        
      


    }
}
