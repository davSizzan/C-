namespace BTLWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblTaiKhoanQuyen")]
    public partial class tblTaiKhoanQuyen
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TaiKhoanQuyen { get; set; }

        public int tblTaiKhoan_TaiKhoanID { get; set; }

        public int tblPhanQuyen_PhanQuyenID { get; set; }

        public virtual tblPhanQuyen tblPhanQuyen { get; set; }

        public virtual tblTaiKhoan tblTaiKhoan { get; set; }
    }
}
