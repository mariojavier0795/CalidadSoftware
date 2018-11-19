using PROYECTO_SIGSJC.Controles;
using PROYECTO_SIGSJC.Vistas;
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
    public partial class IUGestionDelCementerio : Form
    {
        ControlCementerio cc;
        IUNuevoFallecido nf;
        IUNicho nic;

        public IUGestionDelCementerio()
        {
            InitializeComponent();
            btnFosaC.Enabled = false;
            btnVerDatosDelComunero.Enabled = false;
            txtBusqueda.Enabled = false;
            cc = new ControlCementerio();
            nf = new IUNuevoFallecido();
            nic = new IUNicho();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalirDelSistema_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea salir del sistema?", "Cerrando sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void comboBoxModoDeBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            string selec = comboBoxModoDeBusqueda.SelectedItem.ToString();
            if (selec.Equals("Número de Cédula"))
            {
                txtBusqueda.MaxLength = 10;
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
            else if (selec.Equals("Nombre Completo"))
            {
                txtBusqueda.MaxLength = 50;
                if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
        }

        private void comboBoxModoDeBusqueda_MouseClick(object sender, MouseEventArgs e)
        {
            txtBusqueda.Enabled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnRegFallecido.Enabled = true;
            btnVerDatosDelComunero.Enabled = true;
            btnFosaC.Enabled = true;
            
        }

        private void btnRegFallecido_Click(object sender, EventArgs e)
        {
            //cc = new ControlCementerio();
            // cc.nuevoFallecido(tx);
            IUNuevoFallecido obj = new IUNuevoFallecido();
            obj.ShowDialog();


        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxModoDeBusqueda.Text.Trim() == "Número de Cédula")
            {

                txtBusqueda.Enabled = true;
                if (txtBusqueda.Text.Trim().Length > 0)
                {
                    cc.buscarFallecidoLikeCed(dataGrid, txtBusqueda.Text.Trim());
                }
                else
                {
                    cc.vaciar(dataGrid);
                }

            }
            else if (comboBoxModoDeBusqueda.Text.Trim() == "Nombre Completo")
            {
                txtBusqueda.Enabled = true;
                if (txtBusqueda.Text.Trim().Length > 0)
                {
                    cc.buscarFallecidoLikeNombre(dataGrid, txtBusqueda.Text.Trim());
                }
                else
                {
                    cc.vaciar(dataGrid);
                }
            }
        }

        private void btnFosaC_Click(object sender, EventArgs e)
        {
            String ms = "Está seguro de reubicar a: " + dataGrid.CurrentRow.Cells[1].Value.ToString() + " a fosa común";
            int i= Convert.ToInt32(dataGrid.CurrentRow.Cells[4].Value.ToString());
            String cedula = dataGrid.CurrentRow.Cells[0].ToString();
            int nic = Convert.ToInt32(dataGrid.CurrentRow.Cells[2].Value.ToString());
            DialogResult opc= MessageBox.Show(ms,"", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(opc== DialogResult.Yes)
            {
                cc.moverFosaComun(i, nic);
            }
        }

        private void btnVerDatosDelComunero_Click(object sender, EventArgs e)
        {
            // IUNicho nic = new IUNicho();
            nic.textCedula.Text = dataGrid.CurrentRow.Cells[0].Value.ToString();
            nic.textNombre.Text =dataGrid.CurrentRow.Cells[1].Value.ToString() ;
            nic.textNumNic.Text = dataGrid.CurrentRow.Cells[2].Value.ToString() ;
            nic.textFec.Text = (dataGrid.CurrentRow.Cells[3].Value.ToString()).Substring(0,10);

            nic.ShowDialog();
        }
    }
}
