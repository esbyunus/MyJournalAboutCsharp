namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* --- Description ---
            We're creating a boolean variable. We'll use the 'success' boolean in a while loop. 
            We'll prompt the user for a 'numInput' input. We'll prevent using string instead of 
            integer with an 'if'. If the 'numInput' defined as a string at the beginning of the 
            loop receives input from the user as a string, the loop continues as 'true', and the 'else' part executes. 
            If it receives input as an integer, the 'if' part executes, and the bool becomes 'false'. 
            With TryParse, we can convert the integer input to an integer data without encountering an error. 
            */
            
            bool success = true;

            while (success)
            {
                Console.WriteLine("Enter a number: ");
                string numInput = Console.ReadLine();

                if (int.TryParse(numInput, out int num))
                {
                    success = false;
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine("Failed to convert! ");
                }
            }
        }
    }
}
