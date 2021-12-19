using System;

namespace MethodExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string userFavoriteColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string userFavoriteAnimal = Console.ReadLine();

            Console.WriteLine("Who is your favorite band?");
            string userFavoriteBand = Console.ReadLine();

            Console.WriteLine($"There was a person named {userName} who absolutely loved the color {userFavoriteColor}.");
            Console.WriteLine($"They loved all animals but especially the {userFavoriteAnimal} as well as any song written by {userFavoriteBand}");

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a second number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2, 2, 3, 5, 7);
            Console.WriteLine($"The sum is: {sum}");

            Console.WriteLine("Give me a number to multiply");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a second number to multiply to first the first one");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The product is: {product}");

            Console.WriteLine("Give me a number to divide");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a second number to divided the first one by");
            num2 = int.Parse(Console.ReadLine());

            int quotient = Divide(num1, num2);
            Console.WriteLine($"The quotient is: {quotient}");

            Console.WriteLine("Give me a number to subtract");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a second number to subtract the first one from");
            num2 = int.Parse(Console.ReadLine());

            int difference = Subtract(num1, num2);
            Console.WriteLine($"The difference is: {difference}");

        }    

        public static int Sum(params int[] list)
        {
            int sum = 0;

            for(int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }

            return sum;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Divide(int x, int y)
        { 
            return x / y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;   
        }
        
    }
}
