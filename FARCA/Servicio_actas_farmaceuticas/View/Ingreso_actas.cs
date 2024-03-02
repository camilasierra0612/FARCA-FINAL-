using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Servicio_actas_farmaceuticas
{
    public partial class Ingreso_actas : Form
    {
        public Ingreso_actas()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            txtConsecutivo.KeyPress += txtConsecutivo_KeyPress;
            txtMarca.KeyPress += txtMarca_KeyPress;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            var frm = new Menu_opciones();
            frm.Show();
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Esta seguro de que desea guardar el registro del acta?");
        }

        private void btnCrearLaboratorio_Click(object sender, EventArgs e)
        {
            var frm = new Registro_laboratorio();
            frm.Show();
            this.Hide();
        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            var frm = new Registro_producto();
            frm.Show();
            this.Hide();
        }

        private void btnCrearEmpresa_Click(object sender, EventArgs e)
        {
            var frm = new Registro_proveedor();
            frm.Show();
            this.Hide();
        }

        private void txtConsecutivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
