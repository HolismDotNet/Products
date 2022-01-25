namespace Products;

public class Image : IEntity
{
    public Image()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public long ProductId { get; set; }

    public Guid FileGuid { get; set; }

    public dynamic RelatedItems { get; set; }
}
