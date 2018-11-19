using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_SIGSJC.Controles
{
    class ControlFinanciero
    {
        SqlConnection conn = ConexionBD.conectar();
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable tabla = new DataTable();

        public void registrarPagoporCed(String cedula, String razon)
        {
            conn.Open();
            cmd = new SqlCommand("sp_pagarPorCed", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cedula", SqlDbType.VarChar).Value = cedula.Trim();
            cmd.Parameters.AddWithValue("@razon", SqlDbType.Date).Value = razon.Trim();
            //cmd.Parameters.AddWithValue("@nicho", SqlDbType.Int).Value = nicho.Text.Trim();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Estado de deuda modificado a: pagada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            conn.Close();
        }

        public void registrarPagoporNom(String nombre, String razon)
        {
            conn.Open();
            cmd = new SqlCommand("sp_pagarPorNom", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", SqlDbType.VarChar).Value = nombre.Trim();
            cmd.Parameters.AddWithValue("@razon", SqlDbType.Date).Value = razon.Trim();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Estado de deuda modificado a: pagada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
        }

        public void anularporNom(String nombre, String razon)
        {
            conn.Open();
            cmd = new SqlCommand("sp_anularPorNom", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nombre", SqlDbType.VarChar).Value = nombre.Trim();
            cmd.Parameters.AddWithValue("@razon", SqlDbType.Date).Value = razon.Trim();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Deuda anulada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conn.Close();
        }

        public void anularporCed(String cedula, String razon)
        {
            conn.Open();
            cmd = new SqlCommand("sp_anularPorCed", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@cedula", SqlDbType.VarChar).Value = cedula.Trim();
            cmd.Parameters.AddWithValue("@razon", SqlDbType.Date).Value = razon.Trim();
            //cmd.Parameters.AddWithValue("@nicho", SqlDbType.Int).Value = nicho.Text.Trim();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Deuda anulada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //MessageBox.Show("Registro Exitoso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
        }

        public DataTable buscarDeudoresPorNombre(String nombre, String evento)
        {
            conn.Open();
            var tabla = new DataTable();
            if (evento.Equals("Asamblea"))
            {
                try
                {
                    adpt = new SqlDataAdapter("sp_mostrarDeudoresAsambleaporNombre", conn);
                    adpt.SelectCommand.Parameters.AddWithValue("@nombre", nombre.Trim().ToUpper());
                    adpt.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adpt.Fill(tabla);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex + "");
                }
            }
            else if (evento.Equals("Empad"))
            {
                try
                {
                    adpt = new SqlDataAdapter("sp_mostrarDeudoresEmpadronamientoporNombre", conn);
                    adpt.SelectCommand.Parameters.AddWithValue("@nombre", nombre.Trim().ToUpper());
                    adpt.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adpt.Fill(tabla);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("" + ex + "");
                }
            }
            else
            {
                try
                {
                    adpt = new SqlDataAdapter("sp_mostrarDeudoresCementerioporNombre", conn);
                    adpt.SelectCommand.Parameters.AddWithValue("@nombre", nombre.Trim().ToUpper());
                    adpt.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adpt.Fill(tabla);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex + "");
                }
            }
            conn.Close();
            return tabla;
        }

        public DataTable buscarDeudorPorCedula(String cedula, String evento)
        {
            conn.Open();
            var tabla = new DataTable();
            if (evento.Equals("Asamblea"))
            {
                try
                {
                    adpt = new SqlDataAdapter("sp_mostrarDeudoresAsambleaporCedula", conn);
                    adpt.SelectCommand.Parameters.AddWithValue("@cedula", cedula.Trim().ToUpper());
                    adpt.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adpt.Fill(tabla);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex + "");
                }
            }
            else if (evento.Equals("Empad"))
            {
                try
                {
                    adpt = new SqlDataAdapter("sp_mostrarDeudoresEmpadronamientoporCedula", conn);
                    adpt.SelectCommand.Parameters.AddWithValue("@cedula", cedula.Trim().ToUpper());
                    adpt.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adpt.Fill(tabla);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("" + ex + "");
                }
            }
            else
            {
                try
                {
                    adpt = new SqlDataAdapter("sp_mostrarDeudoresCementerioporCedula", conn);
                    adpt.SelectCommand.Parameters.AddWithValue("@cedula", cedula.Trim().ToUpper());
                    adpt.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adpt.Fill(tabla);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex + "");
                }
            }
            conn.Close();
            return tabla;
        }

        public String buscarComuneroCedula(String cedula)
        {
            String nombre = "";
            conn.Open();

            try
            {
                adpt = new SqlDataAdapter("sp_mostrarComuneroCedula", conn);
                adpt.SelectCommand.Parameters.AddWithValue("@cedula", cedula.Trim().ToUpper());
                adpt.SelectCommand.CommandType = CommandType.StoredProcedure;
                //adpt.Fill(nombre);
                nombre = adpt.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex + "");
            }
            conn.Close();


            return nombre;
        }





        //like
        public void buscarDeudorLikeNombre(DataGridView dgv, String nombre)
        {
            try
            {
                var tabla = this.buscarDeudoresPorNombre(nombre, "Asamblea");
                this.ListarGrid(dgv, tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex + "");
                throw;
            }
        }

        public void buscarDeudorEmpadLikeNombre(DataGridView dgv, String nombre)
        {
            try
            {
                var tabla = this.buscarDeudoresPorNombre(nombre, "Empad");
                this.ListarGrid(dgv, tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex + "");
                throw;
            }
        }

        public void buscarDeudorMinLikeNombre(DataGridView dgv, String nombre)
        {
            try
            {
                var tabla = this.buscarDeudoresPorNombre(nombre, "Cementerio");
                this.ListarGrid(dgv, tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex + "");
                throw;
            }
        }

        public void buscarDeudorLikeCed(DataGridView dgv, String cedula)
        {
            try
            {
                var tabla = this.buscarDeudorPorCedula(cedula, "Asamblea");
                this.ListarGrid(dgv, tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex + "");
                throw;
            }

        }

        public void buscarDeudorEmpadLikeCed(DataGridView dgv, TextBox cedulaid)
        {
            string cedula = cedulaid.Text;
            MessageBox.Show(cedula);

            try
            {
                var tabla = this.buscarDeudorPorCedula(cedula,"Empad");
                this.ListarGrid(dgv, tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex + "");
                throw;
            }

        }
        public void buscarDeudorMinLikeCed(DataGridView dgv, String cedula)
        {
            try
            {
                var tabla = this.buscarDeudorPorCedula(cedula, "Min");
                this.ListarGrid(dgv, tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex + "");
                throw;
            }

        }

        public void buscarComuneroDeudor(DataGridView dgv, string buscar, string tipo)
        {
            dgv.Rows.Clear();
            if (tipo.Equals("cedula"))
            {
                var tabla = this.buscarDeudorPorCedula(buscar, "Min");
                var tabla2 = this.buscarDeudorPorCedula(buscar, "Empad");
                var tabla3 = this.buscarDeudorPorCedula(buscar, "Asamblea");
                this.ListarGridCompleto(dgv, tabla, tabla2, tabla3);

            }
            else if(tipo.Equals("nombre"))
            {
                var tabla = this.buscarDeudoresPorNombre(buscar, "Cementerio");
                var tabla2 = this.buscarDeudoresPorNombre(buscar, "Empad");
                var tabla3 = this.buscarDeudoresPorNombre(buscar, "Asamblea");
                this.ListarGridCompleto(dgv, tabla, tabla2, tabla3);
            }
        }

        public void vaciar(DataGridView dgv)
        {
            dgv.Rows.Clear();
        }

        //_rid
        public void ListarGrid(DataGridView dgv, DataTable tabla)
        {

            try
            {

                int numero_filas = tabla.Rows.Count;
                if (numero_filas > 0)
                {
                    dgv.Rows.Clear();

                    for (int i = 0; i < numero_filas; i++)
                    {
                        string columna1 = tabla.Rows[i][1].ToString();
                        string columna2 = tabla.Rows[i][2].ToString();
                        string columna3 = tabla.Rows[i][3].ToString();
                        string columna4 = tabla.Rows[i][4].ToString();
                        string columna5 = tabla.Rows[i][5].ToString();
                        string columna6 = tabla.Rows[i][6].ToString();
                       // DateTime columna5i = DateTime.Parse(tabla.Rows[i][5].ToString());
                        int columna7 = int.Parse(tabla.Rows[i][0].ToString());

                        dgv.Rows.Add(
                            //columna1, columna2, columna3, columna4, columna5i.ToString("yyyy-MM-dd")
                            columna1, columna2, columna3, columna4, columna5, columna6

                            );



                    }
                }

                this.tabla.Rows.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex + "");
                //throw;
            }


        }



        public void ListarGridCompleto(DataGridView dgv, DataTable tabla, DataTable tabla2, DataTable tabla3)
        {

            try
            {

                int numero_filas1 = tabla.Rows.Count;
                int numero_filas2 = tabla2.Rows.Count;
                int numero_filas3 = tabla3.Rows.Count;

                if (numero_filas1 > 0)
                {
                    //dgv.Rows.Clear();

                    for (int i = 0; i < numero_filas1; i++)
                    {
                        string columna1 = tabla.Rows[i][1].ToString();
                        string columna2 = tabla.Rows[i][2].ToString();
                        string columna3 = tabla.Rows[i][3].ToString();
                        string columna4 = tabla.Rows[i][4].ToString();
                        string columna5 = tabla.Rows[i][5].ToString();
                        string columna6 = tabla.Rows[i][6].ToString();
                        string columna7 = tabla.Rows[i][7].ToString();
                        // DateTime columna5i = DateTime.Parse(tabla.Rows[i][5].ToString());
                        int columna8 = int.Parse(tabla.Rows[i][0].ToString());

                        dgv.Rows.Add(
                            //columna1, columna2, columna3, columna4, columna5i.ToString("yyyy-MM-dd")
                            columna1, columna2, columna3, columna4, columna5, columna6, columna7

                            );



                    }
                }

                if(numero_filas2 > 0)
                {
                    for (int i = 0; i < (numero_filas2); i++)
                    {
                        string columna1 = tabla2.Rows[i][1].ToString();
                        string columna2 = tabla2.Rows[i][2].ToString();
                        string columna3 = tabla2.Rows[i][3].ToString();
                        string columna4 = tabla2.Rows[i][4].ToString();
                        string columna5 = tabla2.Rows[i][5].ToString();
                        string columna6 = tabla2.Rows[i][6].ToString();
                        string columna7 = tabla2.Rows[i][7].ToString();
                        // DateTime columna5i = DateTime.Parse(tabla.Rows[i][5].ToString());
                        int columna8 = int.Parse(tabla2.Rows[i][0].ToString());

                        dgv.Rows.Add(
                            //columna1, columna2, columna3, columna4, columna5i.ToString("yyyy-MM-dd")
                            columna1, columna2, columna3, columna4, columna5, columna6, columna7

                            );



                    }
                }


                if (numero_filas3 > 0)
                {
                    for (int i = 0; i < (numero_filas3); i++)
                    {
                        string columna1 = tabla3.Rows[i][1].ToString();
                        string columna2 = tabla3.Rows[i][2].ToString();
                        string columna3 = tabla3.Rows[i][3].ToString();
                        string columna4 = tabla3.Rows[i][4].ToString();
                        string columna5 = tabla3.Rows[i][5].ToString();
                        string columna6 = tabla3.Rows[i][6].ToString();
                        string columna7 = tabla3.Rows[i][7].ToString();
                        // DateTime columna5i = DateTime.Parse(tabla.Rows[i][5].ToString());
                        int columna8 = int.Parse(tabla3.Rows[i][0].ToString());

                        dgv.Rows.Add(
                            //columna1, columna2, columna3, columna4, columna5i.ToString("yyyy-MM-dd")
                            columna1, columna2, columna3, columna4, columna5, columna6, columna7

                            );



                    }
                }

                this.tabla.Rows.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex + "");
                //throw;
            }


        }


    }

}
