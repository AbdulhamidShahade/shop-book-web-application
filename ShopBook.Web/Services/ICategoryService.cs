

using ShopBook.Web.Models;

namespace ShopBook.Web.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetProductCategoriesAsync();
    }
}
