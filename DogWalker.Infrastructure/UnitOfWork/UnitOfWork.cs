using DogWalker.Application.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogWalker.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IApplicationDbContext _context;

        public UnitOfWork(IApplicationDbContext context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.Save();
        }

        public async Task SaveAsync()
        {
            _context.SaveChangesAsync();
        }
    }
}
