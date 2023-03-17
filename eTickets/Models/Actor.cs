using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Profile Picture")]
        [Required(ErrorMessage ="The Profile picture is required")]
        public string? ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "The actor's name is required")]
        [StringLength(50,MinimumLength =3, ErrorMessage ="The full name must be between 50 and 3 chars")]
        public string? FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "The actor's biography is required")]
        public string? Bio { get; set; }

        //Relationships
        public List<Actor_Movie>? Actors_Movies { get; set; }
    }
}
