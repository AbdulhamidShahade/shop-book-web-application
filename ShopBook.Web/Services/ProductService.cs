using Newtonsoft.Json;
using ShopBook.Web.Models;

namespace ShopBook.Web.Services
{
    public class ProductService : IProductService
    {
        private HttpClient _httpClient;
        private string _url;

        public ProductService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _url = configuration.GetValue<string>("ApiUrls:ProductsUrl");
        }

        public async Task<ApiResponse> GetProductsAsync(string point)
        {
            var response = await _httpClient.GetStringAsync($"{_url}/{point}");

            ApiResponse apiResponse = JsonConvert.DeserializeObject<ApiResponse>(Convert.ToString(response));

            return apiResponse;
        }
    }
}
