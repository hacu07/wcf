//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiciosEnvios
{
    using System;
    using System.Collections.Generic;
    
    public partial class ENVIOS
    {
        public int COD_GUIA { get; set; }
        public string CEDULA_EMI { get; set; }
        public string CEDULA_DES { get; set; }
        public int CIUD_ORIG { get; set; }
        public int CIUD_DEST { get; set; }
        public int PESO { get; set; }
        public int VALOR_ASEG { get; set; }
        public int PRECIOKL { get; set; }
        public int VALOR_ENVI { get; set; }
        public int COD_ESTADO { get; set; }
    
        public virtual CIUDAD CIUDAD { get; set; }
        public virtual CIUDAD CIUDAD1 { get; set; }
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual CLIENTE CLIENTE1 { get; set; }
        public virtual ESTADOS ESTADOS { get; set; }
    }
}
