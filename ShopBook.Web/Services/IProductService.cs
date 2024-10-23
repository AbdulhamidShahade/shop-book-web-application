
using ShopBook.Web.Models;

namespace ShopBook.Web.Services
{
    public interface IProductService
    {
        Task<ApiResponse> GetProductsAsync(string point);
    }
}
