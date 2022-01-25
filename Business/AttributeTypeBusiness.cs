namespace Products;

public class AttributeTypeBusiness : EnumBusiness<AttributeType>
{
    public override string ConnectionString => Repository.Product.ConnectionString;
}