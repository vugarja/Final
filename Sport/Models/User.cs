using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sport.Models
{


    //Creating a user model for database

    public enum MaleFemale
    {
        male = 0,
        female = 1,
    }

    public class User
    {
        public int Id { get; set; }

        [Required,StringLength(50)]
        public string Name { get; set; }

        [Required, StringLength(50)]
        public string Surname { get; set; }

        [Required, StringLength(50)]
        public string Email { get; set; }

        [Required, StringLength(200)]
        public string Password { get; set; }

        [Required]
        [Column(TypeName="Date")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public MaleFemale Sex { get; set; }

        [Required, StringLength(50)]
        public string StreetAddress { get; set; }

        [Required, StringLength(10)]
        public string StreetNo { get; set; }

        public int RegionId { get; set; }

        public int StationId { get; set; }

        [StringLength(10)]
        public string Phone { get; set; }

        public Region Region { get; set; }
        public Station Station { get; set; }
    }
}