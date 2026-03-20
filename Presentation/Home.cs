using System;
using ZooManagement.DAL.Interfaces;
using ZooManagement.BAL.DTOs;
using ZooManagement.BAL.Interfaces;
using ZooManagement.BAL.Services;
using ZooManagement.DAL.Repositories;
using ZooManagement.Presentation.Pages;

namespace ZooManagement.Presentation
{
    public static class Home
    {
        public static void HomePage(IAnimalService? service)
        {
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
                        AdminPage.AdminMenu(service);
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
    }
}