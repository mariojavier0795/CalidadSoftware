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
    class ControlCementerio
    {
        SqlConnection conn = ConexionBD.conectar();
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable tabla = new DataTable();


        /* private void mostrarComunerosFallecidos()
       {
           SqlDataAdapter da = new SQLDataAdapter("sp_mostrarFallecidos",);
           da.SelectCommand.CommandType = CommandType.StoredProcedure;
           DataTable dt = new DataTable();
           da.Fill(dt);
           dataGrid.DataSource = dt;
       }
       */
       public void nuevoFallecido(TextBox cedula, DateTimePicker fecha_fallecimiento, TextBox nicho )
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_InsertarFallecido", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nicho", SqlDbType.Int).Value = nicho.Text.Trim();
                cmd.Parameters.AddWithValue("@cedula", SqlDbType.VarChar).Value = cedula.Text.Trim();
                cmd.Parameters.AddWithValue("@fechaFall", SqlDbType.Date).Value = fecha_fallecimiento.Value.ToString("dd-MM-yyyy");
                cmd.ExecuteNonQuery();

                MessageBox.Show("Registro Exitoso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                throw;
            }
            conn.Close();
        }
        //Buscar por parámetro
        public DataTable buscarFallecidoPorNombre(String nombre)
        {
            conn.Open();
            var tabla = new DataTable();

            try
            {
                adpt = new SqlDataAdapter("sp_mostrarFallecidosporNombre", conn);
                adpt.SelectCommand.Parameters.AddWithValue("@nombre", nombre.Trim().ToUpper());
                adpt.SelectCommand.CommandType = CommandType.StoredProcedure;
                adpt.Fill(tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex + "");
            }
            conn.Close();
            return tabla;
        }

        public DataTable buscarFallecidoPorCedula(String cedula)
        {
            conn.Open();
            var tabla = new DataTable();

            try
            {
                adpt = new SqlDataAdapter("sp_mostrarFallecidosporCedula", conn);
                adpt.SelectCommand.Parameters.AddWithValue("@cedula", cedula.Trim().ToUpper());
                adpt.SelectCommand.CommandType = CommandType.StoredProcedure;
                adpt.Fill(tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex + "");
            }
            conn.Close();
            return tabla;
        }
        public String buscarSiComuneroRegistradoCedula(String cedula)
        {
            String existe = "";
            conn.Open();

            try
            {
                SqlDataReader dr = null;
                cmd = conn.CreateCommand();
                cmd.CommandText = "sp_mostrarFallecidosporCedula";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cedula", cedula.Trim().ToUpper());
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    existe = "si";
                }
                else
                {
                    existe = "no";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex + "");
            }
            conn.Close();


            return existe;
        }

        public String buscarComuneroCedula(String cedula)
        {
            String nombre = "";
            conn.Open();

            try
            {
                SqlDataReader dr = null;
                cmd = conn.CreateCommand();
                cmd.CommandText = "sp_mostrarComuneroCedula";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cedula", cedula.Trim().ToUpper());
                dr = cmd.ExecuteReader();
                
                if (dr.Read())
                {
                    nombre = dr.GetString(2);
                    //MessageBox.Show(nombre);
                }
                else
                {
                    MessageBox.Show("No existe comunero con número de cédula ingresado");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex + "");
            }
            conn.Close();


            return nombre;
        }

        public int buscarNicho(int nicho)
        {
            int resp=2;     //2 error
            //1 SI existe       0 No existe 
            conn.Open();

            try
            {
                SqlDataReader dr = null;
                cmd = conn.CreateCommand();
                cmd.CommandText = "sp_buscarNicho";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nicho", nicho);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    resp = 1;
                    MessageBox.Show(resp.ToString());
                }
                else
                {
                    //MessageBox.Show("No existe comunero con número de cédula ingresado");
                    resp = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex + "");
            }
            conn.Close();

            
            return resp;
        }

        public void moverFosaComun(int id, int nicho)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_moverFallecido", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@persona", SqlDbType.Int).Value = id;
                cmd.Parameters.AddWithValue("@nicho", SqlDbType.Int).Value = nicho;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Comunero cambiado de ubicación a: fosa común", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                throw;
            }
            conn.Close();
        }

        //LIKE
        public void buscarFallecidoLikeNombre(DataGridView dgv, String nombre)
        {
            try
            {
                var tabla = this.buscarFallecidoPorNombre(nombre);
                this.ListarGrid(dgv, tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex + "");
                throw;
            }

        }

        public void buscarFallecidoLikeCed(DataGridView dgv, String cedula)
        {
            try
            {
                var tabla = this.buscarFallecidoPorCedula(cedula);
                this.ListarGrid(dgv, tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex + "");
                throw;
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
                        int columna5 = int.Parse(tabla.Rows[i][0].ToString());
                        dgv.Rows.Add(
                            columna1, columna2, columna3,columna4, columna5
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





