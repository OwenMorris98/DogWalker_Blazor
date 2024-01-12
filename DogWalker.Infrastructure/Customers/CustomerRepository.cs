using DogWalker.Application.Customers;
using DogWalker.Application.Data;
using DogWalker.Domain.Customers;
using DogWalker_Blazor.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogWalker.Infrastructure.Customers
{
    public class CustomerRepository : ICustomerRepository
    {

        private readonly IApplicationDbContext _context;
        public CustomerRepository(IApplicationDbContext context) 
        {
            _context = context;
        }

        public void addCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
        }

        public void addCustomerData(Customer customer)
        {

            _context.Customers.Update(customer);
        }

        public async Task<Customer> GetCustomerById(string id)
        {
            return await _context.Customers.FindAsync(id);
        }

        public void Save()
        {
            _context.Save();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
