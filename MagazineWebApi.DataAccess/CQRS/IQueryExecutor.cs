using MagazineWebApi.DataAccess.CQRS.Queries;

namespace MagazineWebApi.DataAccess.CQRS
{
    public interface IQueryExecutor
    {
        Task<TResult> Execute<TResult>(QueryBase<TResult> query);
    }
}
