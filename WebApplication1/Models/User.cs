using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "La edad es obligatoria")]
        public int Age { get; set; }

        [Required(ErrorMessage = "La nacionalidad es obligatoria")]
        public string Nacionality { get; set; }
    }
}
