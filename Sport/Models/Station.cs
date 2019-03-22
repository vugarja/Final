using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Sport.Models
{
    public class Station
    {
        public int Id { get; set; }

        [Required, StringLength(20), DisplayName("Adı")]
        public string Name { get; set; }

        public List<User> Users { get; set; }
        public List<Location> Locations { get; set; }
    }
}