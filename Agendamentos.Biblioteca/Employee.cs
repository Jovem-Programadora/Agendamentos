using Agendamentos.Biblioteca.DTOs;

namespace Agendamentos.Biblioteca;

public class Employee : User
{
    public string Password { get; set; } = string.Empty;
    public List<Appointment>? Appointments { get; set; }

    public Employee() { }
    public Employee(EmployeeRegistrationDto dto)
    {
        Name = dto.Name;
        Email = dto.Email;
        Phone = dto.Phone;
        Birth = dto.Birth;
        Password = dto.Password;
    }

}
