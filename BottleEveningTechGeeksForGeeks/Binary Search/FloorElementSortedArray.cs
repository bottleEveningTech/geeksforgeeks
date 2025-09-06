public partial class Solution
{
    public int FindFloor(int[] arr, int x)
    {
        // greatest element smaller than or equal to x

        int start = 0;
        int end = arr.Length - 1;
        int result = -1;

        while (start <= end)
        {
            int mid = start + (end - start) / 2;
            if (arr[mid] == x)
            {
                result = mid;
                start = mid + 1;
            }
            else if (arr[mid] < x)
            {
                result = mid;
                start = mid + 1;
            }
            else
            {
                end = mid - 1;
            }
        }
        return result;
    }
}
