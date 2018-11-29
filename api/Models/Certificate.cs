using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Certificate
    {
        public string Name { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidThrough { get; set; }
        public string Thumbprint { get; set; }
    }
}
