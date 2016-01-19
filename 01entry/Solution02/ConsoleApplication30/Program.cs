using System;

namespace ConsoleApplication30
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var emp = new Employee(100, "よーぞー", 40);
            emp.DeptName = "海外事業部";

            Console.WriteLine("{0}({1:D2}) {2}所属", emp.Name, emp.Age, emp.DeptName);
            Console.ReadLine();
        }
    }


    internal class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }

    internal class Employee : Person
    {
        public Employee(int id, string name, int age) : base(name, age)
        {
            Id = id;
        }

        public int Id { get; set; }
        public string DeptName { get; set; }
    }
}