using Servicio_actas_farmaceuticas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio_actas_farmaceuticas.Controller
{
    internal class pqrsController
    {
        public pqrsController() { }

        public string tipoSolicitud { set; get; }
        public DateTime fecha { set; get; }
        public string observacion { set; get; }

        public int guardarPqrs()
        {
            pqrs _pqrs = new pqrs();
            _pqrs.tipoSolicitud = tipoSolicitud;
            _pqrs.fecha = fecha;
            _pqrs.observacion = observacion;

            if (validarDatos(_pqrs) == 1)
            {
                int id = _pqrs.guardarPqrs();
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

        private int validarDatos(pqrs p)
        {
            if (p.tipoSolicitud.Length < 1 || p.fecha.ToString().Length < 1 ||
                p.observacion.Length < 1)
                return 0;

            return 1;
        }
    }
}
