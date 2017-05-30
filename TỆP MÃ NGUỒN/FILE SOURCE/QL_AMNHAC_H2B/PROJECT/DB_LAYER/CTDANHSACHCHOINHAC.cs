namespace PROJECT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTDANHSACHCHOINHAC")]
    public partial class CTDANHSACHCHOINHAC
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DANHSACHID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BAIHATID { get; set; }

        public int? SOLANCHOINHAC { get; set; }

        public virtual BAIHAT BAIHAT { get; set; }

        public virtual DANHSACHCHOINHAC DANHSACHCHOINHAC { get; set; }
    }
}
