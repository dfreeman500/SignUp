using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SignUp.Models
{
    public class Person: Base
    {
        //public int Id { get; set; }
        [Required]
        [DisplayName("Volunteer Name")]

        public string PersonName { get; set; }
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Please enter 10 digit phone number (ex: 555-555-5555 format)")]
        [DisplayName("Phone Number")]

        public string PhoneNumber { get; set; }

        public int EventId { get; set; }
        public ICollection<Event> Event { get; set; }
    }
}
