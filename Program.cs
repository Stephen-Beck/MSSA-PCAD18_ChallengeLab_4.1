/*
"If number contains 3"

Write a method that checks if given number (positive integer) contains digit 3. 
Do not convert number to other type. Do not use built-in functions like Contains(), StartsWith(), etc.

Expected input and output:
    IfNumberContains3(7201432) → true IfNumberContains3(87501) → false
*/

namespace ChallengeLab_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int testNum = 7201432;
            Console.WriteLine($"[{testNum}] contains 3: "+DoesNumberContain3(testNum));

            testNum = 87501;
            Console.WriteLine($"[{testNum}] contains 3: " + DoesNumberContain3(testNum));

            testNum = 87503;
            Console.WriteLine($"[{testNum}] contains 3: " + DoesNumberContain3(testNum));
        }

        static bool DoesNumberContain3(int num)
        {
            while (num > 0)
            {
                if (num % 10 == 3)
                    return true;
                num /= 10;
            }
            return false;
        }
    }
}
