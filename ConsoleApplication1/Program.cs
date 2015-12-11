using System;
namespace _04___Magic_Car_Numbers
{
    class Program
    {
        private static int LettersWeight(char letter)
        {
            int sum = 0;
            switch (letter)
            {
                case 'A': sum += 10; break;
                case 'B': sum += 20; break;
                case 'C': sum += 30; break;
                case 'E': sum += 50; break;
                case 'H': sum += 80; break;
                case 'K': sum += 110; break;
                case 'M': sum += 130; break;
                case 'P': sum += 160; break;
                case 'T': sum += 200; break;
                case 'X': sum += 240; break;
            }
            return sum;
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;
            char[] nums = { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };
            for (int a = 0; a < 10; a++)
            {
                for (int b = 0; b < 10; b++)
                {
                    for (int c = 0; c < 10; c++)
                    {
                        for (int d = 0; d < 10; d++)
                        {
                            for (int e = 0; e < 10; e++)
                            {
                                char x = nums[e];
                                for (int f = 0; f < 10; f++)
                                {
                                    char y = nums[f];
                                    if ((a == b && b == c & c == d) ||
                                        (a == b & c == d & a != c) ||
                                        (a != b & b == c & c == d) ||
                                        (a == b & b == c & c != d) ||
                                        (a == c & b == d & a != d) ||
                                        (a != b & b == c & a == d))
                                    {
                                        sum = (a + b + c + d + (LettersWeight(x) + LettersWeight(y) + 40));
                                        if (sum == n)
                                        {
                                            counter++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}