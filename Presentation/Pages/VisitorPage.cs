

namespace ZooManagement.Presentation.Pages
{
    public static class VisitorPage
    {
        public static void VisitorMenu()
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