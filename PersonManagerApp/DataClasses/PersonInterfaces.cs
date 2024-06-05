namespace PersonManagerApp.DataClasses
{
    public interface IPersonRepository
    {
        IQueryable<Person> Query();
    }

    public interface IPersonManager
    {
        IQueryable<Person> GetAllAdults();
        IQueryable<Person> GetAllChildren();
    }

    public interface IPersonParser
    {
        Person Parse(string csvDataLine);
    }

    public interface IFileReader
    {
        IEnumerable<string> ReadAllLines(string path);
    }
}
