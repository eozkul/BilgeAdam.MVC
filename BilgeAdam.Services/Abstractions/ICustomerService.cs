using BilgeAdam.Common.Dtos.Customer;

namespace BilgeAdam.Services.Abstractions
{
    public interface ICustomerService
    {
        void AddCustomer(CustomerAddDto dto);
        void DeleteCustomer(string customerId);
    }
}
