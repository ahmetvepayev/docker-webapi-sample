using DockerWebApiTest.Data;

namespace DockerWebApiTest.Service;

public interface IProductService
{
    List<Product> GetAll();
    Product GetById(int id);
    void Add(Product product);
    void Update(Product product);
    void Delete(int id);
}