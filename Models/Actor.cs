using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyMovies.Models
{
    public class Actor // model class for favorite actors
    {
        [Key] // primary Key set
        public int AId { get; set; }
        [Required]
        // name of the actor
        public string Name { get; set; }
        [DataType(DataType.Date)]
        [Required]
        // DOB of the actor
        public DateTime DateOfBirth { get; set; }
        // nationality of the actor
        public string Nationality { get; set; }

    }
}
