using Microsoft.EntityFrameworkCore.Query;
using System.ComponentModel.DataAnnotations;

namespace eticket.Models
{
    public class Cinemascs
    {
        public int Id { get; set; }
        [Display(Name = "Cinema Logo")]
        public string Logo { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        // relation btw t2 tables 
        public List<Movie> movies { get; set; }
    }
}
