namespace Products;

public class ProductBusiness : Business<Product, Product>
{
    protected override Read<Product> Read => Repository.Product;

    protected override Write<Product> Write => Repository.Product;
}