namespace QuanLyBanSach
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductDetail")]
    public partial class ProductDetail
    {
        public int ID { get; set; }

        public int ProductId { get; set; }

        public int? AuthorId { get; set; }

        public string Code { get; set; }

        public virtual Author Author { get; set; }

        public virtual Product Product { get; set; }
    }
}
