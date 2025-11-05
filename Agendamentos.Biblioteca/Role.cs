namespace Agendamentos.Biblioteca;

public class Role
{
    public int ID { get; private set; }
    public string Name { get; private set; }
    public List<Employee> Employees { get; set; }

    public Role() { }
    public Role(string name)
    {
        this.Name = name;
    }

    public Role(string name, int id) : this(name)
    {
        this.ID = id;
    }
}
