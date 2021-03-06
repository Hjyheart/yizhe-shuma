namespace TPDigital.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("C##COM.TP_SHOPPING_CART")]
    public partial class TP_SHOPPING_CART
    {
        public decimal USER_ID { get; set; }

        public decimal PRODUCT_ID { get; set; }

        public decimal QUANTITY { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        public virtual TP_PRODUCT TP_PRODUCT { get; set; }

        public virtual TP_USER TP_USER { get; set; }
    }
}
