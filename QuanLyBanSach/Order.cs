namespace QuanLyBanSach
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        public int ID { get; set; }

        public int Status { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime DeliveryDate { get; set; }

        public string Description { get; set; }

        public string Address { get; set; }

        public int? UserId { get; set; }

        public int? AnonymousUserId { get; set; }

        public double TotalAmount { get; set; }

        public string Code { get; set; }

        public virtual AnonymousUser AnonymousUser { get; set; }

        public virtual User User { get; set; }
    }
}
