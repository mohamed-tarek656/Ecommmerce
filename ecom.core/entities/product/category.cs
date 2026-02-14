using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecom.core.entities.product
{
    public class category:baseentity<int>
    {
        public string name { get; set; }
        public string description { get; set; } 
        public ICollection<product> products { get; set; }=new HashSet<product>();
    }
}
