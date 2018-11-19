using System;

using MySql.Data.MySqlClient;
namespace ExposicionGUI
{
   
    
        public class Comunero : Persona
        {
            private int idBarrio { get; set; }
            private String comuneroOficial { get; set; }
            private String cabezaDeFamilia { get; set; }
            private String ocupacion { get; set; }
            private String numeroDeTelefonoFijo { get; set; }
            private String numeroDeTelefonoMovil { get; set; }
            private String correoElectronico { get; set; }
            private DateTime fechaLlegadaAComuna { get; set; }
            private DateTime fechaDeFallecimiento;

            public Comunero()
            {
            }

            public Comunero(int idBarrio, String comuneroOficial, String cabezaDeFamilia,
                String ocupacion, String numeroDeTelefonoFijo, String numeroDeTelefonoMovil,
                String correoElectronico, DateTime fechaLlegadaAComuna, DateTime fechaDeFallecimiento,
                int idPersona, int idDiscapacidad, String cedulaDeIdentidad, String nombreCompleto,
                String sexo, String lugarDeNacimiento, DateTime fechaDeNacimiento) : base(idPersona, idDiscapacidad, cedulaDeIdentidad, nombreCompleto, sexo, lugarDeNacimiento, fechaDeNacimiento)
            {
                this.idBarrio = idBarrio;
                this.comuneroOficial = comuneroOficial;
                this.cabezaDeFamilia = cabezaDeFamilia;
                this.ocupacion = ocupacion;
                this.numeroDeTelefonoFijo = numeroDeTelefonoFijo;
                this.numeroDeTelefonoMovil = numeroDeTelefonoMovil;
                this.correoElectronico = correoElectronico;
                this.fechaLlegadaAComuna = fechaLlegadaAComuna;
                this.fechaDeFallecimiento = fechaDeFallecimiento;
            }


        public int getIdBarrio()
        {
            return idBarrio;
        }

        public void setIdBarrio(int idBarrio)
        {
            this.idBarrio = idBarrio;
        }

        public String getComuneroOficial()
        {
            return comuneroOficial;
        }

        public void setComuneroOficial(String comuneroOficial)
        {
            this.comuneroOficial = comuneroOficial;
        }

        public String getCabezaDeFamilia()
        {
            return cabezaDeFamilia;
        }

        public void setCabezaDeFamilia(String cabezaDeFamilia)
        {
            this.cabezaDeFamilia = cabezaDeFamilia;
        }

        public String getOcupacion()
        {
            return ocupacion;
        }

        public void setOcupacion(String ocupacion)
        {
            this.ocupacion = ocupacion;
        }

        public String getNumeroDeTelefonoFijo()
        {
            return numeroDeTelefonoFijo;
        }

        public void setNumeroDeTelefonoFijo(String numeroDeTelefonoFijo)
        {
            this.numeroDeTelefonoFijo = numeroDeTelefonoFijo;
        }

        public String getNumeroDeTelefonoMovil()
        {
            return numeroDeTelefonoMovil;
        }

        public void setNumeroDeTelefonoMovil(String numeroDeTelefonoMovil)
        {
            this.numeroDeTelefonoMovil = numeroDeTelefonoMovil;
        }

        public String getCorreoElectronico()
        {
            return correoElectronico;
        }

        public void setCorreoElectronico(String correoElectronico)
        {
            this.correoElectronico = correoElectronico;
        }

        public DateTime getFechaLlegadaAComuna()
        {
            return fechaLlegadaAComuna;
        }

        public void setFechaLlegadaAComuna(DateTime fechaLlegadaAComuna)
        {
            this.fechaLlegadaAComuna = fechaLlegadaAComuna;
        }

        public DateTime getFechaDeFallecimiento()
        {
            return fechaDeFallecimiento;
        }

        public void setFechaDeFallecimiento(DateTime fechaDeFallecimiento)
        {
            this.fechaDeFallecimiento = fechaDeFallecimiento;
        }
    }
    


}