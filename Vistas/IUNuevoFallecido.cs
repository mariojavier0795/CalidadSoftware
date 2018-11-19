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

namespace PROYECTO_SIGSJC.Vistas //PROYECTO_SIGSJC
{
    public partial class IUNuevoFallecido : Form
    {
        ControlCementerio cc;

        public IUNuevoFallecido()
        {
            InitializeComponent();
            txtCédula.MaxLength = 10;
            dateTimePicker.MaxDate = DateTime.Today;
            dateTimePicker.MinDate = new DateTime(DateTime.Today.Year,DateTime.Today.Month,1 );
            //textNombres.MaxLength = 50;
            cc = new ControlCementerio();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCédula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNicho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            string cedula = txtCédula.Text.ToString();
            int nicho = Convert.ToInt32(txtNicho.Text.Trim().ToString());

            if (validar(cedula)==true)
            {
                if (comprobarNicho(nicho)==true)
                {
                    // MessageBox.Show("Registro Exitoso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cc.nuevoFallecido(txtCédula, dateTimePicker,txtNicho);
                    txtCédula.Text = "";
                    textNombres.Text = "";
                    txtNicho.Text = "";
                }
                else if (comprobarNicho(nicho) == false)
                {
                    MessageBox.Show("Registro no Exitoso\nNicho ya ocupado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

            }
            else
            {
                MessageBox.Show("Registro no Exitoso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            

        }
        public Boolean comprobarNicho( int nicho)
        {
            int resp= 
            cc.buscarNicho(nicho);
            MessageBox.Show(resp.ToString());
            if (resp == 0)
            {
                return true;
            }
            return false;
        }



        public Boolean validar(string cedula)
        {
            char[] vector = cedula.ToArray();
            int sumatotal = 0;
            if (vector.Length == 10)
            {
                for (int i = 0; i < vector.Length - 1; i++)
                {
                    int numero = Convert.ToInt32(vector[i].ToString());
                    if ((i + 1) % 2 == 1)
                    {
                        numero = Convert.ToInt32(vector[i].ToString()) * 2;
                        if (numero > 9)
                        {
                            numero = numero - 9;
                        }
                    }
                    sumatotal += numero;
                }
                sumatotal = 10 - (sumatotal % 10);
                int ultNum = (int)Char.GetNumericValue(vector[vector.Length - 1]);
                if (sumatotal > 9)
                {
                    //MessageBox.Show("Número de final es: " + 0);
                 
                    return true;
                    
                }
                else
                {
                    //MessageBox.Show("Número  es: " + vector[vector.Length - 1]+"suma"+sumatotal);
                    if (ultNum ==sumatotal)
                    {
                       // MessageBox.Show("VErdadero Número de final es: " + sumatotal);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                 MessageBox.Show("Número de cédula menor a 10 dígitos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void txtCédula_TextChanged(object sender, EventArgs e)
        {
            if (txtCédula.TextLength == 10)
            {
                String existe = cc.buscarSiComuneroRegistradoCedula(txtCédula.Text.Trim().ToString());
                if (existe.Equals("no"))
                {
                    String nombre = cc.buscarComuneroCedula(txtCédula.Text.ToString()).ToString();
                    textNombres.Text = nombre;
                }
                else
                {
                    MessageBox.Show("Fallecido ya registrado");

                }
                

            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNicho_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNicho_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCédula_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
