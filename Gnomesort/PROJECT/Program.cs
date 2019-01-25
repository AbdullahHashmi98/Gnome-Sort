using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter Numbers");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }
            gnome(arr);
        }
        public static void gnome(int[] arr)
        {
            for(int i=0;i<arr.Length;)
            {
                if(i==0)
                {
                    i++;
                }
                if (arr[i] >= arr[i - 1])
                {
                    i++;
                }
                else
                {
                    int temp = arr[i];
                    arr[i] = arr[i - 1];
                    arr[i - 1] = temp;
                    i--;
                }
                }
                
            
            Console.WriteLine("Sorted Array");
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
