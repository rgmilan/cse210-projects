public class Customer
{
    private string _custName;
    private Address _address;

    public Customer(string custName, Address address)
    {
        _custName = custName;
        _address = address;
    }

    public string GetCustName()
    {
        return _custName;
    }

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetAddress()
    {
        return _address.GetFullAddress();
    }
}