namespace Agendamentos.Biblioteca.DTOs;

public class EmployeeDto : UserDto
{
    public int RoleID { get; set; }
    public string RoleName { get; set; } = string.Empty;

    public EmployeeDto() { }

    public EmployeeDto(Employee employee)
    {
        Birth = employee.Birth;
        Description = employee.Description;
        Email = employee.Email;
        ID = employee.ID;
        Name = employee.Name;
        Phone = employee.Phone;
        RoleID = employee.RoleID;
        RoleName = employee.Role.Name;
    }
}

public class EmployeeRegistrationDto : UserRegistrationDto
{
    public string Password { get; set; } = string.Empty;
    public int RoleID { get; set; }
}

public class EmployeeUpdateDto : UserUpdateDto
{
    public int RoleID { get; set; }
}