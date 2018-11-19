using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoComuna
{
    public partial class IUGestionDeUsuarios : Form
    {
        public IUGestionDeUsuarios()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IUsuario nu = new IUsuario();
            nu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta Seguro de Eliminar Usuario", "AVÍSO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IUModificarUsuario mu = new IUModificarUsuario();
            mu.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea salir del sistema?", "Cerrando sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
