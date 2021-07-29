using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contactswebv1.Models
{
    public class State
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage ="Name of the state is required" )]
        [StringLength(ContactWebConstants.MAX_STATE_nAME_LENGTH)]
        public string Name { get; set; }
        [Required(ErrorMessage = "State Abbreviation is required")]
        [StringLength(ContactWebConstants.MAX_STATE_ABBR_LENGTH)]
        public string Abbreviation { get; set; }
    }
}
