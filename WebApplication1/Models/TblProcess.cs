using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class TblProcess
    {
        [Key]
        public int IN_PROCESS_ID { get; set; }
        [Required(ErrorMessage ="*")]
        public string VC_PROCESS_NAME { get; set; }

        [Required(ErrorMessage = "*")]
        public int IN_LAST_SEQ { get; set; }
        public int IN_LASTUPDATED_By { get; set; }
        public DateTime DT_LASTUPDATED_ON { get; set; }

        [NotMapped]
        public string Action { get; set; }
    }
}
