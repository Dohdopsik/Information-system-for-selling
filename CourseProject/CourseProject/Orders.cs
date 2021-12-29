namespace CourseProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orders
    {
        [Key]
        public int НомерЗаказа { get; set; }

        public DateTime Дата { get; set; }

        [Required]
        [StringLength(30)]
        public string ТипЗаказа { get; set; }

        [Required]
        [StringLength(30)]
        public string СтатусЗаказа { get; set; }

        public int? АртикулТовара { get; set; }

        [Required]
        [StringLength(30)]
        public string Клиент { get; set; }

        public decimal Стоимость { get; set; }

        [StringLength(30)]
        public string Исполнитель { get; set; }

        public string Комментарий { get; set; }

        public virtual Clients Clients { get; set; }

        public virtual Product Product { get; set; }
    }
}
