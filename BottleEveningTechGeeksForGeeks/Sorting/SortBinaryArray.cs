public partial class Solution
{
    public void sort012(int[] arr)
    {
        // using DNF
        int low = 0;
        int mid = 0;
        int high = arr.Length - 1;

        while (mid <= high)
        {
            if (arr[mid] == 0)
            {
                SwapElements(arr, low, mid);
                low++;
                mid++;
            }
            else if (arr[mid] == 1)
            {
                mid++;
            }
            else
            {
                (arr[mid], arr[high]) = (arr[high], arr[mid]);
                high--;
            }
        }

    }

    private static void SwapElements(int[] arr, int e1, int e2)
    {
        int temp = arr[e1];
        arr[e1] = arr[e2];
        arr[e2] = temp;
    }
}