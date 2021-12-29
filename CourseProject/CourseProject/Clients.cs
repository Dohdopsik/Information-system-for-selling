namespace CourseProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Clients
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Clients()
        {
            Orders = new HashSet<Orders>();
        }

        [Key]
        [StringLength(30)]
        public string Логин { get; set; }

        [Required]
        [StringLength(30)]
        public string Город { get; set; }

        public decimal НомерТелефона { get; set; }

        [Required]
        [StringLength(50)]
        public string ФИО { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(30)]
        public string Роль { get; set; }

        public virtual Users Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
