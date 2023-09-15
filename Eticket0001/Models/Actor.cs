using Eticket0001.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eticket.Models
{
    public class Actor:iEntityBase
    {

        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage ="Profile Picture is Required")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage ="Full Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 to 50 chars")]

        public string FullName { get; set;}

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]

        public string Bio { get; set;}

        //relationship with the actor movie

        public List<Actor_Movie> Actor_Movie { get; set; }
    }
}
