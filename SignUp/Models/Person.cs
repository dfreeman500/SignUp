using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SignUp.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        public string PersonName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public int EventId { get; set; }
        public ICollection<Event> Event { get; set; }
    }
}
