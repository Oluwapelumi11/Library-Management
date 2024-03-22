using Library_Management.Models;
using Library_Management.Interfaces;
using Library_Management.Models.Factories;
namespace Library_Management
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            User admin = UserFactory.CreateUser("administrator");

            admin.Name = "Faith";

            Console.WriteLine(admin.Name);
            
           
            
        }

        
    }
}