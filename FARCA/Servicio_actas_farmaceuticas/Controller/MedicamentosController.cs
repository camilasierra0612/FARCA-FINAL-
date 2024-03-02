using Servicio_actas_farmaceuticas.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio_actas_farmaceuticas.Controller
{
    internal class MedicamentosController
    {
        public MedicamentosController() { }

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
            Medicamentos medicamento = new Medicamentos();
            medicamento.nombre = nombre;
            medicamento.empaque = empaque;
            medicamento.cantidad = cantidad;
            medicamento.presentacion = presentacion;
            medicamento.fechaVencimiento = fechaVencimiento;
            medicamento.viaAdministracion = viaAdministracion;
            medicamento.almacenamiento  = almacenamiento;
            medicamento.especificaciones = especificaciones;
            medicamento.precio = precio;

            if (validarDatos(medicamento) == 1)
            {
                int id = medicamento.guardarMedicamento();
                if (id > 0)
                {
                    return id;
                }
                else
                {
                    return 0;
                }
            }

            return -1;
        }

        private int validarDatos(Medicamentos m)
        {
            if(m.nombre.Length<1 || m.cantidad==0 || m.precio ==0)
                return 0;

            return 1;
        }

        public string informacionMedicamento(int idMedicamento)
        {
            Medicamentos medicamentos = new Medicamentos();
            return medicamentos.informacionMedicamento(idMedicamento);
        }

        public string alertaVencimiento()
        {
            string medicamentoVencer = "¡ALERTA! Próximos medicamentos a vencer. \n\n";

            Medicamentos medicamentos = new Medicamentos();
            DataTable dataTable = medicamentos.alertaVencimiento();

            foreach (DataRow row in dataTable.Rows)
            {
                // Recorre cada columna en la fila
                foreach (DataColumn col in dataTable.Columns)
                {
                    // Agrega el valor de la celda actual al StringBuilder
                    medicamentoVencer += row[col].ToString();
                    medicamentoVencer += "\n"; // Agrega un espacio como separador entre los valores de las columnas
                }
            }

            return medicamentoVencer;
        }
    }
}
