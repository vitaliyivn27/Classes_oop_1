
namespace Oop_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter double number :");
            var isDouble = double.TryParse(Console.ReadLine(), out double num);
            if (isDouble)
            {
                Fractions firstNumber = new Fractions(num);
                Console.WriteLine($"Your number : {num}");
                Console.WriteLine(new Fractions(num).ToString());
                Console.WriteLine(new Fractions(num).Operations());
            }
            else
            {
                Console.WriteLine("Wrong value");
            }
            
        }
    }
}