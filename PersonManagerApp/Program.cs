using System.Security.Principal;
using PersonManagerApp.DataClasses;

namespace PersonManagerApp
{
    public class Program
    {
        private static PersonCommands _commands;

        static void Main(string[] args)
        {
            IFileReader fileReader = new FileReader();
            IPersonParser personParser = new PersonParser();
            IPersonRepository personRepository = new PersonRepository(fileReader, personParser);
            IPersonManager personManager = new PersonManager(personRepository);
            
            _commands = new PersonCommands(personManager);

            _commands.DisplayAllAdults();
            _commands.DisplayAllChildren();
        }
    }
}
