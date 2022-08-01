using System;

namespace Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 105, 8, 4, 22, 16, 3, 9, 11, 1, 19, 18, 6, 7 };


//            BubbleSort((int[])arr.Clone());
            SelectionSort((int[])arr);

            foreach (int n in arr)
                Console.WriteLine(n);
        }
        static void BubbleSort(int[] arr)
        {

            bool swap;
            do
            {
                swap = false;

                for (int i = 0; i < arr.Length - 1; i++)
                {

                    if (arr[i] > arr[i + 1])
                    {
                        swap = true;
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
            }
            while (swap == true);



        }
        static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minNumIndex = i;

                for (int j = i+1; j < arr.Length; j++)
                    if (arr[j] < arr[minNumIndex])
                        minNumIndex = j;

                    int temp = arr[minNumIndex];
                    arr[minNumIndex] = arr[i];
                    arr[i] = temp;


            }

        }

     
    }

}
