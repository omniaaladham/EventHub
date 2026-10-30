namespace EventHub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new EventHubContext())
            {
                context.Database.EnsureCreated();

                Console.WriteLine("EventHub database created successfully!");

                Console.WriteLine(
                    $"Database can connect: {context.Database.CanConnect()}");
            }
        }
    }
}