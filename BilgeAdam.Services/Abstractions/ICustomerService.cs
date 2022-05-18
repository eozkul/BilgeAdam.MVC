using BilgeAdam.Common.Dtos;
namespace BilgeAdam.Services.Abstractions
{
    public interface ICustomerService
    {
        void AddCustomer(CustomerAddDto dto);
        void DeleteCustomer(string customerId);
    }
}
