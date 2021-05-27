using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public partial class TblCategory
    {
        [Key]
        public int IN_CATEGORY_ID { get; set; }
        [Required(ErrorMessage ="Please selectr pocess name")]
        public int? IN_PROCESS_ID { get; set; }
        [Required(ErrorMessage = "Please define category name")]
        [ForeignKey("IN_PROCESS_ID")]
        public virtual TblProcess TblProcess { get; set; }
        public string VC_CATEGORY_NAME { get; set; }
        [Required(ErrorMessage = "Please define sequence number")]
        public int IN_SEQUENCE { get; set; }
        public bool B_PROMPT { get; set; }
        public int IN_LASTUPDATED_BY { get; set; }
        public DateTime? DT_LASTUPDATED_ON { get; set; }
        [NotMapped]
        public string VC_PROCESS_NAME { get; set; }
    }
}
