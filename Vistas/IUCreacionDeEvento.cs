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
namespace PROYECTO_SIGSJC
{ 
    public partial class IUCreacionDeEvento : Form
    {
        public IUCreacionDeEvento()
        {
            InitializeComponent();
            textnombre.Enabled = false;
            textdescrip.Enabled = false;
            txtvpago.Enabled = false;
            txtvpagom.Enabled = false;
            dtfecha.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string opc = cmbTipo.Text;
            ControlesEventos ce = new ControlesEventos();

            switch (opc){

                case "Asamblea" :

                    txtvpago.Enabled = false;
                    txtvpagom.Enabled = false;
                    ce.ingresarNuevaAsamblea(textnombre, dtfecha, textdescrip, txtvpago, txtvpagom);

                //MessageBox.Show("Evento creado exitosamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //this.Close();

                break;

                case "Minga":
                    txtvpago.Enabled = false;
                    txtvpagom.Enabled = false;
                    //textnombre.Enabled = false;
                    ce.ingresarNuevaMinga(dtfecha, textdescrip, txtvpago, txtvpagom);
                    textnombre.Enabled = true;
                    break;

                case "Empadronamiento":
                    txtvpago.Enabled = false;
                    txtvpagom.Enabled = false;
                    ce.ingresarNuevoEmpadronamiento(textnombre, dtfecha, textdescrip, txtvpago, txtvpagom);
                    break;
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTipo.Text == "Minga")
            {
                
                textnombre.Enabled = false;
                textdescrip.Enabled = true;
                txtvpago.Enabled = false;
                txtvpagom.Enabled = false;
                dtfecha.Enabled = true;

            }
            if (cmbTipo.Text == "Empadronamiento")
            {
                textnombre.Enabled = true;
                textdescrip.Enabled = true;
                txtvpago.Enabled = false;
                txtvpagom.Enabled = false;
                dtfecha.Enabled = true;
            }
            if(cmbTipo.Text == "Asamblea"){
                textnombre.Enabled = true;
                textdescrip.Enabled = true;
                txtvpago.Enabled = false;
                txtvpagom.Enabled = false;
                dtfecha.Enabled = true;
            }
                
        }
    }
}
