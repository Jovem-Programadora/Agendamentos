namespace Agendamentos.Biblioteca.DTOs;

public class ClientDto : UserDto
{
    public bool CanReceiveEmail { get; set; } = false;

    public ClientDto() { }

    public ClientDto(Client client)
    {
        ID = client.ID;
        Name = client.Name;
        Email = client.Email;
        CanReceiveEmail = client.CanReceiveEmail;
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

