using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Password Generator!");

            // Prompt the user to enter the desired length of the password
            Console.Write("Enter the desired length of the password: ");
            int length = int.Parse(Console.ReadLine());

            // Generate the password
            string password = GeneratePassword(length);

            // Display the generated password
            Console.WriteLine("Generated password: " + password);
        }

        static string GeneratePassword(int length)
        {
            // Define the characters that can be used in the password
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()-=_+";

            // Create a random number generator
            Random random = new Random();

            // Generate the password
            char[] password = new char[length];
            for (int i = 0; i < length; i++)
            {
                password[i] = chars[random.Next(chars.Length)];
            }

            // Convert the character array to a string and return it
            return new string(password);
        }
    }
}
