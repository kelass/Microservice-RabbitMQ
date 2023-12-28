namespace MicroRabbit.Banking.Domain.Commands
{
    public class CreateTransferCommand:TransferCommand
    {
        public CreateTransferCommand(int from, int to, decimal amount)
        {
            To = To;
            Amount = amount;
            From = from;
        }
    }
}
