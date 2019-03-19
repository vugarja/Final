using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sport.Models
{
    public class Location
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        [Required, StringLength(50)]
        public string StreetAddress { get; set; }

        [Required, StringLength(10)]
        public string StreetNo { get; set; }

        [Required]
        public int RegionId { get; set; }

        [Required]
        public int StationId { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        [Column(TypeName ="money")]
        public decimal DailyPrice { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal MonthlyPrice { get; set; }

        [Required]
        public string Image { get; set; }

        public Region Region { get; set; }
        public Station Station { get; set; }
        public Category Category { get; set; }
    }
}