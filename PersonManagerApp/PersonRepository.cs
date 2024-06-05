using PersonManagerApp.DataClasses;

namespace PersonManagerApp;

class PersonRepository : IPersonRepository
{
    private readonly IFileReader _ireader;
    private readonly IPersonParser _iparser;

    public PersonRepository(IFileReader ireader, IPersonParser iparser)
    {
        _ireader = ireader;
        _iparser = iparser;
    }

    public IQueryable<Person> Query()
    {
        var csvLines = _ireader.ReadAllLines("data.csv");
        var persons = csvLines.Select(line => _iparser.Parse(line));
        return persons.AsQueryable();
    }
}