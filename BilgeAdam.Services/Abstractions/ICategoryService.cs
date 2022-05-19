using BilgeAdam.Common.Dtos.Category;

namespace BilgeAdam.Services.Abstractions
{
    public interface ICategoryService
    {
        void AddCategory(CategoryAddDto dto);
        void DeleteCategory(int categoryId);
    }
}
