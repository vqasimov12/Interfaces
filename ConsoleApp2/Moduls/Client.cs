using ConsoleApp2.Interfaces;

namespace ConsoleApp2.Moduls;

internal class Client : Person
{
   public string LiveAddress;
   public string WorkAddress;
    public Client(string _name, string _surname, int _age, double _salary,string liveAddress,string workaddress)
        : base(_name, _surname, _age, _salary)
    {
        WorkAddress = workaddress;
        LiveAddress = liveAddress;
        Id = Guid.NewGuid();
    }
}

