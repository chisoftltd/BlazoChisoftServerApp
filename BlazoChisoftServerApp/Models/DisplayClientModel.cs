using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazoChisoftServerApp.Models
{
    public class DisplayClientModel
    {
        [Required]
        [StringLength(10, ErrorMessage = "First Name is too long")]
        [MinLength(1, ErrorMessage = "First Name is too short")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Last Name is too long")]
        [MinLength(1, ErrorMessage = "Last Name is too short")]
        public string LastName { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "City Name is too short")]
        public string City { get; set; }
    }
}
