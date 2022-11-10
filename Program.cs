using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.Win32;
using System.Runtime.InteropServices.ComTypes;
using System.Xml.Linq;

namespace igra_zheskaya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ку, как тебя зовут?");
            string NAME = Console.ReadLine();
            Thread.Sleep(1000);
            Console.Clear();
            while (true)
            {
                Console.WriteLine($"Ку, {NAME}, выбирай номер игры, и играй жоска ");
                Console.WriteLine("                               ");
                Console.WriteLine("#############################");
                Console.WriteLine("-----------------------");
                Console.WriteLine("0. ?????????????");
                Console.WriteLine("1. Казино");
                Console.WriteLine("2. 1000-7");
                Console.WriteLine("3. Очистить консоль");
                Console.WriteLine("4. Настройки");
                Console.WriteLine("-----------------------");
                Console.WriteLine("#############################");
        int MENU = Convert.ToInt32(Console.ReadLine());
                if (MENU == -1)
                {
                    Console.Write("зачем ты сюда зашёл?");
                    Console.Write("?");
                    Thread.Sleep(25);
                    Console.Write("?");
                    Thread.Sleep(25);
                    Console.Write("?");
                    Thread.Sleep(25);
                    Console.Write("?");
                    Thread.Sleep(50);
                    Console.Write("?");
                    Thread.Sleep(50);
                    Console.Write("?");
                    Thread.Sleep(50);
                    Console.Write("?");
                    Thread.Sleep(50);
                    Console.Write("?");
                    Thread.Sleep(50);
                    Console.Write("?");
                    Thread.Sleep(50);
                    Console.Write("?");
                    Thread.Sleep(50);
                    Console.Write("?");
                    Thread.Sleep(50);
                    Console.Write(" ");
                    Thread.Sleep(100);
                    Console.Write("т");
                    Thread.Sleep(100);
                    Console.Write("ы");
                    Thread.Sleep(100);
                    Console.Write(" ");
                    Thread.Sleep(100);
                    Console.Write("н");
                    Thread.Sleep(100);
                    Console.Write("е");
                    Thread.Sleep(25);
                    Console.Write(" ");
                    Thread.Sleep(100);
                    Console.Write("должен");
                    Thread.Sleep(25);
                    Console.Write(" б");
                    Thread.Sleep(25);
                    Console.Write("ы");
                    Thread.Sleep(25);
                    Console.Write("л");
                    Thread.Sleep(25);
                    Console.Write(" сю");
                    Thread.Sleep(25);
                    Console.Write("да");
                    Thread.Sleep(25);
                    Console.Write(" з");
                    Thread.Sleep(25);
                    Console.Write("ай");
                    Thread.Sleep(25);
                    Console.Write("т");
                    Thread.Sleep(50);
                    Console.Write("и");
                    Thread.Sleep(2000);
                    Console.WriteLine("" +
                        " Пока");
                    Thread.Sleep(100);
                    Console.Write(".");
                    Thread.Sleep(100);
                    Console.Write(".");
                    Thread.Sleep(100);
                    Console.Write(".");
                    Thread.Sleep(100);
                    Console.Write(".");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                if (MENU == 0)
                    {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.White;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.Green;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("                                                                                                                       ");
                    Thread.Sleep(50);
                    Console.BackgroundColor = ConsoleColor.Red;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.White;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("                                                                                                                       ");
                    Thread.Sleep(50);
                    Console.BackgroundColor = ConsoleColor.Red;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Thread.Sleep(50);
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("                                                                                                                       ");
                    Thread.Sleep(50);
                    Console.BackgroundColor = ConsoleColor.Red;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.White;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Thread.Sleep(50);
                    Console.WriteLine("                                                                                                                       ");
                    Console.ResetColor();
                    Console.Clear();
                }
                //
                if (MENU == 1)
                {
                    Console.Clear();
                    Console.WriteLine($"Привет, {NAME}, это казич, а это значит если твое число совпадет с рандомом, то ты выйграл(а)");
                    Thread.Sleep(3000);
                    int x = 1;
                    //тут считается все рандомы и запоминаются тоже здесь
                    //2
                    Random rndd = new Random();
                    int rd = rndd.Next(1, 2);
                    //3
                    Random rnt = new Random();
                    int rt = rnt.Next(1, 3);
                    //4
                    Random rnch = new Random();
                    int rch = rnch.Next(1, 4);
                    //5
                    Random rnp = new Random();
                    int rcp = rnp.Next(1, 5);
                    //меню
                    Console.WriteLine($"Привет, {NAME}, ты находишься в главном меню казича");
                    Console.WriteLine("                    ");
                    Console.WriteLine("1. 1/2");
                    Console.WriteLine("2. 1/3");
                    Console.WriteLine("3. 1/4");
                    Console.WriteLine("4. 1/5");
                    Console.WriteLine("Напиши цифру режима, в который хочешь поиграть");
                    int num = Convert.ToInt32(Console.ReadLine());
                    int numberMENU = (num + x);
                    //менюшка сверху
                    if (numberMENU == 2)
                    {
                        Console.WriteLine("Ты выбрал(а) 1/2");
                    }
                    if (numberMENU == 3)
                    {
                        Console.WriteLine("Ты выбрал(а) 1/3");
                    }
                    if (numberMENU == 4)
                    {
                        Console.WriteLine("Ты выбрал(а) 1/4");
                    }
                    if (numberMENU == 5)
                    {
                        Console.WriteLine("Ты выбрал(а) 1/5");
                    }
                    if (numberMENU > 6)
                    {
                        Console.WriteLine("Тут нет такого режима(");
                    }
                    if (numberMENU == 6)
                    {
                        Console.WriteLine("Тут нет такого режима(");
                    }
                    //сам казич
                    //1/2
                    if (numberMENU == 2)
                    {
                        Console.WriteLine("Введите число число от 1 до 2: ");
                        int dva = Convert.ToInt32(Console.ReadLine());
                        if (dva == rd)
                        {
                            Console.WriteLine("Ты выйграл(а)");
                        }
                        else if (dva == 3)
                        {
                            Console.WriteLine("Надо бы другое число подобрать...");
                        }
                        else if (dva > 3)
                        {
                            Console.WriteLine("Надо бы другое число подобрать...");
                        }
                        else
                        {
                            Console.WriteLine($"Ты не выйграл(а), выпало число {rd}");
                        }
                    }
                    //1/3
                    if (numberMENU == 3)
                    {
                        Console.WriteLine("Введите число число от 1 до 3: ");
                        int tri = Convert.ToInt32(Console.ReadLine());
                        if (tri == rt)
                        {
                            Console.WriteLine("Ты выйграл(а)");
                        }
                        else if (tri == 4)
                        {
                            Console.WriteLine("Надо бы другое число подобрать...");
                        }
                        else if (tri > 4)
                        {
                            Console.WriteLine("Надо бы другое число подобрать...");
                        }

                        else
                        {
                            Console.WriteLine($"Ты не выйграл(а), выпало число {rt}");
                        }
                    }
                    //1/4
                    if (numberMENU == 4)
                    {
                        Console.WriteLine("Введите число число от 1 до 4: ");
                        int ch = Convert.ToInt32(Console.ReadLine());
                        if (ch == rch)
                        {
                            Console.WriteLine("Ты выйграл(а)");
                        }
                        else if (ch == 5)
                        {
                            Console.WriteLine("Надо бы другое число подобрать...");
                        }
                        else if (ch > 5)
                        {
                            Console.WriteLine("Надо бы другое число подобрать...");
                        }
                        else
                        {
                            Console.WriteLine($"Ты не выйграл(а), выпало число {rch}");
                        }
                    }
                    //1/5
                    if (numberMENU == 5)
                    {
                        Console.WriteLine("Введите число число от 1 до 5: ");
                        int p = Convert.ToInt32(Console.ReadLine());
                        if (p == rcp)
                        {
                            Console.WriteLine("Ты выйграл(а)");
                        }
                        else if (p == 6)
                        {
                            Console.WriteLine("Надо бы другое число подобрать...");
                        }
                        else if (p > 6)
                        {
                            Console.WriteLine("Надо бы другое число подобрать...");
                        }
                        else
                        {
                            Console.WriteLine($"Ты не выйграл(а), выпало число {rcp}");
                        }
                    }
                    //сам рандом
                    //  Random rnd = new Random();
                    // int r = rnd.Next(1, 2);
                    Thread.Sleep(4000);
                    Console.Clear();
                }
                if (MENU == 2)      
                    {
                    Console.WriteLine("У меня нет проблем, кроме моей башки");
                    Thread.Sleep(1000);
                    Console.WriteLine("1000 - 7, я умер, прости");
                    Thread.Sleep(1000);
                    Console.WriteLine("Этот ёбаный дождь нагоняет тоски");
                    Thread.Sleep(1000);
                    Console.WriteLine("1000 - 7, я умер, прости");
                    Thread.Sleep(1000);
                    Console.WriteLine("И им всем никогда меня не победить");
                    Thread.Sleep(1000);
                    Console.WriteLine("1000 - 7, я уже погиб");
                    Thread.Sleep(2000);
                    Console.WriteLine("...");
                    Thread.Sleep(2000);
                    for (int i = 1000; i > -1000; i -= 7)
                    {
                        Console.WriteLine(i + " - 7 = " + (i - 7));
                        Thread.Sleep(10);
                    }
                    Console.Clear();
                }
                if (MENU == 3)
                {
                    Console.Clear();
                }
                if (MENU == 4)
                {
                    Console.Clear();
                    Console.WriteLine("#####################");
                    Console.WriteLine("Что ты хочешь настроить?");
                    Console.WriteLine("1. Цвет бекграунда");
                    Console.WriteLine("2. Цвет текста");
                    Console.WriteLine("3.Сбросить настройки");
                    Console.WriteLine("#####################");
                    int OPTIONS = Convert.ToInt32(Console.ReadLine());
                    if (OPTIONS == 0) Console.WriteLine("нет такого(");
                    if (OPTIONS == 1) 
                    {
                        Console.WriteLine("#####################");
                        Console.WriteLine("1. Красный");
                        Console.WriteLine("2. Синий");
                        Console.WriteLine("3. Голубой");
                        Console.WriteLine("4. Фиолетовый");
                        Console.WriteLine("5. Зеленый");
                        Console.WriteLine("6. Желтый");
                        Console.WriteLine("7. Черный");
                        Console.WriteLine("8. Белый");
                        Console.WriteLine("#####################");
                        int colorbg = Convert.ToInt32(Console.ReadLine());
                        if (colorbg == 1)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        if (colorbg == 2)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                        }
                        if (colorbg == 3)
                        {
                            Console.BackgroundColor = ConsoleColor.Cyan;
                        }
                        if (colorbg == 4)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        }
                        if (colorbg == 5)
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                        }
                        if (colorbg == 6)
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                        }
                        if (colorbg == 7)
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                        if (colorbg == 8)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                        }
                        if (colorbg == 0) Console.WriteLine("Нет такого(");
                        if (colorbg == 9) Console.WriteLine("Нет такого(");
                        if (colorbg > 9) Console.WriteLine("Нет такого(");
                    }

                    if(OPTIONS == 2)
                    {
                        Console.WriteLine("#####################");
                        Console.WriteLine("1. Красный");
                        Console.WriteLine("2. Синий");
                        Console.WriteLine("3. Голубой");
                        Console.WriteLine("4. Фиолетовый");
                        Console.WriteLine("5. Зеленый");
                        Console.WriteLine("6. Желтый");
                        Console.WriteLine("7. Черный");
                        Console.WriteLine("8. Белый");
                        Console.WriteLine("#####################");
                        int colortext = Convert.ToInt32(Console.ReadLine());
                        if (colortext == 1) 
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        if (colortext == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        if (colortext == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                        }
                        if (colortext == 4)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        }
                        if (colortext == 5)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        if (colortext == 6)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        if (colortext == 7)
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                        if (colortext == 8)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (colortext == 0) Console.WriteLine("Нет такого(");
                        if (colortext == 9) Console.WriteLine("Нет такого(");
                        if (colortext > 9) Console.WriteLine("Нет такого(");
                        
                    }
                    if(OPTIONS == 3) Console.ResetColor();
                    if (OPTIONS == 4) Console.WriteLine("нет такого(");
                    if (OPTIONS > 4) Console.WriteLine("нет такого(");
                    Thread.Sleep(2000);
                Console.Clear();
                }
                //тут нет такой менюшки
                if (MENU == 5) { 
                    Console.WriteLine("Нет такой менюшки(");
                    Thread.Sleep(500);
                    Console.Clear();
                } 
                if (MENU > 5) {
                    Console.WriteLine("Нет такой менюшки(");
                    Thread.Sleep(500);
                    Console.Clear();
                }
            }
        }
    }
}
