namespace Products;

public class ImageBusiness : Business<Image, Image>
{
    protected override ReadRepository<Image> ReadRepository => Repository.Image;

    protected override Repository<Image> WriteRepository => Repository.Image;
}