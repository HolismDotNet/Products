namespace Products;

public class Attribute : IEntity
{
    public Attribute()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public string Name { get; set; }

    public long AttributeTypeId { get; set; }

    public dynamic RelatedItems { get; set; }
}
