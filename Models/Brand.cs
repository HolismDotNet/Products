namespace Products;

public class Brand : IEntity
{
    public Brand()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public string Name { get; set; }

    public dynamic RelatedItems { get; set; }
}
