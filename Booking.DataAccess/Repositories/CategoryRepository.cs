using Booking.DataAccess.Repositories.IRepositories;
using Booking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.DataAccess.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _context = db;
        }

        public void Update(Category obj)
        {
            _context.Categories.Update(obj);
        }
    }
}
