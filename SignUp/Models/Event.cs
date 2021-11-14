using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SignUp.Models
{
    public class Event: Base
    {
        //public int Id { get; set; }

        [Required]
        [DisplayName("Event Name")]
        public string EventName { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Event Date")]

        public DateTime EventDate { get; set; }

        //public string People => string.Join(",", Person?.Select(c => c?.PersonName)?.ToArray());

        [DisplayName("Event Host")]

        public int PersonId { get; set; }
        public ICollection<Person> Person { get; set; }
        //public ICollection<TaskList> TaskList { get; set; }

        [DisplayName("Item")]
        public string Item1 { get; set; }
        [DisplayName("Volunteer")]
        public string? Name1 { get; set; }

        [DisplayName("Item")]
        public string Item2 { get; set; }
        [DisplayName("Volunteer")]
        public string? Name2 { get; set; }

        [DisplayName("Item")]
        public string Item3 { get; set; }
        [DisplayName("Volunteer")]
        public string? Name3 { get; set; }

        [DisplayName("Item")]
        public string Item4 { get; set; }
        [DisplayName("Volunteer")]
        public string? Name4 { get; set; }

        [DisplayName("Item")]
        public string Item5 { get; set; }
        [DisplayName("Volunteer")]
        public string? Name5 { get; set; }


        //public string Item2 { get; set; }
        //public string? Name2 { get; set; }
        //public string Item3 { get; set; }
        //public string? Name3 { get; set; }
        //public string Item4 { get; set; }
        //public string? Name4 { get; set; }
        //public string Item5 { get; set; }
        //public string? Name5 { get; set; }
        //public string Item6 { get; set; }
        //public string? Name6 { get; set; }
        //public string Item7 { get; set; }
        //public string? Name7 { get; set; }
        //public string Item8 { get; set; }
        //public string? Name8 { get; set; }
        //public string Item9 { get; set; }
        //public string? Name9 { get; set; }
        //public string Item10 { get; set; }
        //public string? Name10 { get; set; }
    }
}
