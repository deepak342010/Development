using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public partial class TblQueue
    {
        [Key]
        public int IN_QUEUE_ID { get; set; }
        [Required]
        public string VC_QUEUE_NAME { get; set; }

        [Required]
        public int? IN_PROCESS_ID { get; set; }
        [ForeignKey("IN_PROCESS_ID")]
        public virtual TblProcess TblProcess { get; set; }
        [NotMapped]
        public string VC_PROCESS_NAME { get; set; }
        //[DisplayFormat(DataFormatString = "{0:dd MMM yyyy}", ApplyFormatInEditMode = true)]
        //[DataType(DataType.EmailAddress)]
        //[EmailAddress]
        [NotMapped]
        public DateTime? DT_CREATED_ON { get; set; }
    }
}

