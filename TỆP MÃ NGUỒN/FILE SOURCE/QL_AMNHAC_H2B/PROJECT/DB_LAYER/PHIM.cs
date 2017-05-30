namespace PROJECT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIM")]
    public partial class PHIM
    {
        public int PHIMID { get; set; }

        public string TENPHIM { get; set; }

        public int? NGHESIID { get; set; }

        public double? DANHGIA { get; set; }

        public int? ALBUMID { get; set; }

        public string DUONGDANPHIM { get; set; }

        public virtual ALBUM ALBUM { get; set; }

        public virtual NGHESI NGHESI { get; set; }
    }
}
