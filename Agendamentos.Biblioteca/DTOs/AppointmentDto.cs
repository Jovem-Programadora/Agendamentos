namespace Agendamentos.Biblioteca.DTOs;

public class AppointmentDto
{
    public int ID { get; set; }
    public string ClientName { get; set; } = string.Empty;
    public string EmployeeName { get; set; } = string.Empty;
    public string ServiceName { get; set; } = string.Empty;
    public DateTime ScheduledAt { get; set; }
    public decimal TotalPrice { get; set; }

    public AppointmentDto() { }
    public AppointmentDto(Appointment appointment)
    {
        ID = appointment.ID;
        ClientName = appointment.Client.Name;
        EmployeeName = appointment.Employee.Name;
        ServiceName = appointment.Service.Name;
        ScheduledAt = appointment.ScheduledAt;
        TotalPrice = appointment.Service.Price;
    }
}


public class AppointmentRegistrationDto {
    public int ClientID { get; set; }
    public int EmployeeID { get; set; }
    public int ServiceID { get; set; }
    public DateTime ScheduledAt { get; set; }

}
