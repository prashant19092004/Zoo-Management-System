

using ZooManagement.BAL.DTOs;
using ZooManagement.BAL.Interfaces;
using ZooManagement.BAL.Services;
using ZooManagement.DAL.Entities;
using ZooManagement.DAL.Interfaces;
using ZooManagement.Shared;

namespace ZooManagement.Presentation.Pages
{
    public static class VisitorPage
    {

        public static void VisitorMenu(IVisitorService? visitorService, IAttractionService? attractionService, IAnimalService? animalService)
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
                        if(visitorService != null)
                        {
                            Console.WriteLine("Register");
                            Console.Write("Enter Visitor Name: ");
                            string name = Console.ReadLine() ?? string.Empty;

                            Console.Write("Enter Visitor Age: ");
                            int age = Convert.ToInt32(Console.ReadLine() ?? "0");

                            Console.Write("Enter Visitor Balance: ");
                            decimal balance = Convert.ToDecimal(Console.ReadLine() ?? "0");

                            Console.Write("Enter Visitor Phone Number: ");
                            long phone = Convert.ToInt64(Console.ReadLine() ?? "0");

                            Console.Write("Enter Visitor Email: ");
                            string email = Console.ReadLine() ?? string.Empty;

                            Console.Write("Enter Visitor Password: ");
                            string password = Console.ReadLine() ?? string.Empty;

                            var visitor = new VisitorDto
                            {
                                Name = name,
                                Age = age,
                                Balance = balance,
                                Phone = phone,
                                Email = email,
                                Password = password
                            };

                            visitorService.RegisterVisitor(visitor);
                            Console.WriteLine("Visitor Registered✅");
                        }
                        else
                        {
                            Console.WriteLine("Visitor service is not available.");
                        }

                        break;
                    
                    case(2):
                        if(visitorService != null)
                        {
                            bool status = true;
                            while (status)
                            {
                                Console.Write("Enter Visitor Email: ");
                                string email = Console.ReadLine() ?? string.Empty;

                                Console.Write("Enter Visitor Password: ");
                                string password = Console.ReadLine() ?? string.Empty;

                                var visitor = visitorService.LoginVisitor(email, password);

                                if(visitor != null)
                                {
                                    Console.WriteLine("User login successful✅");
                                    Data.CurrrentUser = visitor.Id;
                                    VisitorMainMenu(visitorService, attractionService, animalService);
                                    status = false;
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect Password! Please try again");
                                }
                            } 
                        }
                        else
                        {
                            Console.WriteLine("Visitor service is not available");
                        }
                        break;

                    case(3):
                        return;
                    
                    default:
                        Console.WriteLine("Please enter a valid choice.");
                        break;
                }   

            }
        }
    
        public static void VisitorMainMenu(IVisitorService? visitorService, IAttractionService? attractionService, IAnimalService? animalService)
        {
            while(true)
            {
                Console.WriteLine("\nVisitor Menu\n");
                Console.WriteLine("1. Explore the Zoo");
                Console.WriteLine("2. Buy Membership");
                Console.WriteLine("3. Buy Tickets");
                Console.WriteLine("4. View Discounts");
                Console.WriteLine("5. View Special Deals");
                Console.WriteLine("6. Visit Animals");
                Console.WriteLine("7. Visit Attractions");
                Console.WriteLine("8. Leave Feedback");
                Console.WriteLine("9. Log Out\n");

                Console.Write("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case(1): 
                        bool status = true;
                        while (status)
                        {
                            Console.WriteLine("\nExplore the zoo\n");
                            Console.WriteLine("1. View Attractions");
                            Console.WriteLine("2. View Animals");
                            Console.WriteLine("3. Exit");

                            Console.Write("Enter your choice : ");
                            int choice1 = Convert.ToInt32(Console.ReadLine());

                            switch (choice1)
                            {
                                case(1):
                                    ViewAttraction(attractionService);
                                    break;
                                case(2):
                                    ViewAnimals(animalService);
                                    break;
                                case(3):
                                    status = false;
                                    break;
                                default:
                                    Console.WriteLine("Please enter a valid choice");
                                    break;
                            }
                        }
                        break;
                    
                    case(2):
                        bool status1 = true;
                        while (status1)
                        {
                            Console.WriteLine("\nBuy Membership:\n");
                            Console.WriteLine("1. Basic Membership (₹20)");
                            Console.WriteLine("2. Premium Membership (₹50)");
                            Console.WriteLine("3. Exit");

                            Console.Write("Enter your choice : ");
                            int choice1 = Convert.ToInt32(Console.ReadLine());

                            switch (choice1)
                            {
                                case(1):
                                    BuyMembership(Memberships.Basic , visitorService);
                                    break;
                                case(2):
                                    BuyMembership(Memberships.Premium , visitorService);
                                    break;
                                case(3):
                                    status1 = false;
                                    break;
                                default:
                                    Console.WriteLine("Please enter a valid choice");
                                    break;
                            }
                        }
                        break;

                    case(3):
                        Console.WriteLine("Buy Ticket");
                        break;
                    
                    case(4): 
                        Console.WriteLine("View Discount");
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
                        Console.WriteLine("View Feedback");
                        break;

                    case(9):
                        Console.WriteLine("Logged out");
                        return;
                    
                    default:
                        Console.WriteLine("Please enter a valid choice.");
                        break;
                }   

            }
        }
    
        public static void ViewAttraction(IAttractionService? attractionService)
        {
            List<AttractionDto> attractions;
            if(attractionService != null)
            {
                attractions = attractionService.GetAttractions();
            }
            else
            {
                Console.WriteLine("Service is not available");
                return;
            }
            while(true)
            {
                Console.WriteLine("\nAttractions in the Zoo:");
                for(int i=0; i<attractions.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {attractions[i].Name}");
                }
                Console.WriteLine($"{attractions.Count+1}. Exit");

                Console.Write("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if(choice > 0 && choice <= attractions.Count)
                {
                    Console.WriteLine($"{attractions[choice-1].Description} Buy your ticket now!");
                    return;
                }else if (choice == attractions.Count+1)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }
        }

        public static void ViewAnimals(IAnimalService? animalService)
        {
            List<AnimalDto> animals;
            if(animalService != null)
            {
                animals = animalService.GetAnimals();
            }
            else
            {
                Console.WriteLine("Service is not available");
                    return;
            }
            
            Console.WriteLine("\nAnimals in the Zoo:");
            for(int i=0; i<animals.Count; i++)
            {
                Console.WriteLine($"{i+1}. {animals[i].Name}");
            }
        }

        public static void BuyMembership(Memberships type, IVisitorService? visitorService)
        {
            var visitor =  visitorService?.GetVisitor(Data.CurrrentUser ?? 0);
            
            if(visitor == null)
            {
                Console.WriteLine("Something went wrong");
                return;
            }
            
            int price = type == Memberships.Basic ? 20 : 50;
            if(visitor.Balance < price)
            {
                Console.WriteLine("Insufficient Balance");
                return;
            }

            if(visitorService != null && visitorService.BuyMembership(type, visitor.Id))
            {
                Console.WriteLine($"{type} Membership purchased successfully. Your balance is now ₹{visitor.Balance - price}.");
            }
            else
            {
                Console.WriteLine("Something Went wrong");
            }

            
        }
    }
}