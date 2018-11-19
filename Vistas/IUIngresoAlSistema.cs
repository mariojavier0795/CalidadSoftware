using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_SIGSJC
{
    public partial class IUIngresoAlSistema : Form
    {
        public IUIngresoAlSistema()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea salir del sistema?", "Cerrando sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex==0&&txtNombreDeUsuario.Text=="admin"&&txtContrasenia.Text=="123")
            {
                MessageBox.Show("Bienvenido al Sistema Integrado de Gestión de la Comuna San José de Cocotog");
                new IUPantallaPrincipal().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");

            }
        }
    }
}
