namespace Products;

public class Repository
{
    public static Write<Products.Attribute> Attribute
    {
        get
        {
            return new Write<Products.Attribute>(new ProductsContext());
        }
    }

    public static Write<Products.Brand> Brand
    {
        get
        {
            return new Write<Products.Brand>(new ProductsContext());
        }
    }

    public static Write<Products.ProductAttribute> ProductAttribute
    {
        get
        {
            return new Write<Products.ProductAttribute>(new ProductsContext());
        }
    }

    public static Write<Products.Product> Product
    {
        get
        {
            return new Write<Products.Product>(new ProductsContext());
        }
    }
}
