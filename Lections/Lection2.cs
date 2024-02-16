using System.Text;

public class Lection2
{
    public void �reatingOneDimensionalArray(string[] args) // ������
    {
        if (args.Length == 1)
        {
            if (int.TryParse(args[0], out int arrLenth))
            {
                int[] arr = new int[arrLenth];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = i;
                }
                string view = string.Join(" ", arr);
                Console.WriteLine(view);
            }
            else Console.WriteLine("������ ���� �����");
        }
        else Console.WriteLine("������� ����� ����� �������");
    }

    public void CreatingMultidimensionalArray(string[] args)  // ��������� ������
    {
        if (args.Length == 2)
        {
            if (int.TryParse(args[0], out int arrLenth1) && int.TryParse(args[1], out int arrLenth2))
            {
                int[,] arr = new int[arrLenth1, arrLenth1];
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write($"{arr[i, j] = i}" + "  "); ;                            
                    }
                    Console.WriteLine();
                }
            }
            else Console.WriteLine("������ ���� �����");
        }
        else Console.WriteLine("������� ��� ����� ����� ������");
    }

    public void CreatingArrayOfArrays(string[] args)  // ������ ��������
    {
        if (args.Length == 2)
        {
            if (int.TryParse(args[0], out int arrLenth1) && int.TryParse(args[1], out int arrLenth2))
            {
                int[][] arr = new int[arrLenth1][];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new int[i];
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        Console.Write($"{arr[i][j] = j}" + "  ");
                    }
                    Console.WriteLine();
                }
            }
            else Console.WriteLine("������ ���� �����");
        }
        else Console.WriteLine("������� ��� ����� ����� ������");

    }

    public void Fibo(string[] args)
    {
        if (args.Length == 1)
        {
            if (int.TryParse(args[0], out int number))
            {
                int[] arr = new int[number];
                arr[0] = 1;
                int nw = 1;
                int old = 0;
                int result = 0;
                for (int i = 1; i < number; i++)
                {
                    result = nw + old;
                    old = nw;
                    nw = result;
                    arr[i] = result;
                }
                string str = string.Join(",", arr);
                Console.WriteLine("��� ��������: \n" + str);
                Console.WriteLine("��������� �����: " + arr[^1]);
            }
            else Console.WriteLine("����� ����� ������������� �����");
        }
        else Console.WriteLine("��� �������� ����� ���� �����");
    }

    public void FiboDS(string[] args) 
    {
        /*�������� ������� ���������� N-�� ����� ��������� ���������
        ������������� ����� ������� - 2*/

        if (args.Length == 1)
        {
            if (int.TryParse(args[0], out int number))
            {
                int[] arr = new int[2];
                arr[0] = 1;
                arr[1] = 1;
                for (int i = 2; i < number; i++)
                {
                    int temp = arr[1];
                    arr[1] = arr[0] + arr[1];
                    arr[0] = temp;
                }
                // Console.WriteLine(string.Join(" ", arr));
                Console.WriteLine("��������� �����: " + arr[^1]);
            }
            else Console.WriteLine("����� ����� ������������� �����");
        }
        else Console.WriteLine("��� �������� ����� ���� �����");

    }

    public void FiboPrepod(string[] args) 
    {
        if (args.Length == 1)
        {
            if (int.TryParse(args[0], out int number))
            {
                int[] arr = new int[number];
                arr[0] = 1;
                arr[1] = 1;
                for (int i = 2; i < arr.Length; i++)
                {
                    arr[i] = arr[i - 1] + arr[i - 2];
                }
                Console.WriteLine("��������� �����: " + arr[^1]);
            }
            else Console.WriteLine("����� ����� ������������� �����");
        }
        else Console.WriteLine("��� �������� ����� ���� �����");


    }


    private int TempFiboRecurcy(int number) 
    {
        if (number == 1) return 1;
        if (number == 2) return 1;

        return TempFiboRecurcy(number - 1) + TempFiboRecurcy(number - 2);

    }
    public void FiboRecursy(string[] args) 
    {
        if (args.Length == 1)
        {
            if (int.TryParse(args[0], out int number))
            {
                Console.WriteLine("��������� �����: " + TempFiboRecurcy(number));
            }
            else Console.WriteLine("����� ����� ������������� �����");
        }
        else Console.WriteLine("��� �������� ����� ���� �����");
    }

    public void MultiplicationTable()  // ������� ���������
    {
        for (int i = 1; i < 10; i++)
        {
            for (int j = 1; j < 10; j++)
            {
                Console.Write($"{i} x {j} = {i * j}" + "\t");
            }
            Console.WriteLine();
        }
    }

    public void CountWords(string[] args) 
    {
        /* �������� ��������� �������������� ���������� ���� � ��������
        �����������(����������� ������� � ������ � �����)*/
        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < args.Length; i++)
        {
            stringBuilder.Append(args[i]);
            stringBuilder.Append(' ');  
        }

        int count = 0;
        for (int i = 0; i < stringBuilder.Length; i++)
        {
            if (stringBuilder[i] == ' ')
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}