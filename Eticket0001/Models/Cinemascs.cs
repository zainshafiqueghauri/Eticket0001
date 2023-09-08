using Microsoft.EntityFrameworkCore.Query;

namespace eticket.Models
{
    public class Cinemascs
    {
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        // relation btw t2 tables 
        public List<Movie> movies { get; set; }
    }
}
