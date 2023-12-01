using Helpers;
using SamuraiDB.Data;

namespace SamuraiDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            DataAccess dataAccess = new DataAccess();

            dataAccess.Seed();
            Console.WriteLine("Finished");
            Console.ReadLine();
        }
    }
}