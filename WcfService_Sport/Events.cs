//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfService_Sport
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Linq;


    public partial class Events
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Events()
        {
            this.Results = new HashSet<Result>().ToList();
        }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Sport { get; set; }
        [DataMember]
        public System.DateTime Date { get; set; }
        [DataMember]
        public string Competition { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<Result> Results { get; set; }
    }
}