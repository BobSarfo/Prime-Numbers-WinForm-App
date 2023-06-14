using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;

namespace PrimeNumbersApp
{
    public class MathUtils
    {

        [DllImport("C:\\Users\\Bob\\Desktop\\Projects\\Study\\C++\\PrimeNumbersApp\\x64\\Debug\\ExternMathUtilities.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int addTwoNumber(int a, int b);
        public static IEnumerable<int> GeneratePrimeNumbers(int N)
        {
            for (int i = 2; i <= N; i++)
            {
                if (IsPrime(i))
                    yield return i;
            }
        }

        static bool IsPrime(int number) 
        {
            if (number < 2)
                return false;
            for (int i = 2; i*i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }



        //For the initial test
        public static string FindCountOfNumbers(int[] arr)
        {
            StringBuilder sb = new StringBuilder();

            int[] numbers = new int[arr.Length];
            int[] counts = new int[arr.Length];

            int currentPosition = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int number = arr[i];
                int numberCount = 0;
                if (number == -1) continue;
                for (int j = i; j < arr.Length; j++)
                {
                    if (number == arr[j] && arr[j] != -1)
                    {
                        numberCount++;
                        arr[j] = -1;
                    }
                }
                numbers[currentPosition] = number;
                counts[currentPosition] = numberCount;
                currentPosition++;
                sb.Append($"{number} : {numberCount} , \n");
            }
            return sb.ToString();
        }
    }

}
