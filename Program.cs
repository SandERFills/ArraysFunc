using System;

namespace Reff
{
    class Program
    {
        static void Resize(ref int[] arr,int size_of_array)
        {
            int[] buffarr = arr;
            arr = new int[size_of_array];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = buffarr[i];
            }
        }
        static void AddElement(ref int[] arr,int num_element,int input)
        {
            int[] buffarr = new int[arr.Length + 1];
            buffarr[num_element] = input;
            for (int i = 0; i < num_element; i++)
            {
                buffarr[i] = arr[i];
            }
            for (int i = num_element; i < arr.Length; i++)
            {
                buffarr[i+1] = arr[i];
            }
            arr = buffarr;
        }
        static void AddElementBegin(ref int[] arr,int input)
        {
            int[] buffarr = new int[arr.Length+1];
            buffarr[0] = input;
            for (int i = 0; i < arr.Length; i++)
            {
                buffarr[i + 1] = arr[i];
            }
            arr = buffarr; 
        }
        static void AddElementEnd(ref int[] arr,int input)
        {
            int[] buffarr = new int[arr.Length + 1];
            buffarr[arr.Length] = input;
            for (int i = 0; i < arr.Length; i++)
            {
                buffarr[i] = arr[i];
            }
            arr = buffarr;
        }
        static void DeleteElement(ref int[] arr, int index) {
            int[] buffarr = new int[arr.Length - 1];
            for (int i = 0; i < index; i++)
            {
                buffarr[i] = arr[i];
            }
            for (int i = index; i < buffarr.Length; i++)
            {
                buffarr[i] = arr[i + 1];
            }
            arr = buffarr;
        }
        static void DeleteFist(ref int[] arr)
        {
            DeleteElement(ref arr, 0);
        }
        static void DeleteLast(ref int[] arr)
        {
            DeleteElement(ref arr, arr.Length-1);
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] {1,2,3,4,2,2,5 };
            //Resize(ref arr, 5);
            //Resize(ref arr, 3);
            //AddElement(ref arr, 4, 90);
            //AddElementBegin(ref arr, 90);
            //AddElementEnd(ref arr, 90);
            //DeleteElement(ref arr, 4);
            //DeleteFist(ref arr);
            DeleteLast(ref arr);
        }
    }
}
