using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using PROYECTO_SIGSJC.Properties;
using PROYECTO_SIGSJC.Controles;
namespace PROYECTO_SIGSJC.Vistas
{
    public partial class Prueba : Form 
    {

        SqlConnection cn = ConexionBD.conectar();
        ControlesEventos controlesEventos;
        public Prueba()
        {
            InitializeComponent();

            controlesEventos = new ControlesEventos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String nombre = txtNombre.Text;

            try
            {
                dataGridView1.DataSource = controlesEventos.buscarAsambleaPorNombre(nombre);

            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex+"");
                throw;
            }
            

           /* cn.Open();
            MessageBox.Show("Conexion Exitosa");
            cn.Close();*/        }

        private void Prueba_Load(object sender, EventArgs e)
        {

            //var controlesEventos = new ControlesEventos();
            //dataGridView1.DataSource = controlesEventos.listarAsambleas();
        }
    }
}
