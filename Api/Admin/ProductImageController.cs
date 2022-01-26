namespace Products;

public class ProductImageController : Controller<Image, Image>
{
    public override ReadBusiness<Image> ReadBusiness => new ImageBusiness();

    public override Business<Image, Image> Business => new ImageBusiness();
}