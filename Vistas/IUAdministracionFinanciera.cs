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
    public partial class IUAdministracionFinanciera : Form
    {
        private ControlFinanciero cf;
        public IUDatosDeDeuda dd;

        public IUAdministracionFinanciera()
        {
            InitializeComponent();

            //botones no habilitados al ingresar al modulo
            btnAnularDeuda.Enabled = false;
            btn_RegPago.Enabled = false;
            btnVerDatosDelComunero.Enabled = false;
            txtBusqueda.Enabled = false;
            txtBusquedaEmpadron.Enabled = false;
            txtBusquedaMinga.Enabled = false;
            txtBusquedaComunero.Enabled = false;
            btnAnularDeudaEmpadron.Enabled = false;
            btnAnularDeudaMinga.Enabled = false;
            btnDatosDeudaEmpadron.Enabled = false;
            btnDatosDeudaMinga.Enabled = false;
            btnAnularDeudaEmpadron.Enabled = false;
            btnAnularDeudaMinga.Enabled = false;
            btnRegPagoEmpadron.Enabled = false;
            btnRegPagoMin.Enabled = false;
            btnAnularDeudaComun.Enabled = false;
            btnDatosDeudaComunero.Enabled = false;
            btnRegPagoComunero.Enabled = false;


            cf = new ControlFinanciero();
            dd = new IUDatosDeDeuda();

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

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalirDelSistema_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir del sistema?", "Cerrando sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea anular esta deuda?", "Cerrando sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //MessageBox.Show("Deuda anulada","Información",);
                MessageBox.Show("Deuda anulada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVerDatosDelComunero_Click(object sender, EventArgs e)
        {

            dd.txtCedula.Text = dataGridFinan.CurrentRow.Cells[0].Value.ToString();
            dd.txtNombre.Text = dataGridFinan.CurrentRow.Cells[1].Value.ToString();
            dd.txtFec.Text = Convert.ToString(dataGridFinan.CurrentRow.Cells[4].ToString());
            dd.txtMontoDeuda.Text = dataGridFinan.CurrentRow.Cells[3].Value.ToString();
            dd.txtRazón.Text = dataGridFinan.CurrentRow.Cells[2].Value.ToString();
            dd.ShowDialog();

        }
        private void comboBoxModoDeBúsqueda_MouseClick(object sender, EventArgs e)
        {
            String opc = comboBoxModoDeBusqueda.SelectedItem.ToString();
            if (opc == "Número de Cédula")
            {
                txtBusqueda.Enabled = true;
            }
            else if (opc == "Nombre Completo")
            {
                txtBusqueda.Enabled = true;
            }

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
            else if (selec.Equals(null))
            {
                txtBusqueda.Enabled = false;
            }
        }

        private void comboBoxModoDeBusqueda_MouseDown(object sender, MouseEventArgs e)
        {
            txtBusqueda.Enabled = true;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnVerDatosDelComunero.Enabled = true;
            btn_RegPago.Enabled = true;
            btnAnularDeuda.Enabled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnVerDatosDelComunero.Enabled = true;
            btn_RegPago.Enabled = true;
            btnAnularDeuda.Enabled = true;
        }

        private void btn_RegPago_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea registrar el pago de esta deuda?", "Cerrando sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                String cedula = dataGridFinan.CurrentRow.Cells[0].Value.ToString();
                String razon = "Asamblea";
                cf.registrarPagoporCed(cedula, razon);


            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string opc = comboBoxModoDeBusqueda.SelectedItem.ToString();
            if (comboBoxModoDeBusqueda.Text.Trim() == "Número de Cédula")
            {

                txtBusqueda.Enabled = true;
                if (txtBusqueda.Text.Trim().Length > 0)
                {
                    cf.buscarDeudorLikeCed(dataGridFinan, txtBusqueda.Text.Trim());
                }
                else
                {
                    cf.vaciar(dataGridFinan);
                }

            }
            else if (opc.Equals("Nombre Completo"))
            {
                txtBusqueda.Enabled = true;
                if (txtBusqueda.Text.Trim().Length > 0)
                {
                    cf.buscarDeudorLikeNombre(dataGridFinan, txtBusqueda.Text.Trim());
                }
                else
                {
                    cf.vaciar(dataGridFinan);
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegresar_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRegMinga_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalirMinga_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea salir del sistema?", "Cerrando sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSalirEmpadron_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea salir del sistema?", "Cerrando sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSalirDelSistema_Click_2(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea salir del sistema?", "Cerrando sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDatosDeudaEmpadron_Click(object sender, EventArgs e)
        {
            if (dataGridFEmpadronam.CurrentRow.Cells[0].Value.ToString().Equals(""))
            {
                MessageBox.Show("Seleccione la celda de la deuda que desea visualizar", "Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                dd.txtCedula.Text = dataGridFEmpadronam.CurrentRow.Cells[0].Value.ToString();
                dd.txtNombre.Text = dataGridFEmpadronam.CurrentRow.Cells[1].Value.ToString();
                string fec = Convert.ToString(dataGridFEmpadronam.CurrentRow.Cells[4].Value.ToString());
                if (fec.Length > 0)
                {
                    dd.txtFec.Text = (fec).Substring(0, 10);
                }
                else
                {
                    dd.txtFec.Text = Convert.ToString(dataGridFEmpadronam.CurrentRow.Cells[4].Value.ToString());
                }
                dd.txtMontoDeuda.Text = dataGridFEmpadronam.CurrentRow.Cells[3].Value.ToString();
                dd.txtRazón.Text = dataGridFEmpadronam.CurrentRow.Cells[2].Value.ToString();
                dd.txtEstado.Text = dataGridFEmpadronam.CurrentRow.Cells[5].Value.ToString();
                dd.ShowDialog();
            }

            

        }

        private void btnDatosDeudaMinga_Click(object sender, EventArgs e)
        {
            if (dataGridFMinga.CurrentRow.Cells[0].Value.ToString().Equals(""))
            {
                MessageBox.Show("Seleccione la celda de la deuda que desea visualizar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dd.txtCedula.Text = dataGridFMinga.CurrentRow.Cells[0].Value.ToString();
                dd.txtNombre.Text = dataGridFMinga.CurrentRow.Cells[1].Value.ToString();
                //dd.txtFec.Text = Convert.ToString(dataGridFinan.CurrentRow.Cells[4].ToString());
                string fec = Convert.ToString(dataGridFMinga.CurrentRow.Cells[4].Value.ToString());
                if (fec.Length > 0)
                {
                    dd.txtFec.Text = (fec).Substring(0, 10);
                }
                else
                {
                    dd.txtFec.Text = Convert.ToString(dataGridFMinga.CurrentRow.Cells[4].Value.ToString());
                }
                dd.txtMontoDeuda.Text = dataGridFMinga.CurrentRow.Cells[3].Value.ToString();
                dd.txtRazón.Text = dataGridFMinga.CurrentRow.Cells[2].Value.ToString();
                dd.txtEstado.Text = dataGridFMinga.CurrentRow.Cells[5].Value.ToString();
                dd.ShowDialog();
            }
            
        }

        private void dataGridFEmpadronam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDatosDeudaEmpadron.Enabled = true;
            btnAnularDeudaEmpadron.Enabled = true;
            btnRegPagoEmpadron.Enabled = true;
            btnAnularDeudaEmpadron.Enabled = true;
        }

        private void dataGridFMinga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDatosDeudaMinga.Enabled = true;
            btnAnularDeudaMinga.Enabled = true;
            btnRegPagoMin.Enabled = true;
        }

        private void txtBusquedaEmpadron_TextChanged(object sender, EventArgs e)
        {
            //string opc = comboBoxModoDeBusqueda.SelectedItem.ToString();
            if (cmbBusquedaEmpadron.Text.Trim() == "Número de Cédula")
            {

                txtBusquedaEmpadron.Enabled = true;
                if (txtBusquedaEmpadron.Text.Trim().Length > 0)
                {
                    cf.buscarDeudorEmpadLikeCed(dataGridFEmpadronam, txtBusquedaEmpadron);
                }
                else
                {
                    cf.vaciar(dataGridFEmpadronam);
                }

            }
            else if (cmbBusquedaEmpadron.Text.Trim() == "Nombre Completo")
            {
                txtBusquedaEmpadron.Enabled = true;
                if (txtBusquedaEmpadron.Text.Trim().Length > 0)
                {
                    cf.buscarDeudorEmpadLikeNombre(dataGridFEmpadronam, txtBusquedaEmpadron.Text.Trim());
                }
                else
                {
                    cf.vaciar(dataGridFEmpadronam);
                }
            }
        }

        private void txtBusquedaMinga_TextChanged(object sender, EventArgs e)
        {
            if (cmbBuscasMinga.Text.Trim() == "Número de Cédula")
            {

                txtBusquedaMinga.Enabled = true;
                if (txtBusquedaMinga.Text.Trim().Length > 0)
                {
                    cf.buscarDeudorMinLikeCed(dataGridFMinga, txtBusquedaMinga.Text.Trim());
                }
                else
                {
                    cf.vaciar(dataGridFMinga);
                }

            }
            else if (cmbBuscasMinga.Text.Trim() == "Nombre Completo")
            {
                txtBusquedaMinga.Enabled = true;
                if (txtBusquedaMinga.Text.Trim().Length > 0)
                {
                    cf.buscarDeudorMinLikeNombre(dataGridFMinga, txtBusquedaMinga.Text.Trim());
                }
                else
                {
                    cf.vaciar(dataGridFMinga);
                }
            }
        }

        private void btnRegPagoEmpadron_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea registrar el pago de esta deuda?", "Cerrando sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                String cedula = dataGridFEmpadronam.CurrentRow.Cells[0].Value.ToString();
                String razon = "Empadronamiento";
                cf.registrarPagoporCed(cedula, razon);
                cf.vaciar(dataGridFEmpadronam);

            }
        }

        private void btnRegPagoMin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea registrar el pago de esta deuda?", "Cerrando sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String cedula = dataGridFMinga.CurrentRow.Cells[0].Value.ToString();
                String razon = "Cementerio";
                cf.registrarPagoporCed(cedula, razon);
                cf.vaciar(dataGridFMinga);

            }
        }

        private void txtBusquedaEmpadron_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbBusquedaEmpadron.Text.Trim() == "Número de Cédula")
            {
                txtBusquedaEmpadron.MaxLength = 10;
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }

                else if (cmbBusquedaEmpadron.Text.Trim() == "Nombre Completo")
                {
                    txtBusquedaEmpadron.MaxLength = 50;
                    if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                    {
                        MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        e.Handled = true;
                        return;
                    }
                }
                else if (cmbBusquedaEmpadron.Text.Trim() == "")
                {
                    txtBusqueda.Enabled = false;
                }
            }
        }


        private void txtBusquedaMinga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbBuscasMinga.Text.Trim() == "Número de Cédula")
            {
                txtBusquedaMinga.MaxLength = 10;
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }

                else if (cmbBuscasMinga.Text.Trim() == "Nombre Completo")
                {
                    txtBusquedaMinga.MaxLength = 50;
                    if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                    {
                        MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        e.Handled = true;
                        return;
                    }
                }
                else if (cmbBuscasMinga.Text.Trim() == "")
                {
                    txtBusqueda.Enabled = false;
                }
            }
        }

        private void btnAnularDeudaMinga_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea anular esta deuda?", "Deuda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String cedula = dataGridFMinga.CurrentRow.Cells[0].Value.ToString();
                String razon = "Cementerio";
                cf.anularporCed(cedula, razon);
                cf.vaciar(dataGridFMinga);
            }

        }

        private void btnAnularDeudaEmpadron_Click(object sender, EventArgs e)
        {
            String cedula = dataGridFEmpadronam.CurrentRow.Cells[0].Value.ToString();
            String razon = "Empadronamiento";
            cf.anularporCed(cedula, razon);
            cf.vaciar(dataGridFEmpadronam);
        }

        private void comboBoxModoDeBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBusqueda.Enabled = true;
            txtBusqueda.Text = "";
        }

        private void txtBusqueda_TextChanged_1(object sender, EventArgs e)
        {
            if (comboBoxModoDeBusqueda.Text.Trim() == "Número de Cédula")
            {

                txtBusqueda.Enabled = true;
                if (txtBusqueda.Text.Trim().Length > 0)
                {
                    cf.buscarDeudorLikeCed(dataGridFinan, txtBusqueda.Text.Trim());
                }
                else
                {
                    cf.vaciar(dataGridFinan);
                }

            }
            else if (comboBoxModoDeBusqueda.Text.Trim() == "Nombre Completo")
            {
                txtBusqueda.Enabled = true;
                if (txtBusqueda.Text.Trim().Length > 0)
                {
                    cf.buscarDeudorLikeNombre(dataGridFinan, txtBusqueda.Text.Trim());
                }
                else
                {
                    cf.vaciar(dataGridFinan);
                }
            }
        }

        private void dataGridFinan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnVerDatosDelComunero.Enabled = true;
            btn_RegPago.Enabled = true;
            btnAnularDeuda.Enabled = true;
        }

        private void dataGridFinan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int monto = Convert.ToInt32(dataGridFinan.CurrentRow.Cells[3].Value.ToString());
            if (monto > 0)
            {
                btnVerDatosDelComunero.Enabled = true;
                btn_RegPago.Enabled = true;
                btnAnularDeuda.Enabled = true;
            }
            else
            {
                btnVerDatosDelComunero.Enabled = true;
                btn_RegPago.Enabled = false;
                btnAnularDeuda.Enabled = false;
            }

                
        }

        private void dataGridFEmpadronam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int monto = Convert.ToInt32(dataGridFEmpadronam.CurrentRow.Cells[3].Value.ToString());
            if(monto > 0)
            {
                btnDatosDeudaEmpadron.Enabled = true;
                btnRegPagoEmpadron.Enabled = true;
                btnAnularDeudaEmpadron.Enabled = true;
            }
            else
            {
                btnDatosDeudaEmpadron.Enabled = true;
                btnRegPagoEmpadron.Enabled = false;
                btnAnularDeudaEmpadron.Enabled = false;
            }
            

        }

        private void dataGridFMinga_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int monto = Convert.ToInt32(dataGridFMinga.CurrentRow.Cells[3].Value.ToString());
            if (monto > 0)
            {
                btnDatosDeudaMinga.Enabled = true;
                btnRegPagoMin.Enabled = true;
                btnAnularDeudaMinga.Enabled = true;
            }
            else
            {
                btnDatosDeudaMinga.Enabled = true;
                btnRegPagoMin.Enabled = false;
                btnAnularDeudaMinga.Enabled = false;

            }
            
        }

        private void btnVerDatosDelComunero_Click_1(object sender, EventArgs e)
        {
            dd.txtCedula.Text = dataGridFinan.CurrentRow.Cells[0].Value.ToString();
            dd.txtNombre.Text = dataGridFinan.CurrentRow.Cells[1].Value.ToString();
            string fec = Convert.ToString(dataGridFinan.CurrentRow.Cells[4].Value.ToString());
            if(fec.Length > 0)
            {
                dd.txtFec.Text = (fec).Substring(0, 10);
            }
            else
            {
                dd.txtFec.Text = Convert.ToString(dataGridFinan.CurrentRow.Cells[4].Value.ToString());
            }
            dd.txtMontoDeuda.Text = dataGridFinan.CurrentRow.Cells[3].Value.ToString();
            dd.txtRazón.Text = dataGridFinan.CurrentRow.Cells[2].Value.ToString();
            dd.txtEstado.Text = dataGridFinan.CurrentRow.Cells[5].Value.ToString();
            dd.ShowDialog();
        }

        private void cmbBusquedaEmpadron_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBusquedaEmpadron.Enabled = true;
            txtBusquedaEmpadron.Text = "";
            cf.vaciar(dataGridFEmpadronam);
        }

        private void cmbBuscasMinga_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBusquedaMinga.Enabled = true;
            txtBusquedaMinga.Text = "";
            cf.vaciar(dataGridFMinga);
        }

        private void btn_RegPago_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea registrar el pago de esta deuda?", "Cerrando sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                String cedula = dataGridFinan.CurrentRow.Cells[0].Value.ToString();
                String razon = "Asamblea";
                cf.registrarPagoporCed(cedula, razon);
                cf.vaciar(dataGridFinan);


            }
        }

        private void btnAnularDeuda_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea anular esta deuda?", "Cerrando sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String cedula = dataGridFinan.CurrentRow.Cells[0].Value.ToString();
                String razon = "Asamblea";
                cf.anularporCed(cedula, razon);
                cf.vaciar(dataGridFinan);
            }
        }

        private void txtBusqueda_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            string selec = comboBoxModoDeBusqueda.SelectedItem.ToString();
            if (comboBoxModoDeBusqueda.Text.Trim()=="Número de Cédula")
            {
                txtBusqueda.MaxLength = 10;
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
            else if (comboBoxModoDeBusqueda.Text.Trim()=="Nombre Completo")
            {
                txtBusqueda.MaxLength = 50;
                if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
            else if (comboBoxModoDeBusqueda.Text.Trim()==null)
            {
                txtBusqueda.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string datosnulos = Convert.ToString(dataGridComunero.CurrentRow.Cells[0].Value.ToString());
            if (datosnulos.Equals(null))
            {
                MessageBox.Show("Seleccione la celda de la deuda que desea visualizar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dd.txtCedula.Text = dataGridComunero.CurrentRow.Cells[0].Value.ToString();
                dd.txtNombre.Text = dataGridComunero.CurrentRow.Cells[1].Value.ToString();
                //dd.txtFec.Text = Convert.ToString(dataGridFinan.CurrentRow.Cells[4].ToString());
                string fec = Convert.ToString(dataGridComunero.CurrentRow.Cells[4].Value.ToString());
                if (fec.Length > 0)
                {
                    dd.txtFec.Text = (fec).Substring(0, 10);
                }
                else
                {
                    dd.txtFec.Text = Convert.ToString(dataGridComunero.CurrentRow.Cells[4].Value.ToString());
                }
                dd.txtMontoDeuda.Text = dataGridComunero.CurrentRow.Cells[3].Value.ToString();
                dd.txtRazón.Text = dataGridComunero.CurrentRow.Cells[2].Value.ToString();
                dd.txtEstado.Text = dataGridComunero.CurrentRow.Cells[5].Value.ToString();
                dd.ShowDialog();
            }
        }

        private void txtBusquedaComunero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbBuscarComuneroComun.Text.Trim() == "Número de Cédula")
            {
                txtBusquedaComunero.MaxLength = 10;
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
            else if (cmbBuscarComuneroComun.Text.Trim() == "Nombre Completo")
            {
                txtBusquedaComunero.MaxLength = 50;
                if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
            else if (cmbBuscarComuneroComun.Text.Trim() == null)
            {
                txtBusqueda.Enabled = false;
            }
        }

        private void txtBusquedaComunero_TextChanged(object sender, EventArgs e)
        {
            if (cmbBuscarComuneroComun.Text.Trim() == "Número de Cédula")
            {

                txtBusquedaComunero.Enabled = true;
                if (txtBusquedaComunero.Text.Trim().Length > 0)
                {
                    cf.buscarComuneroDeudor(dataGridComunero,txtBusquedaComunero.Text.Trim(), "cedula");
                }
                else
                {
                    cf.vaciar(dataGridComunero);
                }

            }
            else if (cmbBuscarComuneroComun.Text.Trim() == "Nombre Completo")
            {
                txtBusquedaComunero.Enabled = true;
                if (txtBusquedaComunero.Text.Trim().Length > 0)
                {
                    cf.buscarComuneroDeudor(dataGridComunero, txtBusquedaComunero.Text.Trim(), "nombre");
                }
                else
                {
                    cf.vaciar(dataGridComunero);
                }
            }
        }

        private void dataGridComunero_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int monto = Convert.ToInt32(dataGridComunero.CurrentRow.Cells[3].Value.ToString());
            if (monto > 0)
            {
                btnRegPagoComunero.Enabled = true;
                btnDatosDeudaComunero.Enabled = true;
                btnAnularDeudaComun.Enabled = true;
            }
            else
            {
                //si la multa es 0 no se puede anular o pagar
                btnRegPagoComunero.Enabled = false;
                btnDatosDeudaComunero.Enabled = true;
                btnAnularDeudaComun.Enabled = false;
            }
                
        }

        private void cmbBuscarComuneroComun_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBusquedaComunero.Enabled = true;
            txtBusquedaComunero.Text = "";
            cf.vaciar(dataGridComunero);
        }

        private void btnSalirComunero_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea salir del sistema?", "Cerrando sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRegresarComunero_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRegPagoComunero_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea registrar el pago de esta deuda?", "Deuda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                String cedula = dataGridComunero.CurrentRow.Cells[0].Value.ToString();
                String razon = dataGridComunero.CurrentRow.Cells[6].Value.ToString();
                cf.registrarPagoporCed(cedula, razon);
                cf.vaciar(dataGridComunero);
                txtBusquedaComunero.Text = "";


            }
        }

        private void btnAnularDeudaComun_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea anular esta deuda?", "Deuda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String cedula = dataGridComunero.CurrentRow.Cells[0].Value.ToString();
                String razon = dataGridComunero.CurrentRow.Cells[6].Value.ToString();
                cf.anularporCed(cedula, razon);
                cf.vaciar(dataGridComunero);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //limpiar tablas
            cf.vaciar(dataGridFinan);
            cf.vaciar(dataGridComunero);
            cf.vaciar(dataGridFEmpadronam);
            cf.vaciar(dataGridFMinga);
            //limpiar txt
            txtBusqueda.Text = "";
            txtBusquedaComunero.Text = "";
            txtBusquedaEmpadron.Text = "";
            txtBusquedaMinga.Text = "";
        }
    }
}
