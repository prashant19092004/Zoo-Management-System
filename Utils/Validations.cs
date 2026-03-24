using System;

namespace ZooManagement.Utils
{
    public static class Validations
    {
        public static bool AdminAuth(string username, string password)
        {
            string admin = "admin";
            string adminPassword = "password";

            if(admin == username && password == adminPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}