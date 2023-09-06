namespace CFKA.Health.Domain.Interfaces.Handler;

public interface ICommandHandler
{
    Task Insert(ICommand command);
    Task Update(ICommand command, int id);
    Task Update(ICommand command, Guid id);
    Task Delete(int id);
    Task Delete(Guid id);
}