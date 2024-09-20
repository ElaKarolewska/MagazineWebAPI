using MagazineWebApi.DataAccess.CQRS.Commands;

namespace MagazineWebApi.DataAccess.CQRS
{
    public class CommandExecutor : ICommandExecutor
    {
        private readonly WarehouseStorageContext context;

        public CommandExecutor(WarehouseStorageContext context)
        {
            this.context = context;
        }
        public Task<TResult> Execute<TParametrs, TResult>(CommandBase<TParametrs, TResult> command)
        {
            return command.Execute(context);
        }
    }
}
