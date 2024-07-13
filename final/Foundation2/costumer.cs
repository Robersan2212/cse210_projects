public class Customer
{
    public string Name { get; }
    public Address Address { get; }

    public Customer(string name, Address address)
    {
        this.Name = name;
        this.Address = address;
    }

    public bool IsInUSA()
    {
        return Address.IsInUSA();
    }
}
