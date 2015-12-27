using System;
class LargerThanNeighbours
{
    static void Main()
    {
        int[] arr = {1,3,4,5,1,0,5};
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(arr,i));
        }
    }

    private static string IsLargerThanNeighbours(int[] arr, int i)
    {
        if (i==0)
        {
            if (arr[i]>arr[i+1])
            {
                return "true";
            }
            else
            {
                return "false";
            }
        }
        if (i==arr.Length-1)
        {
            if (arr[i] > arr[i - 1])
            {
                return "true";
            }
            else
            {
                return "false";
            }   
        }
        if (arr[i]>arr[i+1] && arr[i]<arr[i-1])
        {
            return "true";
        }
        else
        {
            return "false";
        }
    }
}

