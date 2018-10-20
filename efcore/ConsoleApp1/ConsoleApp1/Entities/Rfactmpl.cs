using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("rfactmpl")]
    public partial class Rfactmpl
    {
        [Column("rfactmpl_id")]
        public int RfactmplId { get; set; }
        [Column("org_id")]
        public int OrgId { get; set; }
        [Required]
        [Column("rfactmpl_short")]
        [StringLength(50)]
        public string RfactmplShort { get; set; }
        [Column("rfactmpl_desc")]
        [StringLength(1000)]
        public string RfactmplDesc { get; set; }
        [Column("evidence_desc")]
        [StringLength(1000)]
        public string EvidenceDesc { get; set; }
        [Column("external_desc")]
        [StringLength(1000)]
        public string ExternalDesc { get; set; }
        [Column("external_type")]
        [StringLength(1)]
        public string ExternalType { get; set; }
        [Column("external_attatch_flag")]
        [StringLength(1)]
        public string ExternalAttatchFlag { get; set; }
        [Column("external_comment_flag")]
        [StringLength(1)]
        public string ExternalCommentFlag { get; set; }
        [Column("rfactmpl_level")]
        public short RfactmplLevel { get; set; }
        [Column("rfactmpl_order")]
        public short? RfactmplOrder { get; set; }
        [Column("rfactmpl_levelorder")]
        [StringLength(10)]
        public string RfactmplLevelorder { get; set; }
        [Column("rfactmpl_hiddenorder")]
        [StringLength(20)]
        public string RfactmplHiddenorder { get; set; }
        [Column("parent_rfactmpl_id")]
        public int? ParentRfactmplId { get; set; }
        [Column("clone_rfactmpl_id")]
        public int? CloneRfactmplId { get; set; }
        [Column("filetype")]
        [StringLength(50)]
        public string Filetype { get; set; }
        [Column("filesize")]
        [StringLength(50)]
        public string Filesize { get; set; }
        [Column("filename")]
        [StringLength(100)]
        public string Filename { get; set; }
        [Column("rfactmpl_doc", TypeName = "image")]
        public byte[] RfactmplDoc { get; set; }
        [Column("creation_date", TypeName = "datetime")]
        public DateTime CreationDate { get; set; }
        [Column("time_stamp", TypeName = "datetime")]
        public DateTime? TimeStamp { get; set; }
    }
}
