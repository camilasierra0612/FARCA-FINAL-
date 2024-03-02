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
    public partial class Registro_Medicamento : Form
    {
        public Registro_Medicamento()
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
            MedicamentosController medicamentos = new MedicamentosController();
            medicamentos.nombre = txtNombre.Text;
            medicamentos.empaque = txtEmpaque.Text;
            medicamentos.cantidad = int.Parse(txtCantidad.Value.ToString());
            medicamentos.presentacion = txtPresentacion.Text;
            medicamentos.fechaVencimiento = fechaVencimiento.Value;
            medicamentos.viaAdministracion = txtAdministracion.Text;
            medicamentos.almacenamiento = txtAlmacenamiento.Text;
            medicamentos.especificaciones = txtEspecificaciones.Text;
            medicamentos.precio = int.Parse(txtPrecio.Value.ToString());

            int result = medicamentos.guardarMedicamento();

            if (result>0)
            {
                MessageBox.Show("Se ha registrado correctamente el medicamento con código: "+result);

                var frm = new Menu_opciones();
                frm.Show();
                this.Hide();

            }else if (result == 0)
            {
                MessageBox.Show("Ha occurrido un error al registrar el medicamento");
            }else if(result == -1)
            {
                MessageBox.Show("Debe diligenciar todos los campos");
                lblNombre.ForeColor = Color.Red;
                lblCantidad.ForeColor = Color.Red;
                lblPrecio.ForeColor = Color.Red;
            }
        }

        private void fechaVencimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtEspecificaciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAlmacenamiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtAdministracion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtPresentacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }

        private void txtEmpaque_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }
    }
}
