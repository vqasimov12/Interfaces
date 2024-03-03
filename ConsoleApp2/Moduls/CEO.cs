using ConsoleApp2.Interfaces;

namespace ConsoleApp2.Moduls;
public class CEO:Person,IPosition,IOrganize
{
    public string Position { get; set; }
    public CEO(string _name, string _surname, string _position, int _age, double _salary)
        :base(_name,_surname,_age,_salary)
    {
        Position = _position;
        Id = Guid.NewGuid();
    }
    public void DecreacePercentage(double percentage)
    {
        Console.WriteLine($"Percentage decreased {percentage}%");
    }
    public void Control()
    {
        Console.WriteLine("Controlling...");
    }
    public void Organize()
    {
        Console.WriteLine("Organizing...");
    }
    public void Meeting()
    {
        Console.WriteLine("Meeting...");
    }

}
