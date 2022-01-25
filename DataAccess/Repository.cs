namespace Products;

public class Repository
{
    public static Repository<Products.Attribute> Attribute
    {
        get
        {
            return new Repository<Products.Attribute>(new ProductsContext());
        }
    }

    public static Repository<Products.Brand> Brand
    {
        get
        {
            return new Repository<Products.Brand>(new ProductsContext());
        }
    }

    public static Repository<Products.ProductAttribute> ProductAttribute
    {
        get
        {
            return new Repository<Products.ProductAttribute>(new ProductsContext());
        }
    }

    public static Repository<Products.Product> Product
    {
        get
        {
            return new Repository<Products.Product>(new ProductsContext());
        }
    }
}
