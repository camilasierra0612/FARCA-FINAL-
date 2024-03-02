using Servicio_actas_farmaceuticas.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicio_actas_farmaceuticas.Model
{
    internal class Compras
    {
        public Compras() { }

        public int medicamentoFk { get; set; }
        public int clienteFk { get; set; }
        public int cantidad { get; set; }
        public DateTime fechaCompra { get; set; }

        public int precio { get; set; }
        public int total { get; set; }

        public int guardarCompra()
        {
            if (ValidarStock() == 1)
            {
                DbContext dbContext = new DbContext();

                using (SqlConnection connection = dbContext.GetConnection())
                {
                    string query = "INSERT INTO Compras (medicamentoFk,clienteFk,cantidad," +
                        "fechaCompra, total, precio ) VALUES (@medicamentoFk, @clienteFk, @cantidad," +
                        "@fechaCompra, @total, @precio)" +
                        "SELECT CAST(scope_identity() AS int)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@medicamentoFk", medicamentoFk);
                    command.Parameters.AddWithValue("@clienteFk", clienteFk);
                    command.Parameters.AddWithValue("@cantidad", cantidad);
                    command.Parameters.AddWithValue("@fechaCompra", fechaCompra);
                    command.Parameters.AddWithValue("@total", total);
                    command.Parameters.AddWithValue("@precio", precio);

                    try
                    {
                        connection.Open();
                        int id = Convert.ToInt32(command.ExecuteScalar());
                        bool resultUpdate = restarStock();
                        return id;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        return 0;
                    }
                }
            }
            return -2;
        }

        private int ValidarStock()
        {
            DbContext dbContext = new DbContext();
            using (SqlConnection connection = dbContext.GetConnection())
            {
                DataTable dataTable = new DataTable();
                string query = "select cantidad - @cantidad [cantidad] from Medicamentos where idMedicamento = @medicamentoFk";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@cantidad", cantidad);
                adapter.SelectCommand.Parameters.AddWithValue("@medicamentoFk", medicamentoFk);

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                        return (int.Parse(dataTable.Rows[0][0].ToString()) < 0) ? -2 : 1;
                    else
                        return -2; // No record found with the given ID
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return -3;
                }
            }

        }

        private bool restarStock()
        {
            DbContext dbContext = new DbContext();
            using (SqlConnection connection = dbContext.GetConnection())
            {
                string query = "UPDATE Medicamentos SET cantidad = cantidad - @cantidad " +
                    "WHERE idMedicamento = @medicamentoFk";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@medicamentoFk", medicamentoFk);
                command.Parameters.AddWithValue("@cantidad", cantidad);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
