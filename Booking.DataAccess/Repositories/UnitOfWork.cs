﻿using Booking.DataAccess.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;
        public ICategoryRepository Category { get; private set; }
        public IProductRepository Product { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _context = db;
            Category = new CategoryRepository(_context);
            Product = new ProductRepository(_context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
