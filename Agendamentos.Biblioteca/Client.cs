using Agendamentos.Biblioteca.DTOs;

namespace Agendamentos.Biblioteca;

public class Client : User
{
    public bool CanReceiveEmail { get; set; } = false;
    public List<Appointment>? Appointments { get; set; }

    public Client() { }

    public Client(ClientRegistrationDto dto)
    {
        Name = dto.Name;
        Email = dto.Email;
        Phone = dto.Phone;
        Birth = dto.Birth;
        CanReceiveEmail = dto.CanReceiveEmail;
    }
}