using System;

namespace OOKP_Lab1._1
{
    class Person
    {
        public string name; 
        public int age;     

        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person Misha = new Person();
            Misha.name = "Misha";
            Misha.age = 18;
            Misha.GetInfo();

            Person Sam = new Person();
            Sam.name = "Sam";
            Sam.age = 25;
            Sam.GetInfo();
            
        }
    }
}

