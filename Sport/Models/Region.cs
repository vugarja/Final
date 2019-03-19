using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sport.Models
{
    public class Region
    {
        public int Id { get; set; }

        [Required, StringLength(20)]
        public string Name { get; set; }

        public List<User> Users { get; set; }
        public List<Location> Locations { get; set; }

    }
}