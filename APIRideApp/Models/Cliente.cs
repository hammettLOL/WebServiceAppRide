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
    
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            this.Pago = new HashSet<Pago>();
            this.Servicio = new HashSet<Servicio>();
        }
    
        public int clienteId { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string DNI { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string sexo { get; set; }
        public System.DateTime fechaNacimiento { get; set; }
        public int usuarioId { get; set; }
        public int autoId { get; set; }
    
        public virtual Auto Auto { get; set; }
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pago> Pago { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Servicio> Servicio { get; set; }
    }
}
