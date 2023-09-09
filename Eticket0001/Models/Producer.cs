using System.ComponentModel.DataAnnotations;

namespace eticket.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        public string ProfilePictureUrl { get; set; }
        [Display(Name = "Full Name")]

        public string FullName { get; set;  }
        [Display(Name = "Bio Graphy")]

        public string Bio { get; set; }

        //relationship with movie is very important part of this producers

        public List<Movie> movie { get; set; }
    }
}
