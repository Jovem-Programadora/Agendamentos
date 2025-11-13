using Agendamentos.Biblioteca.DTOs;
using System.Text.Json.Serialization;

namespace Agendamentos.Biblioteca;

public class Employee : User
{
    public string Password { get; set; } = string.Empty;
    public int RoleID { get; set; }
    [JsonIgnore]
    public Role Role { get; set; } = new();
    public List<Appointment>? Appointments { get; set; }

    public Employee() { }
    public Employee(EmployeeRegistrationDto dto)
    {
        Name = dto.Name;
        Email = dto.Email;
        Phone = dto.Phone;
        Birth = dto.Birth;
        Password = dto.Password;
        RoleID = dto.RoleID;
    }

}
