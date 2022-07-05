namespace DockerWebApiTest.Data;

public class ProductList
{
    internal List<Product> ListOfProducts { get; set; } = new List<Product>
    {
        new(){
            Id = 1,
            Name = "Product 1",
            Price = 100
        },
        new(){
            Id = 2,
            Name = "Product 2",
            Price = 250
        },
        new(){
            Id = 3,
            Name = "Product 3",
            Price = 400
        }
    };
}