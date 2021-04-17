namespace SelectionSort
{
    public class SelectionSort
    {
        public static void Sort(int[] array)
        {
            int min, temp;

            for (int outer = 0; outer < array.Length - 1; outer++) 
            {
                min = outer;
                for (int inner = outer + 1; inner < array.Length - 1; inner++)
                {
                    if (array[inner] < array[min])
                    {
                        min = inner;
                    }

                    temp = array[outer];
                    array[outer] = array[min];
                    array[min] = temp;
                }
            }
        }
    }
}
