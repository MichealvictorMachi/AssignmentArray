namespace AssignmentArray
{
    internal class DescSortings
    {
        static void Main(string[] args)
        {
            int x;
            int[] array = new int[11] { 23, 43, 12, 87, 56, 90, 65, 18, 49, 9, 32 };

            for (int i = 0; i <= array.Length - 1; i++)
            {
                for (int j = 0; j <= array.Length - 2; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        x = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = x;
                    }
                }

            }
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}