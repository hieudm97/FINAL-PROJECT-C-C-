namespace PROJECT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMINISTATOR")]
    public partial class ADMINISTATOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ADMINISTATOR()
        {
            HOPTHUs = new HashSet<HOPTHU>();
        }

        [Key]
        public int AID { get; set; }

        public string TEN { get; set; }

        public int? TUOI { get; set; }

        public string DIACHI { get; set; }

        public string TENDANGNHAP { get; set; }

        public string MATKHAU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOPTHU> HOPTHUs { get; set; }
    }
}
