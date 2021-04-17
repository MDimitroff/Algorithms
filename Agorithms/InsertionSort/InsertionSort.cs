namespace InsertionSort
{
    public class InsertionSort
    {
        public static void Sort(int[] array)
        {
            int inner, temp;
            for (int outer = 1; outer < array.Length; outer++)
            {
                temp = array[outer];
                inner = outer;

                while (inner > 0 && array[inner - 1] >= temp)
                {
                    array[inner] = array[inner - 1];
                    inner -= 1;
                }

                array[inner] = temp;
            }
        }
    }
}
