using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Partyinvites.Models { 


    public class GuestResponse
    {
        [Required(ErrorMessage="please enter your Name"),MinLength (4),MaxLength (10)]

        public string  Name { get; set; }
        [Required(ErrorMessage="Please enter your Email ")]
        public string Email { get; set; }
        [Required(ErrorMessage ="please enter your Phone Number ")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please specify whether you will attend the party or not ")]
        public bool ? WillAttendParty { get; set; }
    }
}
