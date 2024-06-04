using System.Security.Principal;

namespace PersonManagerApp
{
    internal class Program
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
