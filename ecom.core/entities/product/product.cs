using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecom.core.entities.product
{
    public class product:baseentity<int>
    {
        public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public virtual List<photo> photos { get; set; }
        public int categoryid { get; set; }
        [ForeignKey(nameof(categoryid))]
        public virtual category category { get; set; }
    }
}
