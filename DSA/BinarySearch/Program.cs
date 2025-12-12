namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[500];

            // Fill the array, starting at 1
            for (int i = 1; i <= myArray.Length; i++)
            {
                myArray[i - 1] = i;
            }

            int? index = BinarySearch(myArray, 500);

            Console.WriteLine("index: " + index);
        }

        static int? BinarySearch(int[] sortedArray, int target)
        {
            int low = 0;
            int high = sortedArray.Length - 1;
            int c = 0;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                // Safer version to avoid overflow when calculating mid
                // mid = low + (high - low) / 2;

                if (sortedArray[mid] > target)
                {
                    high = mid - 1;
                }
                else if (sortedArray[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    return mid;
                }
                c++;
                Console.WriteLine(c);
            }

            return null;
        }
    }
}
