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
    public partial class PQRS : Form
    {
        public PQRS()
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
            pqrsController pqrs = new pqrsController();
            pqrs.tipoSolicitud = cbxSolicitud.Text;
            pqrs.fecha = fechaSolicitud.Value;
            pqrs.observacion = txtObservacion.Text;

            int result = pqrs.guardarPqrs();

            if (result > 0)
            {
                MessageBox.Show("Se ha registrado correctamente el PQRS con código: " + result);

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
                lblFecha.ForeColor = Color.Red;
                lblObservacion.ForeColor = Color.Red;
                lblSolicitud.ForeColor = Color.Red;
            }
        }
    }
}
