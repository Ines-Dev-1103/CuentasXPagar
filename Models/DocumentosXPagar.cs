//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CuentasxPagar.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DocumentosXPagar
    {
        public int id_documento { get; set; }
        public int id_proveedor { get; set; }
        public Nullable<int> no_factura { get; set; }
        public Nullable<System.DateTime> fecha_documento { get; set; }
        public Nullable<System.DateTime> fecha_de_registro { get; set; }
        public Nullable<System.DateTime> fecha_de_vencimiento { get; set; }
        public Nullable<double> monto { get; set; }
        public string estado { get; set; }
    
        public virtual Proveedores Proveedores { get; set; }
    }
}