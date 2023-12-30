using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository:ITransferRepository
    {
        private TransferDbContext _db;
        public TransferRepository(TransferDbContext db)
        {
            _db = db;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _db.TransferLogs;
        }
    }
}
