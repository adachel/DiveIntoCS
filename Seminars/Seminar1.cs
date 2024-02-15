public class Seminar1
{
    public void OutView(out int number) // ���������� out
    {
        number = 123123123;
    }
    public void Summa(string[] args)  // ������� ��� ����� � ������� ����� �����. �������� �� ���-�� ����������.
    {
        if (args.Length == 2)
        {
            //int number1 = int.Parse(args[0]);
            //int number2 = Convert.ToInt32(args[1]);

            if (int.TryParse(args[0], out int number1) && int.TryParse(args[1], out int number2))
            {
                int summma = number1 + number2;
                Console.WriteLine($"����� ����� = {summma}");
            }
            else
            {
                Console.WriteLine("��������� ������ ���� �������");
            }
        }
        else
        {
            Console.WriteLine("������ ���� ��� ���������");
        }
    }
    public void TotalAmount(string[] args) // ������� ����� ���� ����� ewrt
    {
        if (args.Length > 0)
        {
            int summ = 0;
            foreach (var item in args)
            {
                if (int.TryParse(item, out int number))
                {
                    summ = summ + number;
                }

            }
            Console.WriteLine($"����� ���� ����� = {summ}");
        }
        else
        {
            Console.WriteLine("����� ���������");
        }
    }
    public void MinNunber(string[] args)  // ������� ����������� �����
    {
        if (args.Length > 0)
        {
            int minNumber = int.MaxValue;
            foreach (var item in args)
            {
                if (int.TryParse(item, out int number))
                {
                    if (number < minNumber)
                    {
                        minNumber = number;
                    }
                }
            }
            Console.WriteLine($"����������� ����� = {minNumber}");
        }
        else
        {
            Console.WriteLine("����� ���������");
        }
    }
    public void Average(string[] args) // ������� ������� ��������������
    {
        if (args.Length > 0)
        {
            int summ = 0;
            int count = 0;
            foreach (var item in args)
            {
                if (int.TryParse(item, out int number))
                {
                    summ += number;
                    count++;
                }
            }
            Console.WriteLine($"������� �������������� = {summ / count}");
        }
        else
        {
            Console.WriteLine("����� ���������");
        }
    }
}