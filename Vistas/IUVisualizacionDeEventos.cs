using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO_SIGSJC.Controles;
using PROYECTO_SIGSJC.Vistas;

namespace PROYECTO_SIGSJC
{
    public partial class IUVisualizacionDeEventos : Form
    {
        private ControlesEventos ce;
        public IModificarEvento me;
       


        public IUVisualizacionDeEventos()
        {
            ce = new ControlesEventos();
            me = new IModificarEvento();

            InitializeComponent();
            rBAsamblea.Checked = false;
            rBEmp.Checked = false;
            rBMinga.Checked = false;
            cBParametro.DropDownStyle = ComboBoxStyle.DropDownList;
            cBParametro.Enabled = false;
            txtbusqueda.Enabled = false;
            dGtabla.Visible = false; 
            bModificar.Enabled = false;

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            // new IUModificacionDeEvento().Show();
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rBAsamblea_CheckedChanged(object sender, EventArgs e)
        {
            cBParametro.Enabled = true;
            dGtabla.Visible = true;
            txtbusqueda.Enabled = false;
            txtbusqueda.Text = "";
            ce.vaciar(dGtabla);

        }

        private void rBEmp_CheckedChanged(object sender, EventArgs e)
        {
            cBParametro.Enabled = true;
            dGtabla.Visible = true;
            txtbusqueda.Enabled = false;
            txtbusqueda.Text= "";
            ce.vaciar(dGtabla);

        }

        private void rBMinga_CheckedChanged(object sender, EventArgs e)
        {
            cBParametro.Enabled = true;
            dGtabla.Visible = true;
            txtbusqueda.Enabled = false;
            txtbusqueda.Text = "";
            ce.vaciar(dGtabla);
            //cBParametro.Items[1]= "";
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rBAsamblea.Checked || rBEmp.Checked )
            {
                if (cBParametro.Text == "Nombre")
                {
                    txtbusqueda.Text = "";
                    txtbusqueda.Enabled = true;

                }


                if (cBParametro.Text == "Fecha")
                {
                    txtbusqueda.Text = "";
                    txtbusqueda.Enabled = true;
                }

            }
            else 
            {
                if (cBParametro.Text == "Nombre")
                {
                    txtbusqueda.Text = "Evento tipo minga no posee nombre";
                    txtbusqueda.Enabled = false;

                }


                if (cBParametro.Text == "Fecha")
                {
                    txtbusqueda.Text = "";
                    txtbusqueda.Enabled = true;
                }
            }
             
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void bModificar_Click(object sender,EventArgs e)
        {
            if (MessageBox.Show("Desea Modificar los Datos de este evento?","MODIFICAR DATOS",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string tipo="";

               

                try
                {
                    
                    if (rBAsamblea.Checked)
                    {
                        tipo = "Asamblea";
                        me.cBTipo.Text = tipo;
                    }
                    tipo = "";

                    if (rBEmp.Checked)
                    {

                        tipo = "Empadronamiento";
                        me.cBTipo.Text = tipo;
                    }
                    tipo = "";
                    if(rBMinga.Checked)
                    {
                        tipo = "Minga";
                        me.cBTipo.Text = tipo;

                    }
                    tipo = "";

                    tipo = "";
                } catch (Exception ex) {
                    MessageBox.Show("" + ex + "");
                }

                me.ShowDialog();
                txtbusqueda.Text = "";

                

            }
            
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            
            if (rBAsamblea.Checked)
            {
                
                if (cBParametro.Text == "Nombre")
                {
                    txtbusqueda.Enabled = true;
                    if (txtbusqueda.Text.Trim().Length > 0)
                    {
                        ce.buscarAsambleaLike(dGtabla, txtbusqueda.Text.Trim());
                        //ce.vaciar();
                    }
                    else
                    {
                        ce.vaciar(dGtabla);
                    }
                }

               

                if (cBParametro.Text == "Fecha")
                {
                    

                    if (txtbusqueda.Text.Trim().Length > 0)
                    {
                        ce.buscarAsambleaLikeFecha(dGtabla, txtbusqueda.Text.Trim());
                        //ce.vaciar();
                    }
                    else
                    {
                        ce.vaciar(dGtabla);
                    }


                }
                
            }

           

            if (rBEmp.Checked)
            {
                //txtbusqueda.Text = "";
                if (cBParametro.Text == "Nombre")
                {
                    
                    txtbusqueda.Enabled = true;
                    if (txtbusqueda.Text.Trim().Length > 0)
                    {
                        ce.buscarEmpadronamientoLike(dGtabla, txtbusqueda.Text.Trim());
                        //ce.vaciar();
                    }
                    else
                    {
                        ce.vaciar(dGtabla);
                    }
                }

                if(cBParametro.Text == "Fecha")
                {
                    
                    if (txtbusqueda.Text.Trim().Length > 0)
                    {
                        ce.buscarEmpadronamientoLikeFecha(dGtabla, txtbusqueda.Text.Trim());
                        //ce.vaciar();
                    }
                    else
                    {
                        ce.vaciar(dGtabla);
                    }


                }
                 
                
            }

           


            if (rBMinga.Checked)
            {
               // txtbusqueda.Text = "";
                if (cBParametro.Text == "Fecha")
                {
                    
                    if (txtbusqueda.Text.Trim().Length > 0)
                    {
                        ce.buscarMingaLike(dGtabla, txtbusqueda.Text.Trim());
                        //ce.vaciar();
                    }
                    else
                    {
                        ce.vaciar(dGtabla);
                    }
                }
                if(cBParametro.Text == "Nombre")
                {
                    MessageBox.Show("No se puede buscar una minga por Nombre");
                }
                
            }
          
        }

        

        private void dGtabla_DoubleClick(object sender, EventArgs e)
        {
          
            

        }

        private void dGtabla_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void dGtabla_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

           /*if(MessageBox.Show("Desea Modificar los Datos de este evento?", "MODIFICAR DATOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (e.RowIndex != -1)
                    {
                        if (e.RowIndex != -1)
                        {
                            me.txtEntero.Text = dGtabla.Rows[e.RowIndex].Cells[4].Value.ToString();
                            me.txtNombre.Visible = false;
                            //me.cBTipo.Text = "Asamblea";
                            me.dateP.Text = dGtabla.Rows[e.RowIndex].Cells[1].Value.ToString();
                            me.txtDesc.Text = dGtabla.Rows[e.RowIndex].Cells[2].Value.ToString();
                            me.txtAsis.Text = dGtabla.Rows[e.RowIndex].Cells[3].Value.ToString();

                            bModificar.Enabled = true;
                        }

                        me.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un Dato");
                    }


                }
                catch (Exception ex){MessageBox.Show("" + ex + "");}

            }*/

        }

        private void dGtabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (rBMinga.Checked)
            {
                if (e.RowIndex != -1)
                {
                    me.txtEntero.Text = dGtabla.Rows[e.RowIndex].Cells[4].Value.ToString();
                    me.txtNombre.Text = "";
                    me.txtNombre.Enabled = false;
                    //me.cBTipo.Text = "Asamblea";
                    me.dateP.Text = dGtabla.Rows[e.RowIndex].Cells[1].Value.ToString();
                    me.txtDesc.Text = dGtabla.Rows[e.RowIndex].Cells[2].Value.ToString();
                    me.txtAsis.Text = dGtabla.Rows[e.RowIndex].Cells[3].Value.ToString();

                    bModificar.Enabled = true;
                }
            }
            if(rBEmp.Checked)
            {
                if (e.RowIndex != -1)
                {
                    me.txtEntero.Text = dGtabla.Rows[e.RowIndex].Cells[4].Value.ToString();
                    me.txtNombre.Text = dGtabla.Rows[e.RowIndex].Cells[0].Value.ToString();
                    me.txtNombre.Enabled = true;
                    //me.cBTipo.Text = "Asamblea";
                    me.dateP.Text = dGtabla.Rows[e.RowIndex].Cells[1].Value.ToString();
                    me.txtDesc.Text = dGtabla.Rows[e.RowIndex].Cells[2].Value.ToString();
                    me.txtAsis.Text = dGtabla.Rows[e.RowIndex].Cells[3].Value.ToString();

                    bModificar.Enabled = true;
                }
            } 

            if (rBAsamblea.Checked)
            {
                if (e.RowIndex != -1)
                {
                    me.txtEntero.Text = dGtabla.Rows[e.RowIndex].Cells[4].Value.ToString();
                    me.txtNombre.Text = dGtabla.Rows[e.RowIndex].Cells[0].Value.ToString();
                    me.txtNombre.Enabled = true;
                    //me.cBTipo.Text = "Asamblea";
                    me.dateP.Text = dGtabla.Rows[e.RowIndex].Cells[1].Value.ToString();
                    me.txtDesc.Text = dGtabla.Rows[e.RowIndex].Cells[2].Value.ToString();
                    me.txtAsis.Text = dGtabla.Rows[e.RowIndex].Cells[3].Value.ToString();

                    bModificar.Enabled = true;
                }
            }


        }

        private void txtbusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            string opc = cBParametro.SelectedItem.ToString();
            if (opc.Equals("Fecha")){
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
        }

        private void dGtabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bRegresar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
