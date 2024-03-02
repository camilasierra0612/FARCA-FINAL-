using Servicio_actas_farmaceuticas.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicio_actas_farmaceuticas.Model
{
    internal class pqrs
    {
        public pqrs() { }

        public string tipoSolicitud { set; get; }
        public DateTime fecha { set; get; }
        public string observacion { set; get; }

        public int guardarPqrs()
        {
            DbContext dbContext = new DbContext();

            using (SqlConnection connection = dbContext.GetConnection())
            {
                string query = "INSERT INTO pqrs (tipoSolicitud,fecha,observacion)" +
                    "VALUES (@tipoSolicitud, @fecha, @observacion)" +
                    "SELECT CAST(scope_identity() AS int)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@tipoSolicitud", tipoSolicitud);
                command.Parameters.AddWithValue("@fecha", fecha);
                command.Parameters.AddWithValue("@observacion", observacion);

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
    }
}
