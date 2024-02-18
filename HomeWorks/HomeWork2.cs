public class HomeWork2
{
    private void ViewDualIntArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    public void SortIntArray(int[,] arr) 
    {
        int[] temp = new int[arr.GetLength(0) * arr.GetLength(1)];

        int count = 0;

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                temp[j + count] = arr[i, j];
            }
            count = count + arr.GetLength(1);
        }
        ViewDualIntArray(arr);

        Console.WriteLine();

        Array.Sort(temp);

        count = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = temp[j + count];
            }
            count = count + arr.GetLength(1);
        }

        ViewDualIntArray(arr);
    }



}