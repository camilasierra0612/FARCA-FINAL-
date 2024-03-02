using Servicio_actas_farmaceuticas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio_actas_farmaceuticas.Controller
{
    internal class ComprasController
    {
        public ComprasController() { }

        public int medicamentoFk { get; set; }
        public int clienteFk { get; set; }
        public int cantidad { get; set; }
        public DateTime fechaCompra { get; set; }
        public int precio {  get; set; }
        public int total { get; set; }

        public int guardarCompra()
        {
            Compras compras = new Compras();
            compras.medicamentoFk = medicamentoFk;
            compras.clienteFk = clienteFk;
            compras.cantidad = cantidad;
            compras.fechaCompra = fechaCompra;
            compras.precio = precio;
            compras.total = total;

            if(validarDatos(compras)==1)
            {
                return compras.guardarCompra();
            }

            return 0;
        }

        private int validarDatos(Compras c)
        {
            if (c.medicamentoFk == 0 || c.clienteFk == 0)
                return 0;

            return 1;
        }
    }
}
