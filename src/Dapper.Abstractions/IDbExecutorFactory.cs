namespace Dapper.Abstractions
{
    public interface IDbExecutorFactory
    {
        IDbExecutor CreateExecutor();
    }
}