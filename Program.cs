using System.Runtime.CompilerServices;

namespace Assignment7._2._1_Shell_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 10, 52, 38, 45, 99, 77, 152, 21 };


        }

        static void ShellSortArray(int[]? array)
        {
            int length = array.Length;

            //Set the size of the gap between the 2 indicies being evaluted.
            //
            //This will cut the array in half and essentially create 2 subarrays
            //
            //Each iteration of i will create twice as many subarrays as the previous iteration. 
            for (int i = length / 2; i > 0;  i = i / 2) 
            {
                //Set j to the first element of the the second subarray.
                for (int j = i; j < length; j++) 
                {
                    //The temp variable will hold the 2nd element being evaluated.
                    int temp = array[j];
                    
                    //int k is declared here for scope purposes
                    int k;

                    //This loop compares the two indicies from each subarray.
                    //
                    //If the value of the smaller element number is greater than the value of the higher element number,
                    //they are switched.
                    for (k = j; k >= i && array[k - i] > temp; k = k - i)
                    {
                        array[k] = array[k - i];
                    }

                    array[k] = temp;

                }
            }
        }
    }
}
