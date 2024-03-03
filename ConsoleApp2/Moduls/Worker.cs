using ConsoleApp2.Interfaces;

namespace ConsoleApp2.Moduls;

internal class Worker : Person, IPosition
{
    public List<Operation> Operations { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Position { get; set; }
    public Worker(string _name, string _surname, string _position, int _age, double _salary, DateTime startDate, DateTime endDate)
        : base(_name, _surname, _age, _salary)
    {
        StartDate = startDate;
        EndDate = endDate;
        Position = _position;
        Id = Guid.NewGuid();
    }
    public void AddOperation(Operation operation)
    {
        Operations.Add(operation);
        Console.WriteLine("Operation added");
    }
}
