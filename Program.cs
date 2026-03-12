using System;
using ZooManagement.Entity;

namespace ZooManagement
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Hello");
            Animals a = new Animals();

            a.AnimalID = 2;
            a.AnimalName = "Lion";
            a.AnimalType = "Mammals";
            a.showAnimal();
        }
    }
}