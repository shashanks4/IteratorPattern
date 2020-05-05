using System;

namespace EmployeeIterator.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteCollection collection = new ConcreteCollection();
            collection.AddEmployee(new Employee("Shashank", 100));
            collection.AddEmployee(new Employee("John", 101));
            collection.AddEmployee(new Employee("UnderTaker", 102));
            collection.AddEmployee(new Employee("Roman Reigns", 103));
            collection.AddEmployee(new Employee("Seth Rollins", 104));
            collection.AddEmployee(new Employee("Steve Austin", 105));
            
            // Create iterator
            Iterator iterator = collection.CreateIterator();
            //looping iterator      
            Console.WriteLine("Iterating over collection:");
            
            for (Employee emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
            {
                Console.WriteLine($"ID : {emp.ID} & Name : {emp.Name}");
            }
        }
    }
}
