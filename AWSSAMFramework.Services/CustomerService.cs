using System;
using System.Collections.Generic;
using System.Linq;
using AWSSAMFramework.Services.DTO;

namespace AWSSAMFramework.Services
{
    public interface ICustomerService
    {
        void AddCustomer(Customer customer);
        Customer GetCustomer(int id);
    }

    public class CustomerService : ICustomerService
    {
        private List<Customer> _customers;

        public CustomerService() => _customers = new List<Customer>();

        public void AddCustomer(Customer customer) => _customers.Add(customer);

        public Customer GetCustomer(int id) => _customers.FirstOrDefault(c => c.Id == id);
    }
}
