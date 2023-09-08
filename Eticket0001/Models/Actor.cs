using System.ComponentModel.DataAnnotations;

namespace eticket.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture URL")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]

        public string FullName { get; set;}
        [Display(Name = "Biography")]

        public string Bio { get; set;}

        //relationship with the actor movie

        public List<Actor_Movie> Actor_Movie { get; set; }
    }
}
