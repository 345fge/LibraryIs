//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace library
{
    using System;
    using System.Collections.Generic;
    
    public partial class books
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public books()
        {
            this.book_author = new HashSet<book_author>();
            this.extradition = new HashSet<extradition>();
        }
    
        public int id_book { get; set; }
        public string title { get; set; }
        public int publishing_house { get; set; }
        public System.DateTime the_year_of_publishing { get; set; }
        public string storage { get; set; }
        public int section { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<book_author> book_author { get; set; }
        public virtual publishing_house publishing_house1 { get; set; }
        public virtual sections sections { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<extradition> extradition { get; set; }
    }
}