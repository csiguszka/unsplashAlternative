using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unsplashAlternative.Model
{
    public class Pager
    {
        public int TotalPages { get; set; }
        public int Page { get; set; }

        public Pager()
        {
            Page = 1;
        }
    }
}
