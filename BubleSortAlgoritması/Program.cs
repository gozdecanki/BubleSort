using System;

namespace BubleSortAlgoritması
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {4,50,12,9,10,25,14,46 };
            BubleSort(arr);
            SiralamayiYazdir(arr);
            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }

       
        public static void BubleSort (int[] arr)
        {
            
            for (int i=0;i< arr.Length-1;i++)//arrayin uzunluğunun 1 eksiği kadar dönmeli
            {
                for (int j=1;j<arr.Length-i;j++)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        int tutucu = arr[j - 1];
                        arr[j-1]= arr[j];
                        arr[j] = tutucu;

                    }
                }
                
            }
        }

        public static void SiralamayiYazdir(int[] arr)
        {

            for (int i=0; i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);

            }
        }
     

    }
}
