using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoComuna;
using ExposicionGUI;
namespace PROYECTO_SIGSJC
{
    public partial class IUPantallaPrincipal : Form
    {
        public IUPantallaPrincipal()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea salir del sistema?", "Cerrando sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void hacerUnaSugerenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnInformacionDeUsuario_Click(object sender, EventArgs e)
        {
            new IUGestionDeUsuarios().Show();
        }

        private void btnGestionDeEventos_Click(object sender, EventArgs e)
        {
            new IUGestionDeEventos().ShowDialog();
        }

        private void btnControlDeAsistencias_Click(object sender, EventArgs e)
        {
            new IUControlDeAsistencias().Show();
        }

        private void btnGestionDeComuneros_Click(object sender, EventArgs e)
        {
            new IUGestionDeComuneros().Show();
        }

        private void btnConfiguracionDeParametros_Click(object sender, EventArgs e)
        {
            new IUModificacionDeParametros().Show();
        }

        private void btnEstadistica_Click(object sender, EventArgs e)
        {
            new IUEstadistica().Show();
        }

        private void btnAdministracionFinanciera_Click(object sender, EventArgs e)
        {
            new IUAdministracionFinanciera().Show();
        }

        private void btnGestionDelCementerio_Click(object sender, EventArgs e)
        {
            new IUGestionDelCementerio().Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cerrar la sesión?", "Cerrando sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new IUIngresoAlSistema().Show();
                this.Close();
            }
        }
    }
}
