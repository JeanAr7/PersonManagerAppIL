namespace PersonManagerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var persons = File.ReadAllLines("data.csv")
                .Select(l => l.Split(","))
                .Select(p => new Person
                {
                    Id = int.Parse(p[0]),
                    Name = p[1],
                    Age = int.Parse(p[2]),
                })
                .ToList();

            var adults = persons.Where(p => p.Age >= 18).ToList();
            Console.WriteLine($"### ADULTS ({adults.Count}) ###");
            adults.ForEach(a => Console.WriteLine(a.Name));


            var children = persons.Where(p => p.Age < 18).ToList();
            Console.WriteLine($"### CHILDREN ({children.Count}) ###");
            children.ForEach(c => Console.WriteLine(c.Name));
        }
    }
}
