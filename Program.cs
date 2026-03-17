using System;
using ZooManagement.Domain.Interfaces;
using ZooManagement.BAL.DTOs;
using ZooManagement.BAL.Interfaces;
using ZooManagement.BAL.Services;
using ZooManagement.DAL.Repositories;

namespace ZooManagement
{
    class Program
    {
        public static void Main(String[] args)
        {
            IAnimalRepository repository = new AnimalRepository();
            IAnimalService service = new AnimalService(repository);
            // Console.WriteLine("Hello");
            // Animal a = new Animal();

            // a.AnimalID = 2;
            // a.AnimalName = "Lion";
            // a.AnimalType = "Mammals";
            // a.showAnimal();

            while(true)
            {
                Console.WriteLine("\nWelcome to my zoo\n");
                Console.WriteLine("1. Enter as Admin");
                Console.WriteLine("2. Enter as a Visitor");
                Console.WriteLine("3. View Special Deals");
                Console.WriteLine("4. Exit\n");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case(1): 
                        adminMenu(service);
                        break;
                    
                    case(2):
                        Console.WriteLine("visitor login");
                        break;

                    case(3):
                        Console.WriteLine("speacial deal");
                        break;

                    case(4):
                        Console.WriteLine("Thank you for visiting our zoo");
                        Environment.Exit(0);
                        break;
                    
                    default:
                        Console.WriteLine("Please enter a valid choice.");
                        break;
                }   

            }
        }

        public static void adminMenu(IAnimalService service)
        {
            while(true)
            {
                Console.WriteLine("\nAdmin Menu\n");
                Console.WriteLine("1. Manage Attractions");
                Console.WriteLine("2. Manage Animals");
                Console.WriteLine("3. Schedule Events");
                Console.WriteLine("4. Set Discounts");
                Console.WriteLine("5. Set Special Deal");
                Console.WriteLine("6. View Visitor Stats");
                Console.WriteLine("7. View Feedback");
                Console.WriteLine("8. Exit\n");

                Console.Write("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case(1): 
                        manageAttributeMenu();
                        break;
                    
                    case(2):
                        manageAnimalMenu(service);
                        break;

                    case(3):
                        Console.WriteLine("Schedule Events");
                        break;
                    
                    case(4): 
                        setDiscountMenu();
                        break;
                    
                    case(5):
                        Console.WriteLine("Set Special Deal");
                        break;

                    case(6):
                        Console.WriteLine("View Visitor Stats");
                        break;
                    
                    case(7):
                        Console.WriteLine("View Feedback");
                        break;

                    case(8):
                        Console.WriteLine("Logged out");
                        return;
                    
                    default:
                        Console.WriteLine("Please enter a valid choice.");
                        break;
                }   

            }
        }

        public static void manageAttributeMenu()
        {
            while(true)
            {
                Console.WriteLine("\nAttribute Menu:");
                Console.WriteLine("1. Add Attraction");
                Console.WriteLine("2. View Attractions");
                Console.WriteLine("3. Modify Attraction");
                Console.WriteLine("4. Remove Attraction");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case(1): 
                        Console.WriteLine("Add Attraction");
                        break;
                    
                    case(2):
                        Console.WriteLine("View Attractions");
                        break;

                    case(3):
                        Console.WriteLine("Modify Attraction");
                        break;
                    
                    case(4): 
                        Console.WriteLine("Remove Attraction");
                        break;

                    case(5):
                        return;
                    
                    default:
                        Console.WriteLine("Please enter a valid choice.");
                        break;
                }   

            }
        }

        public static void manageAnimalMenu(IAnimalService service)
        {
            while(true)
            {
                Console.WriteLine("\nAnimal Menu:");
                Console.WriteLine("1. Add Animal");
                Console.WriteLine("2. Update Animal Details");
                Console.WriteLine("3. Remove Animal");
                Console.WriteLine("4. Show Animals");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case(1):
                        Console.Write("Enter Animal Name : ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Animal Type : ");
                        string type = Console.ReadLine();

                        var animal = new AnimalDto
                        {
                            Name = name,
                            Type = type
                        };

                        service.AddAnimal(animal);

                        Console.WriteLine("Animal Added✅");

                        break;
                    
                    case(2):
                        Console.WriteLine("Update Animal Details");
                        break;

                    case(3):
                        Console.WriteLine("Remove Animal");
                        break;

                    case(4):
                        var animals = service.GetAnimals();

                        Console.WriteLine("------ Animal List ------");

                        foreach (var a in animals)
                        {
                            Console.WriteLine($"{a.Id} - {a.Name} - {a.Type}");
                        }
                        break;
                    
                    case(5):
                        return;
                    
                    default:
                        Console.WriteLine("Please enter a valid choice.");
                        break;
                }   

            }
        }

        public static void setDiscountMenu()
        {
            while(true)
            {
                Console.WriteLine("\nSet Discount: ");
                Console.WriteLine("1. Add Discount");
                Console.WriteLine("2. Modify Discount");
                Console.WriteLine("3. Remove Discount");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case(1): 
                        Console.WriteLine("Add Discount");
                        break;
                    
                    case(2):
                        Console.WriteLine("Modify Discount");
                        break;

                    case(3):
                        Console.WriteLine("Remove Discount");
                        break;
                    
                    case(4):
                        return;
                    
                    default:
                        Console.WriteLine("Please enter a valid choice.");
                        break;
                }   

            }
        }

        public static void visitorAuthMenu()
        {
            while(true)
            {
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");

                Console.Write("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case(1): 
                        Console.WriteLine("Register");
                        break;
                    
                    case(2):
                        Console.WriteLine("Login");
                        break;

                    case(3):
                        return;
                    
                    default:
                        Console.WriteLine("Please enter a valid choice.");
                        break;
                }   

            }
        }
    }
}