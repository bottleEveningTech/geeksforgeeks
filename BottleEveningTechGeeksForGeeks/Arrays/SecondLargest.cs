public partial class Solution
{
    public int GetSecondLargest(int[] arr)
    {
        int max = -1;
        int secondMax = -1;
        int size = arr.Length;

        for (int i = 0; i < size; i++)
        {
            if (arr[i] > max)
            {
                secondMax = max;
                max = arr[i];
            }
            else if (arr[i] > secondMax && arr[i] != max)
            {
                secondMax = arr[i];
            }
        }
        return secondMax;

    }
}