using BilgeAdam.Common.Dtos;
namespace BilgeAdam.Services.Abstractions
{
    public interface IProductService
    {
        void Add(ProductAddDto dto);
        void Delete(int productId);
    }
}
