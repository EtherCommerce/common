using System.Threading.Tasks;

namespace EtherCommerce.Common.Commands
{
    public interface ICommandHandler<in T> where T : ICommand
    {
        Task HandleAsync(T command);
    }
}
