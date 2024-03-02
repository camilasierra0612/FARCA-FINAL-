using Servicio_actas_farmaceuticas.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicio_actas_farmaceuticas.View
{
    public partial class Registro_Compra : Form
    {
        public Registro_Compra()
        {
            InitializeComponent();
        }

        private void txtMedicamento_TextChanged(object sender, EventArgs e)
        {
            int idMedicamento = (txtMedicamento.Text.Length > 0) ? int.Parse(txtMedicamento.Text) : 0;

            MedicamentosController medicamento = new MedicamentosController();

            string resultado = medicamento.informacionMedicamento(idMedicamento);

            lblInfoMedicamento.Text = resultado;
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            string numeroDocumento = (txtCliente.Text.Length > 0) ? txtCliente.Text : "";

            ClientesController cliente = new ClientesController();

            string resultado = cliente.informacionCliente(numeroDocumento);

            lblInfoCliente.Text = resultado;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var frm = new Menu_opciones();
            frm.Show();
            this.Hide();
        }

        private void Registro_Compra_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Para hacer una compra, primero busca el medicamento por su código y al cliente por su número de documento");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idMedicamento = (txtMedicamento.Text.Length > 0) ? int.Parse(txtMedicamento.Text) : 0;
            int idCliente = (txtMedicamento.Text.Length > 0) ? int.Parse(lblInfoCliente.Text.Split('-')[1]) : 0;
            int cantidad = int.Parse(txtCantidad.Value.ToString());
            int precio = int.Parse(txtPrecio.Value.ToString());
            int total = cantidad * precio;

            ComprasController compras = new ComprasController();
            compras.medicamentoFk = idMedicamento;
            compras.clienteFk = idCliente;
            compras.cantidad = cantidad;
            compras.precio = precio;
            compras.total = total;
            compras.fechaCompra = fechaCompra.Value;

            int result = compras.guardarCompra();

            if (result > 0)
            {
                MessageBox.Show("Compra #" + result + " registrada correctamente");
                var frm = new Menu_opciones();
                frm.Show();
                this.Hide();
            }
            else if (result == 0)
            {
                MessageBox.Show("Debe diligenciar todos los campos");
                lblMedicamento.ForeColor = Color.Red;
                lblCliente.ForeColor = Color.Red;
                lblCantidad.ForeColor = Color.Red;
                lblPrecio.ForeColor = Color.Red;
                lblFecha.ForeColor = Color.Red;
            }
            else if (result == -2)
            {
                MessageBox.Show("Lo sentimos, pero el medicamento no cuenta Stock suficiente");
            }
        }

        private void txtCantidad_ValueChanged(object sender, EventArgs e)
        {
            lblPrecioTotal.Text = calcularTotal().ToString("#,##0");
        }

        private void txtPrecio_ValueChanged(object sender, EventArgs e)
        {
            lblPrecioTotal.Text = calcularTotal().ToString("#,##0");
        }

        private int calcularTotal()
        {
            int cantidad = (int.Parse(txtCantidad.Value.ToString()) > 0) ? int.Parse(txtCantidad.Value.ToString()) : 0;
            int precio = (int.Parse(txtPrecio.Value.ToString()) > 0) ? int.Parse(txtPrecio.Value.ToString()) : 0;
            return cantidad * precio;
        }
    }
}
