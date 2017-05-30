namespace PROJECT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DANHSACHCHOINHAC")]
    public partial class DANHSACHCHOINHAC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DANHSACHCHOINHAC()
        {
            CTDANHSACHCHOINHACs = new HashSet<CTDANHSACHCHOINHAC>();
        }

        [Key]
        public int DANHSACHID { get; set; }

        public string TENLISTNHAC { get; set; }

        public int? MAID_NGUOIDUNG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTDANHSACHCHOINHAC> CTDANHSACHCHOINHACs { get; set; }

        public virtual NGUOIDUNG NGUOIDUNG { get; set; }
    }
}
