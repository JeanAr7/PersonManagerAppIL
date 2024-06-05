using PersonManagerApp.DataClasses;

namespace PersonManagerApp;

class PersonRepository
{
    private readonly FileReader _reader;
    private readonly PersonParser _parser;

    public PersonRepository()
    {
        _reader = new FileReader();
        _parser = new PersonParser();

        var utilities = new PersonUtilities();
    }

    public object Create()
    {
        return new object();
    }
    public IQueryable<Person> Query()
    {
        var csvLines = _reader.ReadAllLines("data.csv");
        var persons = csvLines.Select(line => _parser.Parse(line));
        return persons.AsQueryable();
    }
}

class PersonUtilities
{
    public void Foo(){}
}