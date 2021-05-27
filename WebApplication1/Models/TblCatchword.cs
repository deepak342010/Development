using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public partial class TblCatchword
    {
        [Key]
        public int IN_CATCHWORD_ID { get; set; }
        [Required(ErrorMessage ="Please select type")]
        public int IN_TYPE { get; set; }
        [Required(ErrorMessage = "Please define catchword name")]
        public string VC_CATCHWORD { get; set; }
        public bool B_PROMPT { get; set; }
        [Required(ErrorMessage = "Please define order")]
        public int TI_CATCHWORD_ORDER { get; set; }
        public int IN_LASTUPDATED_BY { get; set; }
        public DateTime? DT_LASTUPDATED_ON { get; set; }
    }
}
