namespace QuanLyBanSach
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductImage")]
    public partial class ProductImage
    {
        public int ID { get; set; }

        public int? ProductId { get; set; }

        public string Url { get; set; }

        public string Code { get; set; }

        public virtual Product Product { get; set; }
    }
}
