using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sport.Models
{
    public class Blog
    {
        public int Id { get; set; }

        [Required, DisplayName("Başlıq")]

        public string Title { get; set; }

        [Required, DisplayName("Tarix")]
        [Column(TypeName="Date")]
        public DateTime? Date { get; set; }

        [Required, DisplayName("Foto")]
        public string Photo { get; set; }

        [Required, DisplayName("Mətn")]
        public string Text { get; set; }

    }
}