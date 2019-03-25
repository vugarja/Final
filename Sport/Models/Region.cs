using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Sport.Models
{
    public class Region
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Ad hissəsi boş ola bilməz"), StringLength(20)]
        [DisplayName("Rayon adı") ]
        public string Name { get; set; }

        public List<User> Users { get; set; }
        public List<Location> Locations { get; set; }

    }
}