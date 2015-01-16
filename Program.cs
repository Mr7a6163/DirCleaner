using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DirCLeaner
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("I is not responsible for any damage this does to your files");
        Console.WriteLine("You are using this program at your own risk");
            Console.WriteLine("What directory would you like to clear the contents of?");
        Console.WriteLine("Type help if want to know what this will do");
            string dir = Console.ReadLine();
            if (@dir == "help")
            {
                Console.WriteLine("DirCleaner is written by Zac McChesney");
                Console.WriteLine("This program will delete everything inside the specified folder");
                Console.WriteLine("While keeping the actual folder");
                goto start;
            }
            else
            {
                if (Directory.Exists(@dir))
                {
                    Console.WriteLine("By typing YES, you agree that I am not responsible for any damage to you files");
                    Console.WriteLine("Type YES to continue or anything else to got back to the start");
                    string yn = Console.ReadLine();
                    if (yn == "YES")
                    {
                        System.IO.DirectoryInfo dirs = new DirectoryInfo(@dir);

                        foreach (FileInfo file in dirs.GetFiles())
                        {
                            file.Delete();
                        }
                        foreach (DirectoryInfo directory in dirs.GetDirectories())
                        {
                            directory.Delete(true);
                        }
                        Console.WriteLine("Direcdtor has been cleaned!");
                        goto start;
                    }
                    else
                    {
                        goto start;
                    }
                }
                else
                {
                    Console.WriteLine("This directory does not exist");
                    Console.WriteLine(@"Write the directory like 'C:\directory'");
                    goto start;
                }
            }
        }
    }
}
