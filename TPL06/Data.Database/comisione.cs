//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Academia.Data.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class comisione
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public comisione()
        {
            this.cursos = new HashSet<curso>();
        }
    
        public int id_comision { get; set; }
        public string desc_comision { get; set; }
        public int anio_especialidad { get; set; }
        public int id_plan { get; set; }
    
        public virtual plane plane { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<curso> cursos { get; set; }
    }
}
