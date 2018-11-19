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
    public partial class IUGestionDeEventos : Form
    {
        public IUGestionDeEventos()
        {
            InitializeComponent();
            btn = this.Width - tableLayoutPanel1.Width;
        }

        int btn;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void IGestionEventos_Load(object sender, EventArgs e)
        {

        }

        private void IGestionEventos_Resize(object sender, EventArgs e)
        {
            tableLayoutPanel1.Width = this.Width - btn;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new IUCreacionDeEvento().ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new IUVisualizacionDeEventos().ShowDialog();
        }

        private void btnSalirDelSistema_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir del sistema?", "Cerrando sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
