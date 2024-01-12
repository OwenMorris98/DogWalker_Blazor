using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DogWalker.Domain.Customers;

namespace DogWalker.Application.Customers
{
    public interface ICustomerRepository
    {

        Task<Customer> GetCustomerById(string id);
        void addCustomer(Customer customer);

        void addCustomerData(Customer customer);

        void Save();

        Task SaveAsync();
    }
}
