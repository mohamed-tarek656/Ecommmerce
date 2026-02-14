using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecom.core.interfaces
{
    public interface iunitofwork
    {
        public iphotorepository photorepository {  get;}
        public iproductrepository productrepository {  get;}
        public icategoryrepository categoryrepository { get;}
    }
}
