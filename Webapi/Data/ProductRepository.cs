namespace DockerWebApiTest.Data;

public class ProductRepository : IProductRepository
{
    private ProductList _list;

    public ProductRepository(ProductList list)
    {
        _list = list;
    }

    public List<Product> GetAll()
    {
        return _list.ListOfProducts;
    }

    public Product GetById(int id)
    {
        return _list.ListOfProducts.First(x => x.Id == id);
    }

    public void Add(Product product)
    {
        _list.ListOfProducts.Add(product);
    }

    public void Update(Product product)
    {
       var updatedProduct = _list.ListOfProducts.First(x => x.Id == product.Id);
       updatedProduct.Name = product.Name;
       updatedProduct.Price = product.Price;
    }

    public void Delete(int id)
    {
        var deletedProduct = _list.ListOfProducts.First(x => x.Id == id);
        _list.ListOfProducts.Remove(deletedProduct);
    }
}
