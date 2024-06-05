using PersonManagerApp.DataClasses;

namespace PersonManagerApp;

class PersonManager
{
    private readonly PersonRepository _repository;

    public PersonManager()
    {
        _repository = new PersonRepository();
    }

    //public Person Copy(Person person)
    //{
    //    return person;
    //}

    public IQueryable<Person> GetAllAdults()
    {
        var adults = _repository
            .Query()
            .Where(p => p.Age >= 18);
        return adults;
    }

    public IQueryable<Person> GetAllChildren()
    {
        var children = _repository
            .Query()
            .Where(p => p.Age < 18);
        return children;
    }
}