using System.Text.Json;

namespace ProductsDemoApi.Data
{
    public class Utility
    {
        private readonly string _filePath = Path.Combine(AppContext.BaseDirectory,"Data", "Products.json");
        public IEnumerable<Product> getProducts()
        {
            if (!File.Exists(_filePath))
                return new List<Product>();

            var json = File.ReadAllText(_filePath);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<List<Product>>(json, options);

        }
    }
}
