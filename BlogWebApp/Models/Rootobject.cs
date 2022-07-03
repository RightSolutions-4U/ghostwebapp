using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebApp.Models
{
    public class Rootobject
    {
        public IEnumerable<Post> posts { get; set; }
        public Meta meta { get; set; }
    }
}
