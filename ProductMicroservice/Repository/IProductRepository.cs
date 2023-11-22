using ProductMicroservice.Model;

namespace ProductMicroservice.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int id);
        void InsertProduct(Product product);
        void DeleteProduct(int id);
        void UpdateProduct(Product product);
        void Save();
    }
}
