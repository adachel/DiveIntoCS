public class HomeWork1 
{
    public void Calc(string[] args) 
    {
        if (args.Length == 3)
        {
            double result = 0;
            
            if (double.TryParse(args[0], out double number1) && double.TryParse(args[2], out double number2))
            {
                if (char.TryParse(args[1], out char ch))
                {
                    switch (ch) 
                    {
                        case '+':
                            result = number1 + number2;
                            break;
                        case '-':
                            result = number1 - number2; 
                            break;
                        case '*':
                            result = number1 * number2; 
                            break;
                        case '/':
                            result = number1 / number2;
                            break;
                        default:
                            Console.WriteLine("Задайте корректный знак: '+', '-', '*' или '/'!");
                            return;
                    }
                    Console.WriteLine($"Результат = {result}");
                }
                else Console.WriteLine("Задайте корректный знак: '+', '-', '*' или '/'!");
            }
            else Console.WriteLine("Должны быть заданы численные значения!");
        }
        else Console.WriteLine("Нужно два аргумента и знак между ними. Все через пробел!");
    }
}