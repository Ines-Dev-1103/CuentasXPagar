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
    
    public partial class Parametros
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Parametros()
        {
            this.Cierre = new HashSet<Cierre>();
        }
    
        public int id_parametro { get; set; }
        public Nullable<System.DateTime> mes_de_proceso { get; set; }
        public Nullable<System.DateTime> ano_de_proceso { get; set; }
        public string cierre_ejecutado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cierre> Cierre { get; set; }
    }
}
