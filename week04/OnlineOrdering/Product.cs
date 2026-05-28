public class Product
{
    private string _prodName;
    private string _productId;
    private decimal _price;
    private int _quantity;

    public Product(
        string prodName,
        string productId,
        decimal price,
        int quantity
    )
    {
        _prodName = prodName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public decimal GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetProductInfo()
    {
        return $"{_prodName} ({_productId})";
    }
}