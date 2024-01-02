using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Tranfer.Application.Interfaces
{
    public interface ITransferService
    {
        IEnumerable<TransferLog> GetTransferLogs();
    }
}
