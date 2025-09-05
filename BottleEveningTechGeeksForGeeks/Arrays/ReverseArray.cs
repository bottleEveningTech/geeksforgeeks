public partial class Solution
{
    public void reverseArray(int[] arr)
    {

        int start = 0;
        int end = arr.Length - 1;

        while(start < end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }

    }
}