using BookingSystemDataLayer;

namespace BookingSystemCreateDatabase
{
    class Program
    {
        private static void Main(string[] args)
        {
            bool result = BookingDBContext.CreateDatabase();

            if (result)
                Console.WriteLine("Success: Database was created.");
            else
                Console.WriteLine("Error: Database already exists.");

            Console.Read();
        }
    }
}