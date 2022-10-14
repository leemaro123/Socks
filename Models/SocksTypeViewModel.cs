using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcSocks.Models
{
    public class SocksTypeViewModel
    {
        public List<socks> SocksS { get; set; }
        public SelectList Types { get; set; }
        public string SocksType { get; set; }
        public string SearchString { get; set; }
    }
}
