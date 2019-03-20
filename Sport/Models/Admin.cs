using System.ComponentModel.DataAnnotations;

namespace Sport.Models
{
    public class Admin
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        [Required, StringLength(50)]
        public string Surname { get; set; }

        [Required, StringLength(50)]
        public string Email { get; set; }

        [Required, StringLength(150)]
        public string Password { get; set; }

    }
}