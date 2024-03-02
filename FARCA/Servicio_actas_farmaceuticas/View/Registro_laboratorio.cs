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
    public partial class Registro_laboratorio : Form
    {
        public Registro_laboratorio()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            var frm = new Menu_opciones();
            frm.Show();
            this.Hide();
        }

        private void btnRegresarActas_Click(object sender, EventArgs e)
        {
            var frm = new Ingreso_actas();
            frm.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
