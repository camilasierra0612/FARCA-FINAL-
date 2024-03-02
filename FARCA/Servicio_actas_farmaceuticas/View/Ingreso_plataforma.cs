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

namespace Servicio_actas_farmaceuticas
{
    public partial class Ingreso_plataforma : Form
    {
        public Ingreso_plataforma()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string un = txtUsuario.Text;
            string pss = txtContraseña.Text;
            UsersController usersController = new UsersController(un, pss);

            int result = usersController.login();

            if (result==1)
            {
                MessageBox.Show("Ha ingresado al sistema con éxito");

                var frm = new Menu_opciones();
                frm.Show();
                this.Hide();
            }
            else if (result == -1)
            {
                MessageBox.Show("Debe diligenciar todos los campos");
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta");
            }
        }

        private void btnVerContraseña_Click(object sender, EventArgs e)
        {
            if (txtContraseña.PasswordChar == (char)0)
            {
                txtContraseña.PasswordChar = '*';
            }
            else
            {
                txtContraseña.PasswordChar = (char)0;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
