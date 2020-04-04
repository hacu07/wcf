using ServiciosEnvios.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosEnvios.Utilidades
{
    public class Util
    {
        

        public bool encontroCliente(string cedula, enviosEntities bd)
        {
            CLIENTE efCliente = bd.CLIENTE.Find(cedula);
            return (efCliente != null);
        }
    }
}