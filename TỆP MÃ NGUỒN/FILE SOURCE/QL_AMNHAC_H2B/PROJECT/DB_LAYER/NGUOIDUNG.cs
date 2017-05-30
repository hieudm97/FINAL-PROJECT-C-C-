namespace PROJECT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NGUOIDUNG")]
    public partial class NGUOIDUNG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NGUOIDUNG()
        {
            DANHSACHCHOINHACs = new HashSet<DANHSACHCHOINHAC>();
            HOPTHUs = new HashSet<HOPTHU>();
        }

        [Key]
        public int MAID { get; set; }

        public string TEN { get; set; }

        public int? TUOI { get; set; }

        public string CONGTY { get; set; }

        public string TENDANGNHAP { get; set; }

        public string MATKHAU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANHSACHCHOINHAC> DANHSACHCHOINHACs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOPTHU> HOPTHUs { get; set; }
    }
}
