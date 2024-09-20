

using MagazineWebApi.DataAccess.CQRS.Commands;

namespace MagazineWebApi.DataAccess.CQRS
{
    public interface ICommandExecutor
    {
        Task<TResult> Execute<TParametrs, TResult>(CommandBase<TParametrs, TResult> command);
    }
}
