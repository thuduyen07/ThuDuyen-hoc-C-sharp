// https://app.codility.com/programmers/lessons/2-arrays/cyclic_rotation/

class CyclicRotation
{
    public static int[] Solution(int[] A, int K)
    {
        int[] result = A;
        for (int i = 0; i < K; i++)
        {
            int temp = result.Last();
            for (int j = A.Count() - 2; j > -1; j--)
            {
                result[j + 1] = result[j];
            }
            result[0] = temp;
        }
        return result;
    }

    public static void Main(string[] args)
    {
        int[] A = { 1, 2, 3, 4 };
        int k = 2;
        int[] result = CyclicRotation.Solution(A, k);
        for (int i = 0; i < A.Count(); i++)
        {
            Console.WriteLine(result[i]);
        }
    }
}
