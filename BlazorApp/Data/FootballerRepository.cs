using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Data
{
    public class FootballerRepository
    {
        private FootballerContext db;

        public FootballerRepository(FootballerContext db)
        {
            this.db = db;
        }

        public async Task<bool> Exists(int id)
        {
            return await db.Footballers.AsNoTracking().FirstOrDefaultAsync(footballer => footballer.Id == id) != null;
        }

        public async Task<List<Footballer>> GetAll()
        {
            return await db.Footballers.ToListAsync();
        }

        public async Task<Footballer> Get(int id)
        {
            return await db.Footballers.FirstOrDefaultAsync(footballer => footballer.Id == id);
        }

        public async Task Add(Footballer item)
        {
            await db.Footballers.AddAsync(item);
            await SaveChanges();
        }

        public async Task Edit(Footballer item)
        {
/*            var existingFootballer = db.Footballers.Local.SingleOrDefault(f => f.Id == item.Id);
            if (existingFootballer != null)
                db.Entry(existingFootballer).State = EntityState.Detached;*/
            db.Footballers.Update(item);
            await SaveChanges();
        }

        public async Task Delete(int id)
        {
            var footballer = await db.Footballers.FirstOrDefaultAsync(footballer => footballer.Id == id);
            if (footballer != null)
            {
                db.Footballers.Remove(footballer);
                await SaveChanges();
            }
        }

        public async Task SaveChanges()
        {
            await db.SaveChangesAsync();
        }
    }
}
