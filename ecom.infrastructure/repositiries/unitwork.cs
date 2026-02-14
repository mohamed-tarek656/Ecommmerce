using ecom.core.interfaces;
using ecom.infrastructure.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecom.infrastructure.repositiries
{
    public class unitwork : iunitofwork
    {
        //this is give me allow not to do any scoped in infrastructure 
        private readonly appdbcontext _context;
        public iphotorepository photorepository {  get;}

        public iproductrepository productrepository { get;}

        public icategoryrepository categoryrepository { get; }
        public unitwork(appdbcontext context)
        {
            _context = context;
            categoryrepository = new categoryrepository(_context);
            photorepository = new photorepository(_context);
            productrepository=new productrepository(_context);

            
        }

    }
}
