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
    
    public partial class AUDIT_DOMICILIO
    {
        public long IDDOMICILIOAUDIT { get; set; }
        public Nullable<int> IDOPERACIONAUDIT { get; set; }
        public Nullable<long> IDDOMICILIO { get; set; }
        public Nullable<long> IDUSUARIO { get; set; }
        public string CALLE { get; set; }
        public string NUMEXT { get; set; }
        public string NUMINT { get; set; }
        public string IDESTADO { get; set; }
        public string ESTADO { get; set; }
        public string IDMUN { get; set; }
        public string MUNICIPIO { get; set; }
        public string IDCOLONIA { get; set; }
        public string COLONIA { get; set; }
        public string CP { get; set; }
        public Nullable<System.DateTime> FECHAALTA { get; set; }
        public Nullable<bool> ACTIVODOM { get; set; }
        public Nullable<long> IDUSERMODIFICA { get; set; }
        public Nullable<long> IDAPPMODIFICA { get; set; }
        public Nullable<System.DateTime> FECHATRANSACCION { get; set; }
        public Nullable<bool> ACTIVO { get; set; }
    
        public virtual CAT_OPERACIONAUDIT CAT_OPERACIONAUDIT { get; set; }
    }
}
