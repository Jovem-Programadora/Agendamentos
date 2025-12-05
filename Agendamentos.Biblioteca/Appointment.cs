using Agendamentos.Biblioteca.DTOs;

namespace Agendamentos.Biblioteca;

public class Appointment
{
    public int ID { get; set; }
    public int ClientID { get; set; }
    public int EmployeeID { get; set; }
    public int ServiceID { get; set; }
    public DateTime ScheduledAt { get; set; }

    public Client Client { get; set; } = new ();
    public Employee Employee { get; set; } = new();
    public Service Service { get; set; } = new();

    public Appointment() { }
    public Appointment(AppointmentRegistrationDto dto)
    {
        ClientID = dto.ClientID;
        EmployeeID = dto.EmployeeID;
        ServiceID = dto.ServiceID;
        ScheduledAt = dto.ScheduledAt;
    }

}
