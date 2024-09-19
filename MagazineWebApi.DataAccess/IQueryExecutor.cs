
using MagazineWebApi.DataAccess.CQRS.Queries;

namespace MagazineWebApi.DataAccess
{
    internal interface IQueryExecutor
    {
        Task<TResult> Execute<TResult>(QueryBase<TResult> query);
    }
}
