using System;

namespace OOKP_Lab1._1
{
    class Person
    {
        public string name; 
        public int age;
        public string hobby;
        public Person(string n, int a)
        {
            name = n;
            age = a;
            GetInfo();
            Hobby();
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name: {name}  Age: {age}");
        }
        public void Hobby()
        {
            Console.WriteLine($"Whats your hobby?");
            hobby = Console.ReadLine();
            Console.WriteLine($"Your hobby is {hobby}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person Misha = new Person("Misha", 18);

            Person Sam = new Person("Sam", 25);
        }
    }
}


