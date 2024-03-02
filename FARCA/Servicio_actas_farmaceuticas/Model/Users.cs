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
    internal class Users
    {
        public int userId {  get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public Users() { }

        // Read operation by ID
        public int login()
        {
            DbContext dbContext = new DbContext();  
            using (SqlConnection connection = dbContext.GetConnection())
            {
                DataTable dataTable = new DataTable();
                string query = "SELECT idUsuario FROM Usuarios WHERE nombreUsuario = @username and contrasena = @password";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@username", username);
                adapter.SelectCommand.Parameters.AddWithValue("@password", password);

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                        return 1;
                    else
                        return 0; // No record found with the given ID
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return 404;
                }
            }
        }

    }
}
