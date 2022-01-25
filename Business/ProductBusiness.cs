namespace Products;

public class ProductBusiness : Business<Product, Product>
{
    protected override ReadRepository<Product> ReadRepository => Repository.Product;

    protected override Repository<Product> WriteRepository => Repository.Product;
}