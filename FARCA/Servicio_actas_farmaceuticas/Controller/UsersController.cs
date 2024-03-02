using Servicio_actas_farmaceuticas.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicio_actas_farmaceuticas.Controller
{
    internal class UsersController
    {
        public string username { get; set; }
        public string password { get; set; }
        public UsersController(string username, string password)
        {
            this.username = username;
            this.password = password;   
        }

        public int login()
        {
            Users user = new Users();
            user.username = this.username;
            user.password = this.password;

            if (validateFields(user) != 1)
                return -1;

            return user.login();
        }

        private int validateFields(Users objUser)
        {
            if (objUser.username.Length < 1 || objUser.password.Length < 1)
                return 0;
            else
                return 1;
        }
    }
}
