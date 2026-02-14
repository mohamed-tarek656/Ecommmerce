using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ecom.core.interfaces
{
    public interface igenericrepository<t>where t: class
    {
        Task<IReadOnlyList<t>>getallasync();
        Task<IReadOnlyList<t>> getallasync(params Expression<Func<t, object>>[] includes);
        Task<t> getbyidasync(int id);
        Task<t>getbyidasync(int id, params Expression<Func<t, object>>[] includes);
        Task addasync(t entity);
        Task updateasync(t entity);
        Task deletasync(int id);
            
    }
}
