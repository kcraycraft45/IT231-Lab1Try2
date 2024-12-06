namespace Try2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Gimme a number! ");
            int x = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Anotha one ");
            int y = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Thank you");
            DoMath(x, y);
            DoMath(x, y);
        }

        public static void DoMath(int x, int y)
        {
            int z = x + y;
            Console.WriteLine($"{x} + {y} = {z}";
        }
        public static void DoMath2(int x, int y)
        {
            int z = x * y;
            Console.WriteLine($"{x} * {y} = {z}");
        }
    }
}

