//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewProject1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblReceipe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblReceipe()
        {
            this.tblSaveRecipes = new HashSet<tblSaveRecipe>();
        }
    
        public int Id { get; set; }
        public string DishName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSaveRecipe> tblSaveRecipes { get; set; }
    }
}
