//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClinicManagement.Core.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CLASS_LEVEL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLASS_LEVEL()
        {
            this.CLASS_DETAILS = new HashSet<CLASS_DETAILS>();
        }
    
        public decimal CLASS_LEVEL_ID { get; set; }
        public string LEVEL_NAME { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLASS_DETAILS> CLASS_DETAILS { get; set; }
    }
}
