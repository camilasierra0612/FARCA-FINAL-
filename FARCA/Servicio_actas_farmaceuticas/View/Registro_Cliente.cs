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
    public partial class Registro_Cliente : Form
    {
        public Registro_Cliente()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var frm = new Menu_opciones();
            frm.Show();
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClientesController cliente = new ClientesController();
            cliente.nombres = txtNombres.Text;
            cliente.apellidos = txtApellidos.Text;
            cliente.tipoDocumento = tipoDocumento.Text;
            cliente.numeroDocumento = nroDocumento.Text;
            cliente.celular = telefono.Text;
            cliente.departamento = txtDepto.Text;
            cliente.ciudad = txtCiudad.Text;
            cliente.direccion = txtDireccion.Text;

            int result = cliente.guardarCliente();

            if (result > 0)
            {
                MessageBox.Show("Se ha registrado correctamente el cliente con código: " + result);

                var frm = new Menu_opciones();
                frm.Show();
                this.Hide();

            }
            else if (result == 0)
            {
                MessageBox.Show("Ha occurrido un error al registrar el medicamento");
            }
            else if (result == -1)
            {
                MessageBox.Show("Debe diligenciar todos los campos");
                lblNombre.ForeColor = Color.Red;
                lblTipoDocumento.ForeColor = Color.Red;
                lblApellidos.ForeColor = Color.Red;
                lblNumeroDocumento.ForeColor = Color.Red;
                lblCelular.ForeColor = Color.Red;
                lblDepartamento.ForeColor = Color.Red;
                lblCiudad.ForeColor = Color.Red;
                lblDireccion.ForeColor = Color.Red;
            }
        }
    }
}
