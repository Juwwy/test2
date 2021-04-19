namespace Task1
{
    public interface IPayable
    {
         decimal RetrieveAmountDue(decimal amount);
         decimal AddToAmountDue(decimal amount);
         string PaymetAddress();
    }
}