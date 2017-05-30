namespace PROJECT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOPTHU")]
    public partial class HOPTHU
    {
        [Key]
        public int EMAILID { get; set; }

        public DateTime? NGAYKHOITAO { get; set; }

        public int? NGUOIDUNGID { get; set; }

        public int? ADMINID { get; set; }

        public string NOIDUNG { get; set; }

        public virtual ADMINISTATOR ADMINISTATOR { get; set; }

        public virtual NGUOIDUNG NGUOIDUNG { get; set; }
    }
}
