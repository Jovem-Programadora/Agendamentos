namespace Agendamentos.Biblioteca;

public class Service
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public List<Appointment> Appointments { get; set; }

    public Service() { }
    public Service(string name)
    {
        this.Name = name;
    }

    public Service(string name, int id) : this(name)
    {
        this.ID = id;
    }
}
