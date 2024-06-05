using System.Security.Principal;
using PersonManagerApp.DataClasses;

namespace PersonManagerApp
{
    public class Program
    {
        private static PersonCommands _commands;

        static void Main(string[] args)
        {

            _commands = new PersonCommands();

            _commands.DisplayAllAdults();
            _commands.DisplayAllChildren();
        }
    }
}
