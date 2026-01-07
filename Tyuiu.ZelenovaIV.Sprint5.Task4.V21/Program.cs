using System.IO;
using Tyuiu.ZelenovaIV.Sprint5.Task4.V21.Lib;
internal class Program
{
    private static void Main(string[] args)
    {

        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Зеленова Ю. В. | АСОиУб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема:  Чтение данных из текстогого файла                                *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #21                                                             *");
        Console.WriteLine("* Выпонил: Зеленова Юлия Владимировна | АСОиУб-25-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан текстовый файл, прочитать из него значение и                        *");
        Console.WriteLine("* выполнить с ним математические действия                                 *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        string path = $@"{Directory.GetCurrentDirectory()}\InPutFileTask4.txt";
        Console.WriteLine("Данные находятся в файле: " + path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        double res = ds.LoadFromDataFile(path);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}