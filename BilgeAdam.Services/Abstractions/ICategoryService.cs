using BilgeAdam.Common.Dtos;
namespace BilgeAdam.Services.Abstractions
{
    public interface ICategoryService
    {
        void AddCategory(CategoryAddDto dto);
        void DeleteCategory(int categoryId);
    }
}
