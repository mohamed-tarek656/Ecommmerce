using ecom.core.interfaces;
using ecom.infrastructure.data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ecom.infrastructure.repositiries
{
    public  class genericrepository<t> : igenericrepository<t> where t : class
        
    {
        private readonly appdbcontext _context;

        public genericrepository(appdbcontext context)
        {
            _context = context;
        }

        public async Task addasync(t entity)
        {
            await _context.Set<t>().AddAsync(entity);
            await _context.SaveChangesAsync();

        }

        public async Task deletasync(int id)
        {
           var entity=await _context.Set<t>().FindAsync(id);
           
                _context.Set<t>().Remove(entity);
                await _context.SaveChangesAsync();
            
        }

        public async Task<IReadOnlyList<t>> getallasync()
            => await _context.Set<t>().AsNoTracking().ToListAsync();



        public async Task<IReadOnlyList<t>> getallasync(params Expression<Func<t, object>>[] includes)
        {
            var query = _context.Set<t>().AsQueryable();    
            foreach (var item in includes)
            {
                query = query.Include(item);
            }
            return await query.ToListAsync();

        }

        public async Task<t> getbyidasync(int id)
        {
            var entity = await _context.Set<t>().FindAsync(id); 
            return entity;
        }

        public async Task<t> getbyidasync(int id, params Expression<Func<t, object>>[] includes)
        {
            IQueryable<t> query = _context.Set<t>();
            foreach (var item in includes)
            {
                query = query.Include(item);
            }
            var entity=await query.FirstOrDefaultAsync(e => EF.Property<int>(e, "Id") == id);
            return entity;
        }

        public async Task updateasync(t entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
