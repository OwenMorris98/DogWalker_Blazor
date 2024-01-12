using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DogWalker.Domain.Customers;
namespace DogWalker.Application.Customers
{
    public interface ICustomerService
    {
        void addCustomer(string id);

        Task addCustomerData(Customer customer);

        void Save();

        Task SaveAsync();
    }
}
