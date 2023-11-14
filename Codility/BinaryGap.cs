// https://app.codility.com/programmers/lessons/1-iterations/binary_gap/

using System.ComponentModel.DataAnnotations;
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

    public static int[] CountBinaryGap(long binaryNumber)
    {
        int result = 0;
        bool headFlag = false;
        int count = 0;
        int max = 0;

        while (binaryNumber > 0)
        {
            long check = binaryNumber % 10;
            if (check == 1)
            {
                if (headFlag)
                {
                    result+=1;
                    if(max < count)
                    {
                        max = count;
                    }
                    count = 0;
                }
                else
                {
                    headFlag = true;
                }
            } 
            else
            {
                count++;
            }
            binaryNumber /= 10;
        }
        int[] finalResult = {result, max};
        return finalResult;
    }

    public static void Main(string[] args)
    {
        int fisrtNumber = 1041; // use number that in the value range of long when convert to binary
        long binaryNumber = BinaryGap.ConvertToBinary(fisrtNumber);
        Console.WriteLine(binaryNumber);
        int[] numberOfGap = BinaryGap.CountBinaryGap(binaryNumber);
        Console.WriteLine(string.Format("Number of Gap: {0}", numberOfGap[0]));
        Console.WriteLine(string.Format("Max length of Gap: {0}", numberOfGap[1]));
    }
}

