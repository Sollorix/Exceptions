namespace Exceptions_Babcock_Olivia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Defines float values
            float myFloat = 65.4f;
            float myOtherFloat = 0.0f;
            float result = 0f;

            // Defines Random and myInt
            Random rand = new Random();
            int myInt = rand.Next(2, 30);

            // Defines try...catch exceptions and conditions
            try
            {   
                // Gives quotient
                result = Divide(myFloat, myOtherFloat);
            }
            catch (Exception e)
            {
                // Prints to the console
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter a number other than zero.");

                try
                {
                    // Prints to the console and converts float value.
                    myOtherFloat = (float)Convert.ToDouble(Console.ReadLine());
                    // Gives quotient
                    result = Divide(myFloat, myOtherFloat);
                }
                catch (Exception e2)
                {
                    // Prints to the console
                    Console.WriteLine(e2.Message);
                }

            }
            finally
            {   
                // Prints to the console.
                Console.WriteLine("Calculations completed with a result of " + result);
            }

            try
            {
                // Checks for user age.
                CheckAge(myInt);
            }catch
            {
                // Prints to the console.
                Console.WriteLine($"You are {myInt}, you are not old enough!");
            }
        }
        /// <summary>
        /// Defines float values and if and else statement. Throws exception when the "if" statement is fufilled.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// <exception cref="DivideByZeroException"></exception>
        static float Divide(float x, float y)
        {
            if(y == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return x / y;
            }
        }
        /// <summary>
        /// Defines if and else statement and throws an exception when the "if" statement isn't fufilled.
        /// </summary>
        /// <param name="age"></param>
        /// <exception cref="ArgumentException"></exception>
        static void CheckAge(int age)
        {
            if(age >= 17)
            {
                Console.WriteLine($"You are {age}, you can play mature games!");
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}