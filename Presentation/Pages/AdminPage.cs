using System;
using ZooManagement.DAL.Interfaces;
using ZooManagement.BAL.DTOs;
using ZooManagement.BAL.Interfaces;
using ZooManagement.BAL.Services;
using ZooManagement.DAL.Repositories;
using ZooManagement.DAL.Entities;

namespace ZooManagement.Presentation.Pages
{
    public static class AdminPage
    {
        public static void AdminMenu(IAnimalService? animalService, IAttractionService? attractionService)
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
                        manageAttractionMenu(attractionService);
                        break;
                    
                    case(2):
                        manageAnimalMenu(animalService);
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

        public static void manageAttractionMenu(IAttractionService? attractionService)
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
                        if(attractionService != null)
                        {
                            Console.Write("Enter Attraction Name : ");
                            string name = Console.ReadLine() ?? string.Empty;

                            Console.Write("Enter Attraction Description : ");
                            string description = Console.ReadLine() ?? string.Empty;

                            Console.Write("Enter Attraction Price : ");
                            int price = Convert.ToInt32(Console.ReadLine() ?? "0");

                            var attraction = new AttractionDto
                            {
                                Name = name,
                                Description = description,
                                Price = price
                            };

                            attractionService.AddAttraction(attraction);
                            Console.WriteLine("Attraction added✅");
                        }   
                        else
                        {
                            Console.WriteLine("Attraction Service is not available");
                        }
                        break;
                    
                    case(2):
                        if(attractionService != null)
                        {
                            var attractions = attractionService.GetAttractions();

                            Console.WriteLine("------------Attractions--------------");

                            foreach(var attraction in attractions)
                            {
                                Console.WriteLine($"{attraction.Name} - {attraction.Description} - {attraction.Price}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Attraction service is not available.");
                        }
                        break;

                    case(3):
                        if(attractionService != null)
                        {
                            Console.Write("Enter the Attraction Id : ");
                            int id = Convert.ToInt32(Console.ReadLine() ?? "0");

                            Console.Write("Enter the Attraction Name : ");
                            string name = Console.ReadLine() ?? string.Empty;

                            Console.Write("Enter the Description : ");
                            string description = Console.ReadLine() ?? string.Empty;

                            Console.Write("Enter the Attraction Price : ");
                            int price = Convert.ToInt32(Console.ReadLine() ?? "0");

                            var attraction = new AttractionDto
                            {
                              Id = id,
                              Name = name,
                              Description = description,
                              Price = price  
                            };

                            attractionService.UpdateAttraction(attraction);
                            Console.WriteLine("Attraction is updated.");
                        }
                        else
                        {
                            Console.WriteLine("Attraction service is not available.");
                        }
                        break;
                    
                    case(4): 
                        if(attractionService != null)
                        {
                            Console.Write("Enter the Attraction Id : ");
                            int id = Convert.ToInt32(Console.ReadLine() ?? "0");

                            attractionService.DeleteAttraction(id);
                            Console.WriteLine("Attraction is deleted.");
                        }
                        else
                        {
                            Console.WriteLine("Remove Attraction");
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

        public static void manageAnimalMenu(IAnimalService? animalService)
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
                        if (animalService != null)
                        {
                            Console.Write("Enter Animal Name : ");
                            string name = Console.ReadLine() ?? string.Empty;
                            Console.Write("Enter Animal Type : ");
                            string type = Console.ReadLine() ?? string.Empty;

                            var animal = new AnimalDto
                            {
                                Name = name,
                                Type = type
                            };

                            animalService.AddAnimal(animal);
                            Console.WriteLine("Animal Added✅");
                        }
                        else
                        {
                            Console.WriteLine("Service is not available.");
                        }

                        break;
                    
                    case(2):
                        if(animalService != null)
                        {
                            Console.Write("Enter the animal id : ");
                            int id = Convert.ToInt32(Console.ReadLine() ?? "0");

                            Console.Write("Enter Animal Name : ");
                            string updatedName = Console.ReadLine() ?? string.Empty;

                            Console.Write("Enter Animal Type : ");
                            string updatedType = Console.ReadLine() ?? string.Empty;

                            var updatedAnimal = new AnimalDto
                            {
                                Id = id,
                                Name = updatedName,
                                Type = updatedType
                            };

                            animalService.UpdateAnimal(updatedAnimal);
                            Console.WriteLine("Animal Updated..✅");
                        }
                        else
                        {
                            Console.WriteLine("Service is not available");
                        }

                        
                        break;

                    case(3):
                        Console.Write("Enter the Id : ");
                        int removeId = Convert.ToInt32(Console.ReadLine() ?? "0");

                        if(removeId > 0)
                        {
                            animalService?.DeleteAnimal(removeId);
                            Console.WriteLine("Animal Deleted..✅");
                        }
                        else
                        {
                            Console.WriteLine("Enter Valid Id.");
                        }
                        break;

                    case(4):
                    
                        if (animalService != null)
                        {
                            var animals = animalService.GetAnimals();

                            Console.WriteLine("------ Animal List ------");

                            foreach (var a in animals)
                            {
                                Console.WriteLine($"{a.Id} - {a.Name} - {a.Type}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Service is not available.");
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
    }
}