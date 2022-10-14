using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MvcSocks.Models
{
    public class Socks
    {
        public int Id { get; set; }
        public string Company { get; set; }

        [DataType(DataType.Date)]
        public DateTime LaunchDate { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
    }
}
