namespace Products;

public class ProductController : Controller<Product, Product>
{
    public override ReadBusiness<Product> ReadBusiness => new ProductBusiness();

    public override Business<Product, Product> Business => new ProductBusiness();
}