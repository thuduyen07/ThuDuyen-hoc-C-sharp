// https://app.codility.com/programmers/lessons/1-iterations/binary_gap/

using System.Linq;
using System.Runtime.ExceptionServices;

public class BinaryGap
{
    public static long ConvertToBinary(int number)
    {
        LinkedList<int> binaryNumber = new LinkedList<int>();
        int appendNumber = 0;
        while (number > 1)
        {
            appendNumber = number % 2;
            binaryNumber.AddLast(appendNumber);
            number /= 2;
        }
        appendNumber = number % 2;
        binaryNumber.AddLast(appendNumber);
        long result = 0;
        while (binaryNumber.Count() > 0)
        {
            appendNumber = binaryNumber.Last();
            result = result * 10 + appendNumber;
            binaryNumber.RemoveLast();
        }

        return result;
    }

    public static int CountBinaryGap(long binaryNumber)
    {
        int result = 0;
        bool headFlag = false;
        while (binaryNumber > 0)
        {
            long check = binaryNumber % 10;
            if (check == 1)
            {
                if (headFlag)
                {
                    result+=1;
                }
                else
                {
                    headFlag = true;
                }
            }
            binaryNumber /= 10;
        }
        return result;
    }

    public static void Main(string[] args)
    {
        int fisrtNumber = 1041; // use number that <1024 due to int range value
        long binaryNumber = BinaryGap.ConvertToBinary(fisrtNumber);
        Console.WriteLine(binaryNumber);
        int numberOfGap = BinaryGap.CountBinaryGap(binaryNumber);
        Console.WriteLine(numberOfGap);
    }
}

