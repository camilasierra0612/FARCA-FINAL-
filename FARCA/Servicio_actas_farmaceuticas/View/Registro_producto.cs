using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicio_actas_farmaceuticas
{
    public partial class Registro_producto : Form
    {
        public Registro_producto()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            txtPresentacion.KeyPress += txtPresentacion_KeyPress;
            txtNombreProducto.KeyPress += txtNombreProducto_KeyPress;
        }

        private void btnRegresarActas_Click(object sender, EventArgs e)
        {
            var frm = new Ingreso_actas();
            frm.Show();
            this.Hide();
        }

        private void btnRegresarMenu_Click(object sender, EventArgs e)
        {
            var frm = new Menu_opciones();
            frm.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPresentacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Registro_producto_Load(object sender, EventArgs e)
        {

        }
    }
}
