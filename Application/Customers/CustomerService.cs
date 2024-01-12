using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DogWalker.Domain.Customers;

namespace DogWalker.Application.Customers
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository) 
       {
         _customerRepository = customerRepository;
       }

        public void addCustomer(string id)
        {
            Customer cust = new Customer() {Id = id };
            this._customerRepository.addCustomer(cust);
        }

        public async Task addCustomerData( Customer cust)
        {

            this._customerRepository.addCustomerData(cust);
            await this._customerRepository.SaveAsync();
        }

        public void Save()
        {
            this._customerRepository.Save();
        }

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
