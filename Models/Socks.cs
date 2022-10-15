using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MvcSocks.Models
{
    public class socks
    {
        public int Id { get; set; }
        public string Company { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime LaunchDate { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }
    }
}
