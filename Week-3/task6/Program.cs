using System;

namespace task6
{
    public class ErrorHandling
    {
        public void HandleNumberInput()
        {
            try
            {
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You entered: " + number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format.");
            }
            finally
            {
                Console.WriteLine("Program Executed.\n");
            }
        }

        public void ValidatePassword()
        {
            try
            {
                Console.Write("Enter your password: ");
                string password = Console.ReadLine();

                if (string.IsNullOrEmpty(password) || password.Length < 6)
                {
                    throw new Exception("Password must be at least 6 characters.");
                }

                Console.WriteLine("Password satisfied the requirement.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program Executed.");
            }
        }
    }
}
