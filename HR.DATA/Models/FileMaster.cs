using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HR.DATA.Models
{
    [Keyless]
    [Table("file_master")]
    public partial class FileMaster
    {
        [Column("file_id")]
        public int FileId { get; set; }
        [Column("file_name")]
        [StringLength(100)]
        public string FileName { get; set; }
        [Column("file_path")]
        [StringLength(500)]
        public string FilePath { get; set; }
        [Column("file_process_flag")]
        [StringLength(45)]
        public string FileProcessFlag { get; set; }
        [Column("file_type")]
        [StringLength(45)]
        public string FileType { get; set; }
        [Column("error_message")]
        [StringLength(1000)]
        public string ErrorMessage { get; set; }
    }
}
