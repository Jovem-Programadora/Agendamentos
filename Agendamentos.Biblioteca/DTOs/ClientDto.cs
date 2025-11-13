namespace Agendamentos.Biblioteca.DTOs;

public class ClientDto : UserDto
{
    public bool CanReceiveEmail { get; set; } = false;

    public ClientDto() { }

    public ClientDto(Client client)
    {
        Birth = client.Birth;
        CanReceiveEmail = client.CanReceiveEmail;
        Description = client.Description;
        Email = client.Email;
        ID = client.ID;
        Name = client.Name;
        Phone = client.Phone;
    }
}

public class ClientRegistrationDto : UserRegistrationDto
{
    public bool CanReceiveEmail { get; set; } = false;
}

public class ClientUpdateDto : UserUpdateDto
{
    public bool CanReceiveEmail { get; set; } = false;
}

