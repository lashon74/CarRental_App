//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRentalApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class CarRental_Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CarRental_Users()
        {
            this.CarRental_UserRoles = new HashSet<CarRental_UserRoles>();
        }
    
        public int Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarRental_UserRoles> CarRental_UserRoles { get; set; }
    }
}
