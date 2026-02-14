using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecom.core.entities.product
{
    public class photo:baseentity<int>
    {
        public string imagename { get; set; }
        public int productid { get; set; }
        [ForeignKey(nameof(productid))]
            public virtual product product { get; set; }    
    }
}
