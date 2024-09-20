using MagazineWebApi.DataAccess.CQRS.Queries;

namespace MagazineWebApi.DataAccess.CQRS
{
    public class QueryExecutor : IQueryExecutor
    {
        private readonly WarehouseStorageContext context;
        public QueryExecutor(WarehouseStorageContext context)
        {
            this.context = context;
        }
        public Task<TResult> Execute<TResult>(QueryBase<TResult> query)
        {
            return query.Execute(context);
        }
    }
}
