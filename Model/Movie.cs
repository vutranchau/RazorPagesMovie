using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [MaxLength(20)]
        [MinLength(3)]
        public string Title { get; set; }

        [DataType(DataType.Date)]

        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; }
        
        public decimal Price { get; set; }
    }
}