using Servicio_actas_farmaceuticas.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicio_actas_farmaceuticas.Model
{
    internal class Clientes
    {
        public Clientes() { }

        public string nombres { set; get; }
        public string apellidos { set; get; }
        public string tipoDocumento { set; get; }
        public string numeroDocumento { set; get; }
        public string celular { set; get; }
        public string departamento { set; get; }
        public string ciudad { set; get; }
        public string direccion { set; get; }

        public int guardarCliente()
        {
            DbContext dbContext = new DbContext();

            using (SqlConnection connection = dbContext.GetConnection())
            {
                string query = "INSERT INTO Clientes (nombres,apellidos,tipoDocumento," +
                    "numeroDocumento, celular, departamento, ciudad," +
                    "direccion) VALUES (@nombres, @apellidos, @tipoDocumento," +
                    "@numeroDocumento, @celular, @departamento, @ciudad," +
                    "@direccion)" +
                    "SELECT CAST(scope_identity() AS int)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombres", nombres);
                command.Parameters.AddWithValue("@apellidos", apellidos);
                command.Parameters.AddWithValue("@tipoDocumento", tipoDocumento);
                command.Parameters.AddWithValue("@numeroDocumento", numeroDocumento);
                command.Parameters.AddWithValue("@celular", celular);
                command.Parameters.AddWithValue("@departamento", departamento);
                command.Parameters.AddWithValue("@ciudad", ciudad);
                command.Parameters.AddWithValue("@direccion", direccion);

                try
                {
                    connection.Open();
                    int id = Convert.ToInt32(command.ExecuteScalar());
                    return id;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return 0;
                }
            }
        }

        public string informacionCliente(string numeroDocumento)
        {
            DbContext dbContext = new DbContext();
            using (SqlConnection connection = dbContext.GetConnection())
            {
                DataTable dataTable = new DataTable();
                string query = "select Nombres+' '+ Apellidos+' -'+ " +
                    "CONVERT(VARCHAR,idCLiente) [InfoCliente] " +
                    "from Clientes where NumeroDocumento = @numeroDocumento";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@numeroDocumento", numeroDocumento);

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                        return dataTable.Rows[0][0].ToString();
                    else
                        return "No se ha encontrado información. Verifique el código"; // No record found with the given ID
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return "404";
                }
            }
        }
    }
}
