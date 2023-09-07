namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AirportDbContext db = new();
            var country = db.Countries;
            Console.WriteLine("Countries:");
            foreach (var i in country)
            {
                Console.WriteLine($"[{i.Id}] Name:{i.Name}");
            }
        }
    }
}