//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VehicleRental.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vehicle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehicle()
        {
            this.Orders = new HashSet<Order>();
            this.VehicleImages = new HashSet<VehicleImage>();
        }
    
        public int Id { get; set; }
        public int UserId { get; set; }
        public Nullable<int> BrandId { get; set; }
        public Nullable<int> TypeId { get; set; }
        public string VehicleName { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> ReantalPrice { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string ContractFileUrl { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual Brand Brand { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
        public virtual User User { get; set; }
        public virtual VehicleType VehicleType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehicleImage> VehicleImages { get; set; }
    }
}
