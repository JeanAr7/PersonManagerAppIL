namespace PersonManagerApp;

internal class PersonCommands
{
    private IPersonManager _imanager;
    public PersonCommands(IPersonManager imanager)
    {
        _imanager = imanager;
    }

    public void DisplayAllAdults()
    {
        var adults = _imanager.GetAllAdults().ToList();
        Console.WriteLine($"### ADULTS ({adults.Count}) ###");
        adults.ForEach(a => Console.WriteLine(a.Name));
    }

    public void DisplayAllChildren()
    {
        var children = _imanager.GetAllChildren().ToList();
        Console.WriteLine($"### CHILDREN ({children.Count}) ###");
        children.ForEach(c => Console.WriteLine(c.Name));
    }
}