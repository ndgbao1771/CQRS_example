namespace CQRS_example.Factories.Interfaces
{
    public interface IQueryHandlerFactory
    {
        IQueryHandler<TQuery, TResult> CreateHandler<TQuery, TResult>() where TQuery : IQuery<TResult>;
    }
}
