using Tyuiu.IvashkinLA.Sprint1.Task0.V0.Lib;

namespace Tyuiu.IvashkinLA.Sprint1.Task0.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            var res = ds.Calculate();

            Console.Title = "Спринт #1 | Выполнил: Ивашкин Л. А. | ПКТ6-26-1";

            //Длина строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* #1.0 Базовые навыки работы в C#                                         *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Ивашкин Лев Анатольевич | ПКТ6-26-1                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 2*9+7*2 и               *");
            Console.WriteLine("* печатает результат на экране.                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: 2*9+7*2                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* РЕЗУЛЬТАТ: {res}                                                           *");
            Console.WriteLine("***************************************************************************");

            Console.ReadLine();
        }
    }
}