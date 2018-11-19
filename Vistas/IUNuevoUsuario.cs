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
    public partial class IUsuario : Form
    {
        public IUsuario()
        {
            InitializeComponent();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Registro Exitoso", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
