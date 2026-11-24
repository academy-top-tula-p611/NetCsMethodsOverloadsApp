using System.Net.Http.Headers;

namespace NetCsMethodsOverloadsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 45;
            int b = 28;
            Console.WriteLine(Sum(a, b));
            Console.WriteLine(Sum(34.56, 67.21));
            Console.WriteLine(Sum(b, 53, a));
        }

        static int Sum(int left, int right)
        {
            Console.WriteLine("Integer Sum");
            return left + right;
        }
        static double Sum(double left, double right)
        {
            Console.WriteLine("Double Sum");
            return left + right;
        }
        static int Sum(int one, int two, int three)
        {
            Console.WriteLine("Integer Triple Sum");
            return one + two + three;
        }

    }
}
