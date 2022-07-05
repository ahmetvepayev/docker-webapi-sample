namespace DockerWebApiTest.Data;

public class ProductPgsRepository : IProductRepository
{
    private readonly AppDbContext _context;

    public ProductPgsRepository(AppDbContext context)
    {
        _context = context;
    }

    public List<Product> GetAll()
    {
        return _context.Products.ToList();
    }

    public Product GetById(int id)
    {
        return _context.Products.Find(id);
    }

    public void Add(Product product)
    {
        _context.Products.Add(product);
        _context.SaveChanges();
    }

    public void Update(Product product)
    {
        _context.Products.Update(product);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var deletedProduct = _context.Products.Find(id);
        _context.Products.Remove(deletedProduct);
        _context.SaveChanges();
    }
}