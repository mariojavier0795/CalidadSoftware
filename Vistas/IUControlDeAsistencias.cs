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
    public partial class IUControlDeAsistencias : Form
    {
        public IUControlDeAsistencias()
        {
            InitializeComponent();
            button1.Enabled = true;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            dataGridView1.Enabled = false;
            comboBox1.Enabled = false;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IGestionAsistencia_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            IURegistroDeAsistencia ra = new IURegistroDeAsistencia();
            ra.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
            dataGridView1.Enabled = true;
            comboBox1.Enabled = true;


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
             new IURegistroDeAsistencia().Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalirDelSistema_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir del sistema?", "Cerrando sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
