using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyMovies.Models
{
    public class Director // model class for my favorite directors of movies
    {
        [Key] // unique for director table
        public int AId { get; set; }
        [Required]
        // name of the director
        public string Name { get; set; }
        [DataType(DataType.Date)]
        [Required]
        // dob of the director
        public DateTime DateOfBirth { get; set; }
        // nationality of the director
        public string Nationality { get; set; }
    }
}
