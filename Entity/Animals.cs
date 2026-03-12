using System;

namespace ZooManagement.Entity
{
    class Animals
    {
        public int AnimalID{ get; set; }
        public string AnimalName{ get; set; }
        public string AnimalType{ get; set; }

        public void showAnimal()
        {
            Console.WriteLine($"id: {AnimalID}, name: {AnimalName}, type: {AnimalType}");
        }
    }
}