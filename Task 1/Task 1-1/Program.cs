namespace Task_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double a = 2;
            const double b = 3;
            const double c = 4;

            Console.Write("Введите x = ");
            string input = Console.ReadLine();

            double x = double.Parse(input);

            double y = ((a * Math.Abs(x * x * x - b) / Math.Sqrt(x * x + c)) + 3 / 4 * Math.Pow(Math.Sin(x), 2));

            Console.WriteLine($"x = {x}; y = {y} ");

        }
    } }
