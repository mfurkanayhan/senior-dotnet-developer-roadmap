using DomainDrivenDesign.Domain.Abstractions;

namespace DomainDrivenDesign.Domain.Products;

public sealed class Product : Entity
{
    public Product(Name name, Description description, Money money)
    {
        // Ekstra Kontroller

        Name = name;
        Description = description;
        Price = money;
    }
    public Name Name { get; private set; }
    public Description Description { get; private set; }
    public Money Price { get; private set; }
    
    public void ChangeName(string name)
    {
        Name = new(name);
    }
}

#region ProductTest
/*
public class Test
{
    public Test()
    {
        Name name = new("Furkan");

        Product product = new(
            name: name,
            description: new Description("Description"),
            money: Money.Zero());

        product.ChangeName("Software Engineer");
    }
}
*/
#endregion

public interface IProductRepository
{
    Task CreateAsync(CreateProductDto request, CancellationToken cancellationToken = default);
    Task<List<Product>> GetAllAsync(CancellationToken cancellationToken = default);
}
