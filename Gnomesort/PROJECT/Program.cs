using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT
{
    class Program
    {
        //In this code i use integer array to sort using Gnome sort algorithm
        static void Main(string[] args)
        {   //Use random class
            Random random = new Random();
            Console.WriteLine("Enter number of elements");
            int n = Convert.ToInt16(Console.ReadLine());
            int[] arr = new int[n];
        
            for(int i=0;i<arr.Length;i++)
            {
                //take random values from 1-100
                arr[i] = random.Next(100);
            }
            //call gnome function
            gnomesort(arr);
        }
        public static void gnomesort(int[] arr)
        {  //take integer variable and equals to 0 for iteration
            int index = 0;
            //iterate while loop 
            while(index!=arr.Length)
            {
                if(index==0)
                {
                    //if index is 0 move one position forward or increament  1 in index
                    index++;
                }
                if (arr[index] >= arr[index - 1])
                {
                    //if current postion element is greater than previous one than move one position forward or increament 1 in index 
                    index++;
                }
                else
                {  
                    //if current position element is less than previous one than swap the elements and move backward one position or decreament 1 in index 
                    int temp = arr[index];
                    arr[index] = arr[index - 1];
                    arr[index - 1] = temp;
                    index--;
                }
                }
                
            //print sorted elements in ascending order which is my requirement you can also use you requirement
            Console.WriteLine("Sorted Array");
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
