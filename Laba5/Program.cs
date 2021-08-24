using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Laba5
{
    class Program
    {
        static void Main(string[] args)
        {
            string p = @"C:\11";
            DirectoryInfo Papka = new DirectoryInfo(p);
            bool flag = true;
            if (!Papka.Exists)
            {
                Papka.Create();
            }
            while (flag) {
               
                Console.WriteLine("Введите желаемую команду(1 - просмотр файла, 2 - изменение файла, 3 - выход)");
            int a = Int32.Parse(Console.ReadLine());//изучить директории и как выполняется доступ к файлам. создаются папки и т.п.
                
                switch (a)
                {
                    case 1:

                        Console.WriteLine(File.ReadAllText("Text.txt"));
                        
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Введите новую информацию: ");
                        string text = Console.ReadLine();
                        
                        using (StreamWriter w = File.AppendText("c:\\11\\Text.txt"))
                        {
                            Console.WriteLine();
                            w.WriteLine(text);
                        }
                        
                        break;
                    case 3:
                        flag = false;
                        Console.WriteLine("Endjojo");
                        Console.ReadLine();
                        return;
                }
                   

            }
            Console.ReadLine();
        }
            
        

            
    }
}

