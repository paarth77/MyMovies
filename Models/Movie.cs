using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyMovies.Models
{

    public class Movie // Movie model
    {
        [Key] // represent unique idenitiy 
        public int MID { get; set; }
        [Required]
        // Title of the Movie
        public string Title { get; set; }
        [DataType(DataType.Date)] // Movie Released Date
        public DateTime Released { get; set; }
        [Required] // Movie IMDB RAting
        public int Rating { get; set; }
    }
}
