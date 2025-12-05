namespace Agendamentos.Biblioteca.DTOs;

public class EmployeeDto : UserDto
{
    public EmployeeDto() { }

    public EmployeeDto(Employee employee)
    {
        ID = employee.ID;
        Email = employee.Email;
        Name = employee.Name;
    }
}

public class EmployeeRegistrationDto : UserRegistrationDto
{
    public string Password { get; set; } = string.Empty;
}

public class EmployeeUpdateDto : EmployeeRegistrationDto { }