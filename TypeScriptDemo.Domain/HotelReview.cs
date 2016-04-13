using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeLite;

namespace TypeScriptDemo.Domain
{
    [TsClass]
    public class HotelReview
    {
        public Int32 ReviewId { get; set; }

        public int HotelId { get; set; }

        public String ReviewerName { get; set; }

        public Rating Rating { get; set; }

        public String Comments { get;set;}

        public DateTime ReviewDate { get; set; }
    }
}
