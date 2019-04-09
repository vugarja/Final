using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sport.Models
{
    public class CategoryService
    {
        public int Id { get; set; }

        public int SerciceId { get; set; }

        public int CategoryId { get; set; }

        public Service Service { get; set; }
        public Category Category { get; set; }
    }
}