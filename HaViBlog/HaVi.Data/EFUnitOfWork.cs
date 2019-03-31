using HaViBlog.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace HaViBlog.Data
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext context;

        public EFUnitOfWork(AppDbContext _context)
        {
            context = _context;
        }

        public void Commit()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
