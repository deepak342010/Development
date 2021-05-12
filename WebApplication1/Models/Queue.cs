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
        public string VC_QUEUE_NAME { get; set; }

        [ForeignKey("TblProcess")]
        public TblProcess IN_PROCESS_ID { get; set; }
    }
}

