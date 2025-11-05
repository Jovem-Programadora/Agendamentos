namespace Agendamentos.Biblioteca;

public class Appointment
{
    public int ID { get; set; }
    public int ClientID { get; set; }
    public int EmployeeID { get; set; }
    public int ServiceID { get; set; }
    public DateTime ScheduledAt { get; set; }

    public Client Client { get; set; }
    public Employee Employee { get; set; }
    public Service Service { get; set; }

    public Appointment() { }
    public Appointment(Client client, Employee employee, Service service, DateTime scheduleAt)
    {
        this.Client = client;
        this.Employee = employee;
        this.Service = service;
        this.ScheduledAt = scheduleAt;
    }

    public Appointment(Client client, Employee employee, Service service, DateTime scheduledAt, int id) : this(client, employee, service, scheduledAt)
    {
        this.ID = id;
    }
}
