using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO_SIGSJC;
namespace ExposicionGUI
{
    public partial class IUGestionDeComuneros : Form
    {
        List<Comunero> lista = new List<Comunero>();
        public IUGestionDeComuneros()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (!((e.KeyCode < Keys.NumPad9 && e.KeyCode > Keys.NumPad0)|| e.KeyCode != Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String busqueda = txtBusqueda.Text;
            MySqlConnection dbConn = new MySqlConnection("Persist Security Info=False;server=localhost;database=bdcomunasanjosedecocotog;uid=root;password=" + "");
            MySqlCommand cmd = dbConn.CreateCommand();
            int index=comboBoxModoDeBusqueda.SelectedIndex;
            if (index != -1)
            {
                if(index==0)
                {
                    cmd.CommandText = "SELECT * from comunero WHERE cedulaDeidentidad LIKE '" + busqueda + "%' LIMIT 0,100";

                }
                else
                {
                    cmd.CommandText = "SELECT * from comunero WHERE nombreCompleto LIKE '%" + busqueda + "%' LIMIT 0,100";
                }

                dataGridView1.Rows.Clear();
                try
                {
                    dbConn.Open();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro" + erro);
                    this.Close();
                }
                MySqlDataReader reader = cmd.ExecuteReader();
                lista = new List<Comunero>();
                while (reader.Read())
                {
                    Comunero c = new Comunero();
                    c.setIdPersona(Int32.Parse(reader["idPersona"].ToString()));
                    c.setIdBarrio(Int32.Parse(reader["idBarrio"].ToString()));
                    c.setNombreCompleto(reader["nombreCompleto"].ToString());
                    c.SetCedulaDeIdentidad(reader["cedulaDeIdentidad"].ToString());
                    lista.Add(c);
                    String[] row = new String[] { c.GetCedulaDeIdentidad(), c.getNombreCompleto() };
                    dataGridView1.Rows.Add(row);

                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado el modo de búsqueda");
            }
            

        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalirDelSistema_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Está seguro que desea salir del sistema?", "Cerrando sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new IUNuevoComunero().Show();
        }

        private void btnVerDatosDelComunero_Click(object sender, EventArgs e)
        {
            new IUDatosDeComunero().Show();
        }
    }
}
