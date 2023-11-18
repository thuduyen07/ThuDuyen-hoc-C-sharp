// This is a demo task.

// Write a function:

// class Solution { public int solution(int[] A); }

// that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.

// For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.

// Given A = [1, 2, 3], the function should return 4.

// Given A = [−1, −3], the function should return 1.

// Write an efficient algorithm for the following assumptions:

// N is an integer within the range [1..100,000];
// each element of array A is an integer within the range [−1,000,000..1,000,000].

using System;
using System.Net;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {

    public int[] mergeSort(int[] A){
        int[] left;
        int[] right;
        int[] result = new int[A.Length];
        if (A.Length <= 1)
            return A;              
        int midPoint = A.Length / 2;  
        left = new int[midPoint];

        if (A.Length % 2 == 0)
            right = new int[midPoint];  
        else
            right = new int[midPoint + 1];  

        for (int i = 0; i < midPoint; i++)
            left[i] = A[i];  

        int x = 0;

        for (int i = midPoint; i < A.Length; i++)
        {
            right[x] = A[i];
            x++;
        }  
        left = mergeSort(left);
        right = mergeSort(right);
        result = merge(left, right);  
        return result;
    }

    public static int[] merge(int[] left, int[] right) {
        int resultLength = right.Length + left.Length;
        int[] result = new int[resultLength];
        int indexLeft = 0, indexRight = 0, indexResult = 0;  
        while (indexLeft < left.Length || indexRight < right.Length)
        {
            if (indexLeft < left.Length && indexRight < right.Length)  
            {  
                if (left[indexLeft] <= right[indexRight])
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                else
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            else if (indexLeft < left.Length)
            {
                result[indexResult] = left[indexLeft];
                indexLeft++;
                indexResult++;
            }
            else if (indexRight < right.Length)
            {
                result[indexResult] = right[indexRight];
                indexRight++;
                indexResult++;
            }  
        }
        return result;
    }

    public int solution(int[] A) {
        // Implement your solution here
        //sort
        int[] sortedArray = mergeSort(A);
        //find result
        int result = 1;
        for (int i=0;i<sortedArray.Length;i++){
            if(sortedArray[i]==result){
                result++;
            }
        }
        return result;
    }

    public static void Main(string[] arg){
        Solution s = new Solution();
        int[] A = {1, 3, 6, 4, 1, 2};
        int result = s.solution(A);
        Console.WriteLine(result);
    }
}
