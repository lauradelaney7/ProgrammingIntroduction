namespace Assignment1_S19
{
    class Program
    {
        static void Main(string[] args) // intro: defining the objects
        {
            Console.WriteLine("Author Laura Delaney");
            Console.WriteLine();

            printPrimeNumbers(3, 15); // part 1
            Console.WriteLine();

            Convert.ToDouble(Console.ReadLine(getSeriesResult(3))); // part 2
            Console.WriteLine();

            printTriangle(7); // part 3
            Console.WriteLine();

            int[] a = { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(a); // part 4 
            Console.WriteLine();
        }

        public static void printPrimeNumbers(int x, int y) // part 1: printing prime numbers between 3 and 15
        {
            isPrime(x); // 3 is prime
            isPrime(y); // 15 isn't prime
        }

        public static double getSeriesResult(int n) // part 2: defining the factorial, 3 decimal places, double
        {
            double n = Math.Round(n, 3);
            int functiona;
            int functionb;
            int functionc;

            for // 1st loop 

                    (int t = 1; t <= n; t++)
            {
                functionb = 1; for (int k = 1; k <= t; k++) // 2nd loop
                {
                    functiona = functiona * t;
                }

                functionc = functionb / (t + 1); // denominator initiated by loop
            }
            return functiona;
        }

        public static void printTriangle(int n) // part 3: printing triangles using * to define the lines
        {
            int number = 7; // establishing that I want 7 lines

            for

                (int n = number; n >= 1; n -= 2)

            {
                string spaces = new String(' ', (number - n) / 2);
                Console.WriteLine(spaces + new String('*', n) + spaces);
            }
        }

        public static void computeFrequency(int[] a) // part 4: reiterates the frequency of each number a
        {
            int[] a = { 1, 2, 3, 2, 2, 1, 3, 2 };
            int n = a.Length;
            int t = 3;

            Console.Write(countOccurrences(a, n, t));
        }
    }
}
