using Tyuiu.ZelenovaIV.Sprint5.Task3.V27.Lib;

internal class Program
{
    private static void Main(string[] args)
    {

        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Зеленова Ю. В. | АСОиУб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема:  Запись данных в бинарный файл                                    *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #27                                                             *");
        Console.WriteLine("* Выпонил: Зеленова Юлия Владимировна | АСОиУб-25-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дано выражение вычислить его значение при x = 3,                        *");
        Console.WriteLine("* результат сохранить в бинарный файл OutPutFileTask3.bin и вывести на    *");
        Console.WriteLine("* консоль. Округлить до трёх знаков после запятой.                        *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        int x = 3;
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("x = " + x);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        string res = ds.SaveToFileTextData(x);
        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();
    }
}