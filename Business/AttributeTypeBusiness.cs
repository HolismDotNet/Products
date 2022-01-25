namespace Products;

public class AttributeTypeBusiness : EnumBusiness<AttributeType>
{
    protected override string ConnectionString => Repository.Product.ConnectionString;
}