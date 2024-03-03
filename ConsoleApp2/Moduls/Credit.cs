using ConsoleApp2.Interfaces;

namespace ConsoleApp2.Moduls;

internal class Credit:IGuid
{
    public Client client;
    public double Amount;
    public double Percentage;
    public int Months;
    public double Payment;
    public Guid Id { get; set; }
    public Credit(Client _client,double amount,double percentage,int months,double payment)
    {
        Amount = amount;
        Percentage = percentage;
        Months = months;
        Id = Guid.NewGuid();
        client = _client;
        Payment = payment;
    }
    public void CalculatePercentage()
    {
        Console.WriteLine("Percentage is calculating...");
    }
}
