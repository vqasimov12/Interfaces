
using ConsoleApp2.Interfaces;

namespace ConsoleApp2.Moduls;
public class Person:IGuid
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }
    public Person(string _name, string _surname,  int _age, double _salary)
    {
        Id = Guid.NewGuid();
        Name = _name;
        Surname = _surname;
       
        Age = _age;
        Salary = _salary;
    }


}
