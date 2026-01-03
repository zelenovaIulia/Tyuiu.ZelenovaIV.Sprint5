
using Tyuiu.ZelenovaIV.Sprint5.Task1.V12.Lib;
internal class Program
{
    private static void Main(string[] args)
    {

        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Зеленова Ю. В. | АСОиУб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема:  Запись данных в текстовый файл                                   *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #12                                                             *");
        Console.WriteLine("* Выпонил: Зеленова Юлия Владимировна | АСОиУб-25-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Вычислить значение выражения при значениях от -5 до 5                   *");
        Console.WriteLine("* и сохранить результат в текстовый файл OutPutFileTask1.txt              *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        int startValue = -5;
        int stopValue = 5;
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("startValue = " + startValue);
        Console.WriteLine("stopValue = " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        string res = ds.SaveToFileTextData(startValue, stopValue);
        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();
    }
}