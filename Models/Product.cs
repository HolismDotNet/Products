namespace Products;

public class Product : IEntity
{
    public Product()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public string Title { get; set; }

    public long BrandId { get; set; }

    public dynamic RelatedItems { get; set; }
}
