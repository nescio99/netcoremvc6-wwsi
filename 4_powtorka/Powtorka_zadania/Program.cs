﻿using System;
using System.Collections.Generic;
// Zadanie 2
//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Podaj swoje imię:");
//            var name = Console.ReadLine();
//            Console.WriteLine("Hello " + name);
//        }
//    }
//}

// Zadanie 3
//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int result = 5 + 9;
//            Console.WriteLine(result);
//        }
//    }
//}

//Zadanie 1 - Operatory 

//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int number = 1;
//            float money = 2.5f;
//            string text = "text";
//            bool isLogged = true;
//            char myChar = 'a';
//            decimal price = 2.1113m;

//            Console.WriteLine("Zmienna 'number' zawiera: " + number);
//            Console.WriteLine("Zmienna 'money' zawiera: " + money);
//            Console.WriteLine("Zmienna 'text' zawiera: " + text);
//            Console.WriteLine("Zmienna 'isLogged' zawiera: " + isLogged);
//            Console.WriteLine("Zmienna 'myChar' zawiera: " + myChar);
//            Console.WriteLine("Zmienna 'price' zawiera: " + price);
//        }
//    }
//}

//Zadanie 2

//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string myAge = "Age: ";
//            int wifeAge = 18;
//            string result = myAge + wifeAge;
//            Console.WriteLine(result);
//        }
//    }
//}

//Zadanie 3
//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            bool isTrue = true;
//            bool isFalse = false;
//            bool isReallyTrue = true;

//            bool and = isTrue && isFalse;
//            bool or = isTrue || isReallyTrue;
//            bool negative = !isFalse;

//            Console.WriteLine("Wynik zmiennej AND: " + and);
//            Console.WriteLine("Wynik zmiennej OR: " + or);
//            Console.WriteLine("Wynik zmiennej NEGATIVE: " + negative);

//        }
//    }
//}


//Zadanie 4
//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double a = 5; double b = 12;
//            double add = a + b; double sub = a - b; double div = a / b; double mul = a * b; double mod = a % b;
//            Console.WriteLine("Wynik dodawania:" + add);
//            Console.WriteLine("Wynik odejmowania:" + sub);
//            Console.WriteLine("Wynik dzielenia:" + div);
//            Console.WriteLine("Wynik mnożenia:" + mul);
//            Console.WriteLine("Wynik modulo:" + mod);

//        }
//    }
//}

//Zadanie 5
//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string a, b, c, result;
//            a = "Ala "; b = "ma "; c = "kota.";
//            result = a + b + c;
//            Console.WriteLine(result);
//        }
//    }
//}

//Zadanie 1 - Pętle
//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n1, n2;
//            n1 = 10; n2 = 20;

//            if (n1 > n2)
//            {
//                Console.WriteLine("n1 jest większe od n2");
//            }
//            else if (n1 == n2)
//            {
//                Console.WriteLine("n1 jest równe n2");
//            }
//            else
//            {
//                Console.WriteLine("n2 jest większe od n1");
//            }
//        }
//    }
//}

//Zadanie 2
//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int j = 0;
//            for(int i = 0; i < 10; i ++)
//            {
//                Console.WriteLine("C#");
//            }

//            while(j < 10)
//            {
//                j++;
//                Console.WriteLine("C#");
//            }
//        }
//    }
//}

//Zadanie 3
//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = 10;
//            for(int i = 0; i <= n; i++)
//            {
//                if(i%2 == 0)
//                {
//                    Console.WriteLine(i + " - Parzysta");
//                }
//                else
//                {
//                    Console.WriteLine(i + " - Nieparzysta");
//                }
//            }
//        }
//    }
//}

//Zadanie 4 - dodatkowe*
//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = 3;
//            for(int i = 0; i < n; i++)
//            {
//                Console.WriteLine();

//                for (int j = 0; j <= i; j++)
//                {
//                    Console.Write('*');
//                }
//            }
//        }
//    }
//}

//Zadanie 5 - dodatkowe*
//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int exam = 57;


//            if(exam >= 0 && exam <= 39)
//            {
//                Console.WriteLine("Ocena Niedostateczna");
//            }
//            else if(exam >= 40 && exam <= 54)
//            {
//                Console.WriteLine("Ocena Dopuszczająca");
//            }
//            else if (exam >= 55 && exam <= 69)
//            {
//                Console.WriteLine("Ocena Dostateczna");
//            }
//            else if (exam >= 70 && exam <= 84)
//            {
//                Console.WriteLine("Ocena Dobra");
//            }
//            else if (exam >= 85 && exam <= 98)
//            {
//                Console.WriteLine("Ocena Bardzo Dobra");
//            }
//            else if (exam >= 99 && exam <= 100)
//            {
//                Console.WriteLine("Ocena Celująca");
//            }
//            else
//            {
//                Console.WriteLine("Wartość poza zakresem");
//            }
//        }
//    }
//}

//Zadanie 1 - Kolekcje
//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string[] colors = { "Niebieski", "Czerwony", "Żółty", "Czarny" };
//            Console.WriteLine("Mój pierwszy kolor to: " + colors[0]);
//            Console.WriteLine("Mój ostatni kolor to: " + colors[3]);
//        }
//    }
//}

//Zadanie 2
//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] liczby = { 1, 5, 10, 33, 40, 0, 12, 3, 100, 42 }; int j = 0;
//            for(int i = 0; i < 10; i++)
//            {
//                Console.WriteLine("Liczby: " + liczby[i]);
//            }

//            Console.WriteLine();

//            foreach(int i in liczby)
//            {
//                Console.WriteLine("Liczba: " + i);
//            }

//            Console.WriteLine();

//            while (j < 10)
//            {
//                Console.WriteLine("Liczba: " + liczby[j]);
//                j++;
//            }
//        }
//    }
//}

//Zadanie3
//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<string> fruits = new List<string>();
//            fruits.Add("Jabłko");
//            fruits.Add("Gruszka");
//            fruits.Add("Arbuz");
//            fruits.Add("Melon");

//            Console.Write(string.Join(", ", fruits));

//            fruits.RemoveAt(0);
//            fruits.Remove(fruits[fruits.Count - 1]);

//            Console.WriteLine();
//            Console.Write(string.Join(", ", fruits));
//        }
//    }
//}