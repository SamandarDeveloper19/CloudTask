namespace CloudTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConvertToBinary();
            Console.ReadKey();
        }

        static void ConvertToBinary()
        {
            Console.Write("10-lik sanoq sistemasidagi sonni kiriting: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
                Console.WriteLine("0");

            string binary = "";

            while (number > 0)
            {
                int remainder = number % 2;
                binary = remainder + binary;
                number /= 2;
            }

            Console.WriteLine($"2-lik sanoq sistemasida: {binary}");
        }
    }
}
