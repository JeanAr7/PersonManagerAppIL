using PersonManagerApp.DataClasses;

namespace PersonManagerApp;

class PersonManager : IPersonManager
{
    private readonly IPersonRepository _irepository;

    public PersonManager(IPersonRepository irepository)
    {
        _irepository = irepository;
    }

    public IQueryable<Person> GetAllAdults()
    {
        var adults = _irepository
            .Query()
            .Where(p => p.Age >= 18);
        return adults;
    }

    public IQueryable<Person> GetAllChildren()
    {
        var children = _irepository
            .Query()
            .Where(p => p.Age < 18);
        return children;
    }
}