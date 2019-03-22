using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sport.Models
{
    public class Location
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        [DisplayName("Adı")]
        public string Name { get; set; }

        [DisplayName("Ünvan")]
        [Required, StringLength(50)]
        public string StreetAddress { get; set; }

        [DisplayName("Bina №")]
        [Required, StringLength(10)]
        public string StreetNo { get; set; }

        [DisplayName("Rayon")]
        [Required]
        public int RegionId { get; set; }

        [DisplayName("Stansiya")]
        [Required]
        public int StationId { get; set; }

        [DisplayName("Məkan növü")]
        [Required]
        public int CategoryId { get; set; }

        [DisplayName("Günlük qiyməti")]
        [Required]
        [Column(TypeName ="money")]
        public decimal DailyPrice { get; set; }

        [DisplayName("Aylıq qiyməti")]
        [Required]
        [Column(TypeName = "money")]
        public decimal MonthlyPrice { get; set; }

        [DisplayName("Şəkil")]
        [Required]
        public string Image { get; set; }

        [DisplayName("Telefon")]
        [Required, StringLength(10)]
        public string Phone { get; set; }

        [DisplayName("Haqqında")]
        [Required, StringLength(300)]
        public string Info { get; set; }

        public Region Region { get; set; }
        public Station Station { get; set; }
        public Category Category { get; set; }
    }
}