namespace ConsoleApp2.Moduls;

internal class Bank
{
    public string Name { get; set; }
    public double Budget { get; set; }
    public double Profit { get; set; }
    public List<Manager> Managers;
    public List<Worker>Workers;
    public CEO Ceo;
    public List<Client> Clients;
    public Bank(string name,double profit,double budget)
    {
        Managers = new();
        Workers = new();
        Clients = new();
        Ceo = new("Chief", "Executive","Officer" ,35,5000);
        Profit = profit;
        Budget = budget;
        Name = name;
    }

    public void ShowClientCredit(string name)
    {
        Console.WriteLine("Wait while amountis calculating...");
    }
    public void PayCredit()
    {
        Console.WriteLine("The payment was successful");
    }
    public void ShowAllCredit()
    {
        Console.WriteLine("All credits");
    }

}
