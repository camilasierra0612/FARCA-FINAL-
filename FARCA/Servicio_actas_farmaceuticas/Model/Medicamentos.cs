using Servicio_actas_farmaceuticas.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Servicio_actas_farmaceuticas.Model
{
    internal class Medicamentos
    {
        public Medicamentos() { }

        public string nombre { set; get; }
        public string empaque { set; get; }
        public int cantidad { set; get; }
        public string presentacion { set; get; }
        public DateTime fechaVencimiento { set; get; }
        public string viaAdministracion { set; get; }
        public string almacenamiento { set; get; }
        public string especificaciones { set; get; }
        public int precio { set; get; }

        public int guardarMedicamento()
        {
            DbContext dbContext = new DbContext();

            using (SqlConnection connection = dbContext.GetConnection())
            {
                string query = "INSERT INTO Medicamentos (nombre,empaque,cantidad," +
                    "presentacion, fechaVencimiento, viaAdministracion, almacenamiento," +
                    "especificaciones, precio) VALUES (@nombre, @empaque,@cantidad, @presentacion," +
                    "@fechaVencimiento, @viaAdministracion, @almacenamiento," +
                    "@especificaciones, @precio)" +
                    "SELECT CAST(scope_identity() AS int)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@empaque", empaque);
                command.Parameters.AddWithValue("@cantidad", cantidad);
                command.Parameters.AddWithValue("@presentacion", presentacion);
                command.Parameters.AddWithValue("@fechaVencimiento", fechaVencimiento);
                command.Parameters.AddWithValue("@viaAdministracion", viaAdministracion);
                command.Parameters.AddWithValue("@almacenamiento", almacenamiento);
                command.Parameters.AddWithValue("@especificaciones", especificaciones);
                command.Parameters.AddWithValue("@precio", precio);

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

        public string informacionMedicamento(int idMedicamento)
        {
            DbContext dbContext = new DbContext();
            using (SqlConnection connection = dbContext.GetConnection())
            {
                DataTable dataTable = new DataTable();
                string query = "select Nombre+' - '+ Presentacion+' - $ '+ " +
               "FORMAT(CAST(Precio AS bigint), '#,##0') [InfoMedicamento] " +
               "from Medicamentos where idMedicamento = @idMedicamento";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@idMedicamento", idMedicamento);

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

        public DataTable alertaVencimiento()
        {
            DbContext dbContext = new DbContext();
            using (SqlConnection connection = dbContext.GetConnection())
            {
                DataTable dataTable = new DataTable();
                string query = "select CONCAT(idMedicamento,' - ',Nombre ,' - ',FechaVencimiento) [Medicamentos] from Medicamentos where FechaVencimiento < DATEADD(MONTH,5,GETDATE())\r\nUNION\r\nselect CONCAT(idMedicamento,' - ',Nombre,' - ', FechaVencimiento) from Medicamentos where FechaVencimiento < DATEADD(MONTH,2,GETDATE())";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                        return dataTable;
                    else
                        return null; // No record found with the given ID
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return null;
                }
            }
        }

    }
}
