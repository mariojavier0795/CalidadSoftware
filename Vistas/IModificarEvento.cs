using PROYECTO_SIGSJC.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_SIGSJC.Vistas
{
    public partial class IModificarEvento : Form
    {
        ControlesEventos ce;
        public IModificarEvento()
        {
            InitializeComponent();
            
        }

        private void IModificarEvento_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cBTipo.Text == "Asamblea")
            {
                ce = new ControlesEventos();
                string id = txtEntero.Text.Trim();
                //MessageBox.Show("" + id);
                ce.actualizarAsamblea(id, txtNombre, dateP, txtDesc);

                this.Close();
                
            }

            if(cBTipo.Text == "Empadronamiento")
            {
                ce = new ControlesEventos();
                string id = txtEntero.Text.Trim();
                //MessageBox.Show("" + id);
                ce.actualizarEmpadronamiento(id, txtNombre, dateP, txtDesc);

                this.Close();
            }

            if (cBTipo.Text == "Minga")
            {
                ce = new ControlesEventos();
                string id = txtEntero.Text.Trim();
                //MessageBox.Show("" + id);
                ce.actualizarEmpadronamiento(id, txtNombre, dateP, txtDesc);
                
                this.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
