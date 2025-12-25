using Tyuiu.ZelenovaIV.Sprint5.Task0.V7.Lib;

internal class Program
{
    private static void Main(string[] args)
    {

        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Зеленова Ю. В. | АСОиУб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема:  Запись данных в текстовый файл                                   *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #7                                                              *");
        Console.WriteLine("* Выпонил: Зеленова Юлия Владимировна | АСОиУб-25-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Вычислить значение выражения при x = 4 и сохранить результат в текстовый*");
        Console.WriteLine("* файл OutPutFileTask0.txt                                                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        int x;
        x = 4;
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        string res = ds.SaveToFileTextData(x);
        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();
    }
}