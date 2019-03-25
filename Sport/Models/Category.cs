using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Sport.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required, StringLength(20), DisplayName("Məkan növü")]
        public string Name { get; set; }

        public List<Location> Locations { get; set; }
    }
}