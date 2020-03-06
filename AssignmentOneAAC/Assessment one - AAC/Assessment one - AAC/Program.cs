using System;
using System.Collections.Generic;
using System.IO;

namespace Assessment_one___AAC
{
    class Program
    {
        static void Main(string[] args)
        {
            ////File handling
            
            //Reading all of the files initially, as requested by the brief
            string[] netOne256 = File.ReadAllLines("Net_1_256.txt");

            string[] netTwo256 = File.ReadAllLines("Net_2_256.txt");

            string[] netThree256 = File.ReadAllLines("Net_3_256.txt");

            string[] netOne2048 = File.ReadAllLines("Net_1_2048.txt");

            string[] netTwo2048 = File.ReadAllLines("Net_2_2048.txt");

            string[] netThree2048 = File.ReadAllLines("Net_3_2048.txt");

            //I am using an array containing the file names so that I can refer to the files by their index value. This circumvents the need for multiple comparisons when the user is choosing the file.
            List<string[]> arrayOptions = new List<string[]>() { netOne256, netTwo256, netThree256, netOne2048, netTwo2048, netThree2048 };
            


            ////User selection

            //Choosing the array
            Console.WriteLine("Select which array you would like to analyse \n1 netOne256\n2 netTwo256\n3 netThree256\n4 netOne2048\n5 netTwo2048\n6 netThree2048");
            int chosenArray = int.Parse(Console.ReadLine()) -1;            
            //Loading the chosen array into a new, integer array for the puproses of sorting and comparison
            int[] listOfNumbers = new int[arrayOptions[chosenArray].Length];
            for (int x = 0; x < arrayOptions[chosenArray].Length; x++) listOfNumbers[x] = int.Parse(arrayOptions[chosenArray][x]);

            //Choosing to sort in ascending or descending order
            Console.WriteLine("Select whether you would like to sort in ascending or descending order (a/d)");
            string chosenOrder = Console.ReadLine();
            bool descending = chosenOrder == "d";


            ////Running the algorithms




            insertionSort(listOfNumbers, listOfNumbers.Length, descending);
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
            //Initialising variables
            int amountSorted = 1; //Insertion sort considers the first item to be sorted
            int x; //Allows me to refer to the counter in the for loop outside the scope of the for loop itself
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
