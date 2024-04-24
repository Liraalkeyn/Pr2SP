using System.Management;
using System;
using System.IO;

class Pr2SP
{
    public static void Main()
    {
        DriveInfo[] allDrives = DriveInfo.GetDrives();

        foreach (DriveInfo d in allDrives)
        {
            
            Console.WriteLine("Имя:");
            Console.WriteLine("{0, 50}", d.Name);

            

            if (d.IsReady == true)
            {

                Console.WriteLine("Диск:");
                Console.WriteLine("{0, 50} б", d.TotalSize);
                Console.WriteLine("{0, 51} кбт", d.TotalSize/1024);
                Console.WriteLine("{0, 52} мб", d.TotalSize/1048576);
                Console.WriteLine("{0, 53} гб", d.TotalSize/1073741824);
                

                Console.WriteLine("Осталось места:");
                Console.WriteLine("{0, 50} б", d.TotalFreeSpace);
                Console.WriteLine("{0, 51} кб", d.TotalFreeSpace / 1024);
                Console.WriteLine("{0, 52} мб", d.TotalFreeSpace / 1048576);
                Console.WriteLine("{0, 53} гб", d.TotalFreeSpace / 1073741824);
                

                Console.WriteLine("Метка:");

                Console.WriteLine("{0, 50}", d.VolumeLabel);
            }

            // Путь к обрабатываемой папке
            string namespaceFolder = @"C:\Users\Lemon\source\repos";

            // Дерево всех подкаталогов и файлов в выбранной папке
            Console.WriteLine("Дерево всех подкаталогов и файлов в выбранной папке:");
            Console.WriteLine("{0, 50}", Directory.GetFileSystemEntries(namespaceFolder));

            // Дерево всех подкаталогов и файлов в выбранной папке по фильтру (например *.pdf или *.exe)
            Console.WriteLine("Фильтр .exe:");
            Console.WriteLine("{0, 50}", Directory.GetFileSystemEntries(namespaceFolder, "*.exe", SearchOption.AllDirectories));

            // Создание текстового документа

            DirectoryInfo[] cDirs = new DirectoryInfo(@"c:\").GetDirectories();

            using (StreamWriter sw = new StreamWriter("Абрамова.Абрамова"))
            {
                sw.WriteLine("Введите текст");
            }
            

            try
            {

                using (StreamReader sr = new StreamReader("Абрамова.Абрамова"))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}