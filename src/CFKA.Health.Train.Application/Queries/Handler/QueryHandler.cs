using Microsoft.Extensions.Logging;

namespace CFKA.Health.Application.Queries.Handler;

public class QueryHandler<T>
{
    private readonly IQueryHandler<T> _handler;

    public QueryHandler(IQueryHandler<T> handler)
    {
        _handler = handler;
    }

    public async Task<T> Handle(int id)
    {
        return await _handler.GetById(id);
    }

    public async Task<List<T>> Handle() => await _handler.GetAll();
}