namespace PROJECT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAIHAT")]
    public partial class BAIHAT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BAIHAT()
        {
            CTDANHSACHCHOINHACs = new HashSet<CTDANHSACHCHOINHAC>();
        }

        public int BAIHATID { get; set; }

        public string TENBAIHAT { get; set; }

        public int? NGHESIID { get; set; }

        public double? DANHGIA { get; set; }

        public int? ALBUMID { get; set; }

        public string DUONGDANBAIHAT { get; set; }

        public virtual ALBUM ALBUM { get; set; }

        public virtual NGHESI NGHESI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTDANHSACHCHOINHAC> CTDANHSACHCHOINHACs { get; set; }
    }
}
