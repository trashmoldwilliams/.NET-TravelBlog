using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TravelBlog.Models;

namespace travel_blog.Models
{
    [Table("Experiences")]
    public class Experience
    {
        public Experience()
        {
            this.Persons = new HashSet<Person>();
        }

        [Key]
        public int ExperienceId { get; set; }
        public string Description { get; set; }
        public int LocationId { get; set; }
        public virtual ICollection<Person> Persons { get; set; }
    }
}
