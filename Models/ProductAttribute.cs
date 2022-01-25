namespace Products;

public class ProductAttribute : IEntity
{
    public ProductAttribute()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public long ProductId { get; set; }

    public long AttributeId { get; set; }

    public string Value { get; set; }

    public dynamic RelatedItems { get; set; }
}
