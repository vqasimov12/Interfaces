using ConsoleApp2.Interfaces;

namespace ConsoleApp2.Moduls;

internal class Operation:IGuid
{
    public string ProcessName { get; set; }
    public DateTime Time { get; set; }
    public Guid Id { get; set; }
    public Operation(string process,DateTime time)
    {
        Time = time;
        ProcessName = process;
        Id = Guid.NewGuid();
    }
}
