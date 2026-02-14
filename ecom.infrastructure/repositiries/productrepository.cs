using ecom.core.entities.product;
using ecom.core.interfaces;
using ecom.infrastructure.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecom.infrastructure.repositiries
{
    public class productrepository : genericrepository<product>, iproductrepository
    {
        public productrepository(appdbcontext context) : base(context)
        {
        }
    }
}
