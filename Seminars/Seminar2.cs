using System.Text;

public class Seminar2
{
    public void SearchNumber(string[] args) 
    {
        /*Найти числа в диапазоне от 0 до 1000, деляшиеся на 3 без остатка.*/
        if (args.Length == 1)
        {
            if (int.TryParse(args[0], out int number))
            {
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < number; i++)
                {
                    if (i % 3 == 0)
                    {
                        stringBuilder.Append(i);
                        stringBuilder.Append(' ');
                    }
                }
                Console.WriteLine(stringBuilder);
            }
            else Console.WriteLine("Нужно число");
        }
        else Console.WriteLine("Нужно число");
    }

    public void SummNumberDel(string[] args) 
    {
        /* Найти сумму чисел, деляшиеся на 3 без остатка в диапазоне от 0 до 1000. */
        if (args.Length == 1)
        {
            if (int.TryParse(args[0], out int number))
            {
                int summa = 0;
                for (int i = 0; i < number; i++)
                {
                    if (i % 3 == 0)
                    {
                        summa += i;
                    }
                }
                Console.WriteLine(summa);
            }
            else Console.WriteLine("Нужно число");
        }
        else Console.WriteLine("Нужно число");
    }

    public void CountNumDel(string[] args) 
    {
        /* Найти количество чисел, деляшиеся на 3 без остатка в диапазоне от 0 до 1000. */
        if (args.Length == 1)
        {
            if (int.TryParse(args[0], out int number))
            {
                int count = 0;
                /*for (int i = 0; i < number; i++)
                {
                    if (i % 3 == 0)
                    {
                        count ++;
                    }
                }*/

                for (int i = 0; i < number; i += 3)
                {
                        count++;
                }
                Console.WriteLine(count);
            }
            else Console.WriteLine("Нужно число");
        }
        else Console.WriteLine("Нужно число");
    }

    public void CountOne(string[] args) 
    {
        // Программа, считающая кло-во едениц в двоичном коде
        if (args.Length == 1)
        {
            if (int.TryParse(args[0], out int number))
            {
                int count = 0;
                while (number > 0)
                {
                    if (number % 2 != 0)
                    {
                        count++;
                        number = number / 2;
                    }
                    else number = number / 2;
                }
                Console.WriteLine(count);
            }
            else Console.WriteLine("Нужно число");
        }
        else Console.WriteLine("Нужно число");
    }

    private int[] CreateArray(int length)  // создает массив длиной length, с рандомными значениями
    {
        int[] arrA = new int[length];
        for (int i = 0; i < arrA.Length; i++)
            {
                arrA[i] = new Random().Next(0, 100);
            }
        return arrA;
    }

    private void ViewArray(int[] arr)  // вывод массива в консоль
    {
        Console.Write(string.Join(" ", arr));  
    }

    public void SortArrays(string[] args) 
    {
        // Даны два массива А и В, заполненные случайными числами, заполнить рандомно. Создать общий отсортированный массив.
        if (args.Length == 2)
        {
            if (int.TryParse(args[0], out int length1) && int.TryParse(args[1], out int length2))
            {
                int[] arrA = CreateArray(length1);
                ViewArray(arrA);
                int[] arrB = CreateArray(length2);
                ViewArray(arrB);

                int[] resArr = new int[arrA.Length + arrB.Length];
                for (int i = 0; i < arrA.Length; i++)
                {
                    resArr[i] = arrA[i];
                }
                for (int i = 0; i < arrB.Length; i++)
                {
                    resArr[i + arrA.Length] = arrB[i];
                }
                Array.Sort(resArr);
                ViewArray(resArr);
            }
            else Console.WriteLine("Нужны числа");
        }
        else Console.WriteLine("Нужно два числа");
    }

    private bool CheckStringToNum(string str) // проверяет, есть ли с строке число
    {
        foreach (var item in str)
        {
            if (char.IsDigit(item))
            {
                return true;  //если хоть один символ число, то true
            }
        }
        return false; //если цифр нет
    }

    public void SearchNumbersInString() 
    {
        /* Найти подстроку с числами в строке */

        Console.WriteLine("Задайте стоку, содержащую числа");
        string str = Console.ReadLine()!;

        StringBuilder sb = new StringBuilder();

        string[] arr = str.Split(" ")!;
        
        for (int i = 0; i < arr.Length; i++)
        {
            if (CheckStringToNum(arr[i]))
            {
                sb.Append(arr[i]);
                sb.Append(" ");
            }
        }
        Console.WriteLine(sb);
    }

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


    public void ArrayRefact()  // рефакт массива
    {
        int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int[,] newArr = new int[arr.GetLength(1), arr.GetLength(0)];
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

        count = 0;
        for (int i = 0; i < newArr.GetLength(0); i++)
        {
            for (int j = 0; j < newArr.GetLength(1); j++)
            {
                newArr[j, i] = temp[j + count];
            }
            count = count + newArr.GetLength(1);
        }

        ViewDualIntArray(arr);
        Console.WriteLine();
        ViewArray(temp);
        Console.WriteLine();
        ViewDualIntArray(newArr);
    }

    public void ArrayRotation() // переворот массива
    {
        int[,] arr = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }};
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            for (int j = arr.GetLength(0) - 1; j >= 0; j--)
            {
                Console.Write(arr[j, i] + "\t");
            }
            Console.WriteLine();
        }
    }

    public void InStringDelNamber()
    {
        // удалить числа из строки

        Console.WriteLine("Задайте стоку, содержащую числа");
        string str = Console.ReadLine()!;

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < str.Length; i++)
        {
            if (!char.IsDigit(str[i]))
            {
                sb.Append(str[i]);
            }
        }
        Console.Write(sb);
    }
}