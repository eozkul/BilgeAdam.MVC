using BilgeAdam.Common.Dtos.Customer;
using BilgeAdam.Data;
using BilgeAdam.Data.Entities;
using BilgeAdam.Services.Abstractions;
namespace BilgeAdam.Services.Concretes
{
    public class CustomerService : ICustomerService
    {
        private readonly NorthwindDbContext dbContext;

        public CustomerService(NorthwindDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void AddCustomer(CustomerAddDto dto)
        {
            dbContext.Customers.Add(new Customer {
               CustomerID=dto.CustomerId,
                CompanyName=dto.CustomerName,
                ContactName = dto.ContactName,
                Phone = dto.Phone,
                Address = dto.Address,

            });
            dbContext.SaveChanges();
        }

        public void DeleteCustomer(string customerId)
        {
            var result = dbContext.Customers.Where(c => c.CustomerID == customerId).Single();
            if (result is not null)
            {
                dbContext.Customers.Remove(result);
                dbContext.SaveChanges();
            }
         
        }      
    }          
}
