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
    public partial class IUModificacionDatosDeComunero : Form
    {
        public IUModificacionDatosDeComunero()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos Guardados Exitosamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
