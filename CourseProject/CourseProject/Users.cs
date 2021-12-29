namespace CourseProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        [Key]
        [StringLength(30)]
        public string Логин { get; set; }

        [Required]
        [StringLength(30)]
        public string Пароль { get; set; }

        [Required]
        [StringLength(30)]
        public string Роль { get; set; }

        public virtual Clients Clients { get; set; }
    }
}
