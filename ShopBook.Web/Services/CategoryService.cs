﻿using Newtonsoft.Json;
using ShopBook.Web.Models;


namespace ShopBook.Web.Services
{
	public class CategoryService : ICategoryService
	{
		private readonly HttpClient _httpClient;
		private string _url;

		public CategoryService(HttpClient httpClient, IConfiguration configuration)
		{
			_httpClient = httpClient;

			_url = configuration.GetValue<string>("ApiUrls:CategoriesUrl");
        }

        public async Task<IEnumerable<Category>> GetProductCategoriesAsync()
        {
            var response = await _httpClient.GetStringAsync($"{_url}");
            var categories = JsonConvert.DeserializeObject<IEnumerable<Category>>(Convert.ToString(response));

			return categories;
        }
	}
}
