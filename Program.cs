namespace DiveIntoCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Seminar1 seminar1 = new Seminar1();
              seminar1.Average(args);       // среднее арифметическое
              seminar1.Summa(args);         // сумма двух чисел
              seminar1.MinNunber(args);     // мин число
              seminar1.TotalAmount(args);   // сумма всех чисел */

            /*HomeWork1 work1 = new HomeWork1();
            work1.Calc(args);*/

            Lection2 lection2 = new Lection2();
            lection2.Fibo(args);            // мой фибоначи
            lection2.FiboRecursy(args);     // рекурсивный
            lection2.FiboPrepod(args);      // фибо препода 
            lection2.FiboDS(args);          // домашнее задание

            // Lection2 changeArrays = new Lection2();
            // changeArrays.СreatingOneDimensionalArray(args);      // одномерный массив
            // changeArrays.CreatingMultidimensionalArray(args);    // двумерный массив
            // changeArrays.CreatingArrayOfArrays(args);            // массив массивов или зубчатый

            /*Lection2 les2 = new Lection2();
            les2.MultiplicationTable();     // таблица умножения*/

            /*Lection2 words = new Lection2();
            words.CountWords(args);         // подсчет пробелов в строке*/
        }
    }
}
