namespace CFKA.Health.Application.Commands.Handler;

public class CommandHandler
{
    private readonly ICommandHandler _handler;

    public CommandHandler(ICommandHandler handler)
    {
        _handler = handler;
    }

    public async Task Handle(ICommand command, int id) => await _handler.Update(command, id);
    public async Task Handle(ICommand command) => await _handler.Insert(command);
    public async Task Handle(int id) => await _handler.Delete(id);
}