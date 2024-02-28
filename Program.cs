using System.Drawing;

namespace Bubble_Sort
{
    internal class Program
    {

        static void bubbleSort(int[] arr, int n)
        {
            int i, j, temp;
            bool swapped;
            for (i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {

                        // Swap arr[j] and arr[j+1]
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (swapped == false)
                    break;
            }
        }
        static void Main(string[] args)
        {
            int[] arr ={ 5,72,3,14,7,1};
            int n = arr.Length;
            bubbleSort(arr, n);
            Console.WriteLine("Sorted array:");
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();



        }
    }
}
