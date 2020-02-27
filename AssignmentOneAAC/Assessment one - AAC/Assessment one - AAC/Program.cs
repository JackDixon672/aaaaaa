using System;

namespace Assessment_one___AAC
{
    class Program
    {
        static int[] listOfNumbers = { 2, 10, 4, 23, 100, 9 };
        static void Main(string[] args)
        {
            insertionSort(listOfNumbers, listOfNumbers.Length, true);
            foreach(int x in listOfNumbers)
                Console.WriteLine(x);
        }

        static void bubbleSort(int[] array, int n, bool reverse)
        {
            for(int x = n-1;x >= 0; x--) for(int y = 0; y < x; y++)
                    //Swapping numbers when appropriate, for either the ascending an descending order
                    if((array[y] > array[y+1] && !reverse) || (array[y] < array[y + 1] && reverse))
                    {
                        //Swapping the numbers
                        int temp = array[y];
                        array[y] = array[y + 1];
                        array[y+1] = temp;
                    }
        }
        static void quickSort(int[] array, int n, bool reverse)
        {

        }
        static void mergeSort()
        {

        }
        static void insertionSort(int[] array, int n, bool reverse)
        {
            int amountSorted = 1;
            int x;
            while(amountSorted < n)
            {
                int temp = array[amountSorted];
                for (x = amountSorted; x > 0; x--)
                    if ((temp < array[x - 1] && !reverse) || (temp > array[x - 1] && reverse))
                        array[x] = array[x - 1];
                    else
                        break;
                array[x] = temp;
                amountSorted++;
            }
                
                
        }
    }
}
