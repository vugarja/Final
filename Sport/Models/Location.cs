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

        //[DisplayName("Şəhər")]
        //[Required, StringLength(50)]
        //public string City { get; set; }

        //[DisplayName("Kənd")]
        //[StringLength(50)]
        //public string Village { get; set; }

        //[DisplayName("Küçə adı")]
        //[Required, StringLength(50)]
        //public string StreetName { get; set; }

        [DisplayName("Küçə №")]
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

        //[DisplayName("Telefon 2")]
        //[StringLength(10)]
        //public string Phone2 { get; set; }

        //[DisplayName("E-poçtu")]
        //[Required,StringLength(100)]
        //public string Email { get; set; }

        //[DisplayName("Facebook")]
        //[Required, StringLength(100)]
        //public string Facebook { get; set; }

        //[DisplayName("Instagram")]
        //[Required, StringLength(100)]
        //public string Instagram { get; set; }

        //[DisplayName("Vebsayt")]
        //[Required, StringLength(200)]
        //public string Webpage { get; set; }

        //[DisplayName("Endirim haqda")]
        //[Required, StringLength(200)]
        //public string Discount { get; set; }

        [DisplayName("Haqqında")]
        [Required, StringLength(300)]
        public string Info { get; set; }

        public Region Region { get; set; }
        public Station Station { get; set; }
        public Category Category { get; set; }
    }
}