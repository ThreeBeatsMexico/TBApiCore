//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThreeBits.Data.Models.Seguridad
{
    using System;
    using System.Collections.Generic;
    
    public partial class NUMERACION
    {
        public int ID_NUMERACION { get; set; }
        public int ID_DOCTYPE { get; set; }
        public string NMBSERIE { get; set; }
        public Nullable<long> NMBNUMBERFROM { get; set; }
        public Nullable<long> NMBCURRENTNUMBER { get; set; }
        public long NMBNUMBERTO { get; set; }
        public string NMBAUTHNUMBER { get; set; }
        public int NMBAUTHDATE { get; set; }
        public string NMBRFC { get; set; }
    }
}