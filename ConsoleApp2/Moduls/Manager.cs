using ConsoleApp2.Interfaces;

namespace ConsoleApp2.Moduls;

internal class Manager:Person,IOrganize,IPosition
{
    public string Position { get; set; }
    public Manager(string _name, string _surname, string _position, int _age, double _salary)
        : base(_name, _surname, _age, _salary)
    {
        Position = _position;
        Id = Guid.NewGuid();
    }
    public void Organize()
    {
        Console.WriteLine("Organizing...");
    }
    public void CalculateSalaries()
    {
        Console.WriteLine("Calculating Salaries...");
    }
}
