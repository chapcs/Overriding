internal class Program
{
    private static void Main(string[] args)
    {
        VendingMachine vendingMachine = new AnimalFeedVendingMachine();
        Console.WriteLine(vendingMachine.Dispense(2.00M));
    }
}
