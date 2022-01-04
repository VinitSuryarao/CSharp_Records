using System;

namespace InitOnly
{
    public record Company
    {
        public int ID { get; init; } 
        public string Name { get; init; }
        public string City { get; init; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Company obj = new Company
            {
                ID = 1, 
                Name = "ABC", 
                City = "Mumbai"
            }; // Set value only when object creation

            Console.WriteLine(obj.ID.ToString()+" "+obj.Name+" "+obj.City);
            Console.ReadLine();
        }
    }
}
