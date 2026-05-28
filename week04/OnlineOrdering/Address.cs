public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _zipcode;
    private string _country;

    public Address(
        string street,
        string city,
        string state,
        string zipcode,
        string country
    )
    {
        _street = street;
        _city = city;
        _state = state;
        _zipcode = zipcode;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }

    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state} {_zipcode}\n{_country}";
    }
}