using NLayer.Core.DTOs;
using NLayer.Core.Model;

namespace NLayer.Core.Services
{
    public interface ICategoryService : IService<Category>
    {
        public Task<CustomResponseDto<CategoryWithProductDto>> GetSingleCategoryByIdWithProductsAsync(int categoryId);
    }
}
