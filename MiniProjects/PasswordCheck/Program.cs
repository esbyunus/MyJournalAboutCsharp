namespace PassswordCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();

            Console.WriteLine("Enter password again: ");
            string passwordA =  Console.ReadLine() ;

            if ( !password.Equals(string.Empty) && !password.Equals(string.Empty))
            {
                if (password.Equals(passwordA))
                {
                    Console.WriteLine("Passwords match! ");
                }
                else
                {
                    Console.WriteLine("Passwords dont match!");
                }
            }
            else
            {
                Console.WriteLine("Enter a password please!");
            }
        }
    }
}