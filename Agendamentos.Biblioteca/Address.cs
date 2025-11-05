namespace Agendamentos.Biblioteca;

public class Address
{
    public int ID { get; set; }
    public string Street { get; set; } = String.Empty;
    public string Number { get; set; } = String.Empty;
    public string? Complement { get; set; }
    public string Neighborhood { get; set; } = String.Empty;
    public string City { get; set; } = String.Empty;
    public string ZIPCode { get; set; } = String.Empty;

    public Address() { }
    public Address(string street, string number, string neighborhood, string city, string zipCode)
    {
        this.Street = street;
        this.Number = number;
        this.Neighborhood = neighborhood;
        this.City = city;
        this.ZIPCode = zipCode;
    }

    public Address(string street, string number, string neighborhood, string city, string zipCode, string complement, int id) : this(street, number, neighborhood, city, zipCode)
    {
        this.Complement = complement;
        this.ID = id;
    }
}