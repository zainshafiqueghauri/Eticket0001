using System.ComponentModel.DataAnnotations;

namespace eticket.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureUrl { get; set; }
        public string FullName { get; set;  }
        public string Bio { get; set; }

        //relationship with movie is very important part of this producers

        public List<Movie> movie { get; set; }
    }
}
