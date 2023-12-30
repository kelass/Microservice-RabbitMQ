using MicroRabbit.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Transfer.Data.Context
{
    public class TransferDbContext:DbContext
    {
        public TransferDbContext(DbContextOptions options)
            :base(options)
        {
            Database.Migrate();
        }
        public DbSet<TransferLog> TransferLogs { get; set; }
    }
}
