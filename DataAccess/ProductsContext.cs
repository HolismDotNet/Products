namespace Products;

public class ProductsContext : DatabaseContext
{
    public override string ConnectionStringName => "Products";

    public DbSet<Products.Attribute> Attributes { get; set; }

    public DbSet<Products.Brand> Brands { get; set; }

    public DbSet<Products.Image> Images { get; set; }

    public DbSet<Products.ProductAttribute> ProductAttributes { get; set; }

    public DbSet<Products.Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
