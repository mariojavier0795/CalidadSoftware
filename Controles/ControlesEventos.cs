using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using PROYECTO_SIGSJC.Properties;
using System.Data;

namespace PROYECTO_SIGSJC.Controles
{
    class ControlesEventos
    {
        SqlConnection conn = ConexionBD.conectar();
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable tabla = new DataTable();

        public void ingresarNuevoEmpadronamiento(TextBox txtnombre, DateTimePicker dtfecha, TextBox txtdescrip, TextBox txtvpago, TextBox txtvpagom)
        {

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("AddEmpadronamiento", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombredeempadronamiento", SqlDbType.VarChar).Value = txtnombre.Text.Trim();
                cmd.Parameters.AddWithValue("@fechaempadronamiento", SqlDbType.Date).Value = dtfecha.Value.ToString("dd-MM-yyyy");
                cmd.Parameters.AddWithValue("@descripcion", SqlDbType.VarChar).Value = txtdescrip.Text.Trim();
                cmd.Parameters.AddWithValue("@valorDePago", SqlDbType.Real).Value = txtvpago.Text.Trim();
                cmd.Parameters.AddWithValue("@valorDePagoConMulta", SqlDbType.Real).Value = txtvpagom.Text.Trim();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Exitoso");

            }
            catch (Exception)
            {

                throw;
            }

            conn.Close();
        }

        public void ingresarNuevaMinga(DateTimePicker dtfecha, TextBox txtdescrip, TextBox txtvpago, TextBox txtvpagom)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("AddMinga", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@aniominga", SqlDbType.Int).Value = dtfecha.Value.ToString("yyyy");
                cmd.Parameters.AddWithValue("@descripcion", SqlDbType.VarChar).Value = txtdescrip.Text.Trim();
                cmd.Parameters.AddWithValue("@multaporfalta", SqlDbType.Real).Value = txtvpago.Text.Trim();
                cmd.Parameters.AddWithValue("@rubroanual", SqlDbType.Real).Value = txtvpagom.Text.Trim();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Exitoso");
            }
            catch (Exception)
            {

                throw;
            }

            conn.Close();
        }






        /*
        public DataTable listarAsambleas()
        {
            
            var tabla = new DataTable();

            try
            {
                adpt = new SqlDataAdapter("SP_listarAsamblea", conn);
                adpt.SelectCommand.CommandType = CommandType.StoredProcedure;
                adpt.Fill(tabla);
                
            }
            catch (Exception)
            {

                throw;
            }
            conn.Close();
            return tabla;
        }

       */

        ///METODOS PARA ASAMBLEA
        ///
        public void ingresarNuevaAsamblea(TextBox txtnombre, DateTimePicker dtfecha, TextBox txtdescrip, TextBox txtvpago, TextBox txtvpagom)
        {


            try
            {
                conn.Open();
                cmd = new SqlCommand("asamblea_Insertar", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombreAsamblea", SqlDbType.VarChar).Value = txtnombre.Text.Trim();
                cmd.Parameters.AddWithValue("@fechaAsamblea", SqlDbType.Date).Value = dtfecha.Value.ToString("dd-MM-yyyy");
                //cmd.Parameters.AddWithValue("@numeroAsistentes", SqlDbType.Int).Value = txtasis.Text.Trim();
                cmd.Parameters.AddWithValue("@descripcion", SqlDbType.VarChar).Value = txtdescrip.Text.Trim();
                cmd.Parameters.AddWithValue("@valorDePago", SqlDbType.Real).Value = txtvpago.Text.Trim();
                cmd.Parameters.AddWithValue("@valorDePagoConMulta", SqlDbType.Real).Value = txtvpagom.Text.Trim();
                //cmd.Parameters.AddWithValue("@nombreAsamblea", SqlDbType.VarChar).Value = txtnombre.Text.Trim();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Exitoso");

            }
            catch (Exception)
            {

                throw;
            }
            conn.Close();
        }



        public void actualizarAsamblea(string id, TextBox txtnombre, DateTimePicker dtfecha, TextBox txtdescrip)
        {


            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_ActualizarAsamblea", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@nombreAsamblea", SqlDbType.VarChar).Value = txtnombre.Text.Trim();
                cmd.Parameters.AddWithValue("@fechaAsamblea", SqlDbType.Date).Value = dtfecha.Value.ToString("dd-MM-yyyy");
                //cmd.Parameters.AddWithValue("@numeroAsistentes", SqlDbType.Int).Value = txtasis.Text.Trim();
                cmd.Parameters.AddWithValue("@descripcion", SqlDbType.VarChar).Value = txtdescrip.Text.Trim();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Evento Modificado con éxito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex + "");
                //throw;
            }
            conn.Close();
        }

        public DataTable buscarAsambleaPorNombre(String nombre)
        {
            conn.Open();
            var tabla = new DataTable();

            try
            {
                adpt = new SqlDataAdapter("SP_BuscarAsambleaPorNombre", conn);
                adpt.SelectCommand.Parameters.AddWithValue("@nombredeasamblea", nombre.Trim().ToUpper());
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

        public DataTable buscarAsambleaFecha(String fecha)
        {
            conn.Open();
            var tabla = new DataTable();

            try
            {
                adpt = new SqlDataAdapter("SP_BuscarAsambleaPorFecha", conn);
                adpt.SelectCommand.Parameters.AddWithValue("@fechadeasamblea", fecha.Trim().ToUpper());
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

        public DataTable buscarAsambleaPorID(int id)
        {
            conn.Open();
            var tabla = new DataTable();

            try
            {
                adpt = new SqlDataAdapter("SP_buscarAsambleasPorId", conn);
                adpt.SelectCommand.Parameters.AddWithValue("@ID", id);
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



        public void buscarAsambleaLike(DataGridView dgv, String nombre)
        {
            try
            {
                var tabla = this.buscarAsambleaPorNombre(nombre);
                this.ListarGrid(dgv, tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex + "");
                throw;
            }

        }

        public void buscarAsambleaLikeFecha(DataGridView dgv, String fecha)
        {
            try
            {
                var tabla = this.buscarAsambleaFecha(fecha);
                this.ListarGrid(dgv, tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex + "");
                throw;
            }

        }


        public void ListarAsambleas(DataGridView dgv)
        {
            try
            {
                DataTable tabla = this.listar("SP_listarAsamblea");
                this.ListarGrid(dgv, tabla);


            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex + "");
                //throw;
            }


        }



        ///METODOS PARA EMPADRONAMIENTO


        /*public DataTable listarEmpadronamiento()
        {

            var tabla = new DataTable();

            try
            {
                adpt = new SqlDataAdapter("SP_listarEmpadronamiento", conn);
                adpt.SelectCommand.CommandType = CommandType.StoredProcedure;
                adpt.Fill(tabla);

            }
            catch (Exception)
            {

                throw;
            }
            conn.Close();
            return tabla;
        }
        */

        public void listarEmpadronamientos(DataGridView dgv)
        {
            try
            {
                DataTable tabla = this.listar("SP_listarEmpadronamiento");
                this.ListarGrid(dgv, tabla);


            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex + "");
                //throw;
            }


        }

        public DataTable buscarEmpadronamientoPorNombre(String nombre)
        {
            conn.Open();
            var tabla = new DataTable();

            try
            {
                adpt = new SqlDataAdapter("SP_BuscarEmpadronamiento", conn);
                adpt.SelectCommand.Parameters.AddWithValue("@nombreDeEmpadronamiento", nombre.Trim().ToUpper());
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

        public void buscarEmpadronamientoLike(DataGridView dgv, String nombre)
        {
            try
            {
                var tabla = this.buscarEmpadronamientoPorNombre(nombre);
                this.ListarGrid(dgv, tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex + "");
                throw;
            }

        }  // LLama a los metodos buscarEmpadronamientoPorNombre y ListraGrid(Otros MEtodos)

        public void buscarEmpadronamientoLikeFecha(DataGridView dgv, String fecha)
        {
            try
            {
                var tabla = this.buscarEmpadronamientoFecha(fecha);
                this.ListarGrid(dgv, tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex + "");
                throw;
            }

        }// LLama a los metodos buscarEmpadronamientoPorFecha y ListraGrid(Otros MEtodos)

        public DataTable buscarEmpadronamientoFecha(String fecha)
        {
            conn.Open();
            var tabla = new DataTable();

            try
            {
                adpt = new SqlDataAdapter("SP_BuscarEmpadronamientoFecha", conn);
                adpt.SelectCommand.Parameters.AddWithValue("@fechadeEmpadronamiento", fecha.Trim().ToUpper());
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

        public void actualizarEmpadronamiento(string id, TextBox txtnombre, DateTimePicker dtfecha, TextBox txtdescrip)
        {
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_ActualizarEmpadronamiento", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@nombredeempadronamiento", SqlDbType.VarChar).Value = txtnombre.Text.Trim();
                cmd.Parameters.AddWithValue("@fechaempadronamiento", SqlDbType.Date).Value = dtfecha.Value.ToString("dd-MM-yyyy");
                //cmd.Parameters.AddWithValue("@numeroAsistentes", SqlDbType.Int).Value = txtasis.Text.Trim();
                cmd.Parameters.AddWithValue("@descripcion", SqlDbType.VarChar).Value = txtdescrip.Text.Trim();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Evento Modificado con éxito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex + "");
                //throw;
            }
            conn.Close();
        }


        ///METODO PARA MINGA

        public void listarMingas(DataGridView dgv)
        {
            try
            {
                DataTable tabla = this.listar("SP_listarMinga");
                this.ListarGrid(dgv, tabla);


            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex + "");
                //throw;
            }


        }

        public DataTable buscarMingaPorFecha(String nombre)
        {

            var tabla = new DataTable();

            try
            {
                adpt = new SqlDataAdapter("SP_BuscarMinga", conn);
                adpt.SelectCommand.Parameters.AddWithValue("@fechaMinga", nombre.Trim().ToUpper());
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

        public void buscarMingaLike(DataGridView dgv, String nombre)
        {
            try
            {
                var tabla = this.buscarMingaPorFecha(nombre);
                this.ListarGridMinga(dgv, tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex + "");
                throw;
            }

        }

        public void actualizarMinga(string id, TextBox txtnombre, DateTimePicker dtfecha, TextBox txtdescrip)
        {
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_ActualizarMinga", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", id);
                //cmd.Parameters.AddWithValue("@nombredeempadronamiento", SqlDbType.VarChar).Value = txtnombre.Text.Trim();
                cmd.Parameters.AddWithValue("@fechaminga", SqlDbType.Date).Value = dtfecha.Value.ToString("dd-MM-yyyy");
                //cmd.Parameters.AddWithValue("@numeroAsistentes", SqlDbType.Int).Value = txtasis.Text.Trim();
                cmd.Parameters.AddWithValue("@razon", SqlDbType.VarChar).Value = txtdescrip.Text.Trim();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Evento Modificado con éxito","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex + "");
                //throw;
            }
            conn.Close();
        }


        //METODOS GENERALES

        public DataTable listar(String storeProcedure)
        {


            try
            {
                using (var adapter = new SqlDataAdapter(storeProcedure, conn))
                {
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex + "");

                //return tabla;
            }



            return tabla;
        }


        public void vaciar(DataGridView dgv)
        {
            dgv.Rows.Clear();


        }
        public void ListarGrid(DataGridView dgv, DataTable tabla)
        {

            try
            {

                int numero_filas = tabla.Rows.Count;
                if (numero_filas > 0 )
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
                            columna1, columna2, columna3, columna4, columna5
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

        public void ListarGridMinga(DataGridView dgv, DataTable tabla)
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
                            "", columna1, columna2, columna3, columna5
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

            this.tabla.Rows.Clear();



        }
    }
}

