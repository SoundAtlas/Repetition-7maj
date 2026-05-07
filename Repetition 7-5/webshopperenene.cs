// === Webshop.Core/Models/ProductBase.cs ===

namespace Webshop.Core.Models;

public abstract class ProductBase
{
    public int Id { get; set; }

    public string Name { get; set; } = "";

    public double Price { get; set; }

    public abstract string GetCategory();
}



// === Webshop.Core/Models/Book.cs ===

namespace Webshop.Core.Models;

public class Book : ProductBase
{
    public string Author { get; set; } = "";

    public string GetCategory() // FEJL: Der mangler override
    {
        return "Bog";
    }
}




// === Webshop.Core/Models/Game.cs ===

namespace Webshop.Core.Models;

public class Game : ProductBase
{
    public int MinAge { get; set; }

    public override string GetCategory() => "Spil";
}




// === Webshop.Core/Repositories/IProductRepository.cs ===

namespace Webshop.Core.Repositories;

public interface IProductRepository
{
    void Add(ProductBase product);

    List<ProductBase> GetAll();
}



// === Webshop.Data/JsonProductRepository.cs ===

using Webshop.Core.Models;
// FEJL: Manglede using statement for Webshop.Core.Repositories
using Webshop.Core;

namespace Webshop.Data;

public class JsonProductRepository : IProductRepository
{
    private List<ProductBase> products = new();

    public void Add(ProductBase product) => products.Add(product);

    public List<ProductBase> GetAll() => products;
}



// === Webshop.App/Program.cs ===

using Webshop.Core.Models;
using Webshop.Data;

var repo = new JsonProductRepository();

repo.Add(new Book
{
    Id = 1,
    Name = "C#",
    Price = 199,
    Author = "Hansen"
});

repo.Add(new ProductBase // FEJL: Kan ikke lave et objekt af en abstract class
{
    Id = 2,
    Name = "Test",
    Price = 99
});

foreach (var p in repo.GetAll())
{
    Console.WriteLine($"{p.GetCategory()}: {p.Name} ({p.Price} kr)");
}