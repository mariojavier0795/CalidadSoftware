using System;
namespace ExposicionGUI
{
    

    public class Persona
    {
        private int idPersona { get; set; }
        private int idDiscapacidad { get; set; }
        private String cedulaDeIdentidad { get; set; }
        private String nombreCompleto { get; set; }
        private String sexo { get; set; }
        private String lugarDeNacimiento { get; set; }
        private DateTime fechaDeNacimiento { get; set; }



        public Persona()
        {
        }

        public Persona(int idPersona, int idDiscapacidad, String cedulaDeIdentidad, String nombreCompleto, String sexo, String lugarDeNacimiento, DateTime fechaDeNacimiento)
        {
            this.idPersona = idPersona;
            this.idDiscapacidad = idDiscapacidad;
            this.cedulaDeIdentidad = cedulaDeIdentidad;
            this.nombreCompleto = nombreCompleto;
            this.sexo = sexo;
            this.lugarDeNacimiento = lugarDeNacimiento;
            this.fechaDeNacimiento = fechaDeNacimiento;
        }

        public int getIdPersona()
        {
            return idPersona;
        }

        public void setIdPersona(int idPersona)
        {
            this.idPersona = idPersona;
        }

        public int getIdDiscapacidad()
        {
            return idDiscapacidad;
        }

        public void setIdDiscapacidad(int idDiscapacidad)
        {
            this.idDiscapacidad = idDiscapacidad;
        }


        
        public String GetCedulaDeIdentidad()
        {
            return cedulaDeIdentidad;
        }

        public void SetCedulaDeIdentidad(String cedulaDeIdentidad)
        {
            this.cedulaDeIdentidad = cedulaDeIdentidad;
        }

        public String getNombreCompleto()
        {
            return nombreCompleto;
        }

        public void setNombreCompleto(String nombreCompleto)
        {
            this.nombreCompleto = nombreCompleto;
        }

        public String getSexo()
        {
            return sexo;
        }

        public void setSexo(String sexo)
        {
            this.sexo = sexo;
        }

        public String getLugarDeNacimiento()
        {
            return lugarDeNacimiento;
        }

        public void setLugarDeNacimiento(String lugarDeNacimiento)
        {
            this.lugarDeNacimiento = lugarDeNacimiento;
        }

        public DateTime getFechaDeNacimiento()
        {
            return fechaDeNacimiento;
        }

        public void setFechaDeNacimiento(DateTime fechaDeNacimiento)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }

    }
}