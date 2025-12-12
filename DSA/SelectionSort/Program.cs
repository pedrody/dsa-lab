namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 8, 5, 4, 17, 10, 22, 1 };
            //double[] myArray = { 12.3, 5.50, 3.75, 12.50 };
            //List<string> names = new List<string> { "Bob", "Alex", "John" };
            //List<string> sortedNames = (List<string>)SelectionSort(names);

            SelectionSort(myArray);
            foreach (double value in myArray)
            {
                Console.Write(value + " ");
            }
        }

        static IList<T> SelectionSort<T>(IList<T> values) where T : IComparable
        {
            for (int i = 0; i < values.Count; i++)
            {
                int lowestIndex = SearchLowest(values, i);
                T aux = values[i];
                values[i] = values[lowestIndex];
                values[lowestIndex] = aux;
            }

            return values;
        }

        static int SearchLowest<T>(IList<T> values, int start) where T : IComparable
        {
            int lowestIndex = start;
            T lowestValue = values[start];
            for (int i = start + 1; i < values.Count; i++)
            {

                int result = values[i].CompareTo(lowestValue);
                if (result < 0)
                {
                    lowestValue = values[i];
                    lowestIndex = i;
                }
            }

            return lowestIndex;
        }
    }
}