namespace CFKA.Health.Train.Application.Commands.CreateUpdateUser;

public class CreateUpdateUserCommand : ICommand
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public Guid? TrainerId { get; set; }
}