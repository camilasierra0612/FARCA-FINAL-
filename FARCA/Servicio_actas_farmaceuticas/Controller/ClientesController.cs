using Servicio_actas_farmaceuticas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio_actas_farmaceuticas.Controller
{
    internal class ClientesController
    {

        public ClientesController() { }

        public string nombres { set; get; }
        public string apellidos { set; get; }
        public string tipoDocumento { set; get; }
        public string numeroDocumento { set; get; }
        public string celular { set; get; }
        public string departamento { set; get; }
        public string ciudad { set; get; }
        public string direccion { set; get; }

        public int guardarCliente()
        {
            Clientes cliente = new Clientes();
            cliente.nombres = nombres;
            cliente.apellidos = apellidos;
            cliente.tipoDocumento = tipoDocumento;
            cliente.numeroDocumento = numeroDocumento;
            cliente.celular = celular;
            cliente.departamento = departamento;
            cliente.ciudad = ciudad;
            cliente.direccion = direccion;

            if (validarDatos(cliente) == 1)
            {
                int id = cliente.guardarCliente();
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

        public string informacionCliente(string numeroDocumento)
        {
            Clientes cliente = new Clientes();
            return cliente.informacionCliente(numeroDocumento);
        }

        private int validarDatos(Clientes c)
        {
            if (c.nombres.Length < 1 || c.apellidos.Length < 1 ||
                c.apellidos.Length < 1 || c.celular.Length < 1 ||
                c.tipoDocumento.Length < 1 || c.numeroDocumento.Length < 1 ||
                c.departamento.Length < 1 || c.ciudad.Length < 1 || c.direccion.Length < 1)
                return 0;

            return 1;
        }
    }
}
