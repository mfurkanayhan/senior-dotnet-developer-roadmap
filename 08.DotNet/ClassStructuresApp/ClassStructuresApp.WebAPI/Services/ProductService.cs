using ClassStructuresApp.WebAPI.DTOs;
using ClassStructuresApp.WebAPI.Models;
using ClassStructuresApp.WebAPI.Utilities;

namespace ClassStructuresApp.WebAPI.Services;

public class ProductService
{
    public static List<Product> products = new();

    public Result<List<Product>> GetAll()
    {
        return products;
    }
    public Result<Guid> Add(AddProductDto request)
    {
        Product product = new(
            name: request.Name,
            quantity: request.Quantity,
            price: request.Price
        );

        products.Add(product);

        return "Adding product was successful.";
    }

    public Result<Guid> Selling(Guid productId, int quantity)
    {
        Product? product = products.FirstOrDefault(p => p.Id == productId);
        if (product is null) 
        {
            return (500, "Product not found!");
        }

        product.Quantity -= quantity;

        if (product.Quantity < 0)
        {
            product.Quantity += quantity;

            string errorMessage = " The sale was canceled because the " + product.Name + " product stock would become stale after the sale. Add stock and sell again!";

            return (500, errorMessage);
        }

        return "Sales transaction completed successfully.";
    }

    public Result<Guid> AddStock(Guid productId, int quantity)
    {
        Product? product = products.FirstOrDefault(p => p.Id == productId);
        if (product is null)
        {
            return (500, "Product not found!");
        }

        product.Quantity += quantity;

        return "Product stock updated successfully.";
    }

    public Result<List<ProductReportListDto>> GetProductListForReport()
    {
        var reportList = products.Select(p => new ProductReportListDto()
        {
            ProductName = p.Name,
            ProductQuantity = p.Quantity
        }).ToList();

        return reportList;
    }  
}
