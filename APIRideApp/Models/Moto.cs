//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APIRideApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Moto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Moto()
        {
            this.Empleado = new HashSet<Empleado>();
        }
    
        public int motoId { get; set; }
        public string modelo { get; set; }
        public string marca { get; set; }
        public string color { get; set; }
        public string placa { get; set; }
        public string estado { get; set; }
        public System.DateTime fechaRegistro { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empleado> Empleado { get; set; }
    }
}
