using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SignUp.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required]
        public string EventName { get; set; }

        [DataType(DataType.Date)]
        public DateTime EventDate { get; set; }

        //public string People => string.Join(",", Person?.Select(c => c?.PersonName)?.ToArray());

        public int PersonId { get; set; }
        public ICollection<Person> Person { get; set; }
        //public ICollection<TaskList> TaskList { get; set; }
    }
}
