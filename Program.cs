using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32.SafeHandles;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Numerics;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        #region для дальнейшего сохранения

        //public class Student
        //{
        //    public string FirstName = "Неизвестное имя";//default - null
        //    public string LastName = "Неизвестная фамилия";//default - null
        //    public int Age;//default - 0

        //    public void Print()
        //    {
        //        Console.WriteLine(FirstName + " " + LastName);
        //    }
        //}
        //Student num1 = new Student();
        //num1.FirstName = "John";//до заполнение значение было "Неизвестное имя"
        //num1.LastName = "Fenx";
        //num1.Age = 19;      
        ////Console.WriteLine(num1.FirstName + " " + num1.LastName);//John Fenx
        ////num1.Print();//John Fenx

        //Student num2 = new Student();
        //num2.FirstName = "Bill";//до заполнение значение было "Неизвестное имя"
        //num2.LastName = "Rines";
        //num2.Age = 25;

        //Student num3 = new Student();
        //num3.FirstName = "Ann";//до заполнение значение было "Неизвестное имя"
        //num3.LastName = "Abweh";
        //num3.Age = 22;

        //Student[] students = new Student[] { num1, num2, num3 };//массив экземпляров класса

        //for (int i = 0; i < students.Length; i++)
        //{
        //    students[i].Print();
        //}

        //Добавьте в данный класс метод PrintSmallInfo, который печатает 
        //на экран информацию об ученике в коротком виде: Юрий Быков - "Быков Ю."
        //public class Student
        //{
        //    public string FirstName = "Неизвестное имя";
        //    public string LastName = "Неизвестная фамилия";
        //    public void PrintSmallInfo()
        //    {
        //        Console.WriteLine($"{LastName} {FirstName[0]}.");
        //    }
        //}

        //Сделайте так, чтобы код заработал! Для этого 
        //создайте недостающие классы City и GeoLocation.
        //       public class City
        //       {
        //           public string Name;
        //           public GeoLocation Location;
        //       }
        //       public class GeoLocation
        //       {
        //           public double Latitude;
        //           public double Longitude;
        //       }
        //       City city = new City();
        //       city.Name = "Vladikavkaz";
        //city.Location = new GeoLocation();
        //       city.Location.Latitude = 43.0348;
        //city.Location.Longitude = 44.6798;
        //Console.WriteLine("I love {0} located at ({1}, {2})", city.Name, city.Location.Longitude, city.Location.Latitude)


        //Создайте класс Counter, экземпляры которого будут подсчитывать внутри себя значения.Подсчет начинается с нуля.
        //Необходимо создать: метод Increment, который увеличивает счетчик на 1.метод Show, который 
        //печатает фразу Текущее значение счетчика = < value >, где <value> текущее значение счетчика.
        //также метод Reset,  который обнуляет значение счетчика. также метод метод StartFrom, который 
        //задает значение счетчика переданным в параметре значением.
        //public class Counter
        //{
        //    public int Cnt = 0;
        //    public void Increment()
        //    {
        //        Cnt++;
        //    }
        //    public void Show()
        //    {
        //        Console.WriteLine($"Текущее значение счетчика = {Cnt}");
        //    }
        //    public void Reset()
        //    {
        //        Cnt = 0;
        //    }
        //    public void StartFrom(int x)
        //    {
        //        Cnt = x;
        //    }
        //}
        //Counter c1 = new Counter();
        //c1.Show(); // печатает "Текущее значение счетчика = 0"

        //    c1.Increment();
        //    c1.Show(); // печатает "Текущее значение счетчика = 1"

        //    c1.Increment();
        //    c1.Show();// печатает "Текущее значение счетчика = 2"

        //    c1.Reset();
        //    c1.Show(); // печатает "Текущее значение счетчика = 0"

        //    c1.Increment();
        //    c1.Increment();
        //    c1.Show(); // печатает "Текущее значение счетчика = 2"

        //    c1.StartFrom(5);
        //    c1.Show(); // печатает "Текущее значение счетчика = 5"

        //    c1.Increment();
        //    c1.Show(); // печатает "Текущее значение счетчика = 6"



        //defaul constructor
        //public class User
        //{
        //    public string Name;
        //    public string PhoneNumber;
        //    public User()
        //    {
        //        Name = "Поликарп";
        //        PhoneNumber = "+7(000)000 00 00";
        //    }
        //}


        //constructor that takes arguments
        //public class User
        //{
        //    public string Name;
        //    public string PhoneNumber;
        //    public User(string name, string phone)
        //    {
        //        Name = name;
        //        PhoneNumber = phone;
        //    }
        //}
        //User josh = new User("Josh", "+7(999)123421");


        //Создайте класс Person, у которого есть: конструктор, принимающий 3 
        //параметра: firstName, lastName, age ; метод GetFullName, который возвращает
        //строку в виде<Фамилия> <Имя>;  метод IsAdult, который возвращает True, если человек 
        //достиг 18 лет и False в противном случае.
        //public class Person
        //{
        //    public string FirstName;
        //    public string LastName;
        //    public int Age;
        //    public Person(string firstName, string lastName, int age)
        //    {
        //        FirstName = firstName;
        //        LastName = lastName;
        //        Age = age;
        //    }
        //    public string GetFullName()
        //    {
        //        return LastName + " " + FirstName;
        //    }
        //    public string IsAdult()
        //    {
        //        return Age >= 18 ? "True" : "False";
        //    }
        //}
        //Person person = new Person("Иосиф", "Дзеранов", 26);
        //Console.WriteLine(person.GetFullName()); // выводит Дзеранов Иосиф
        //    Console.WriteLine(person.IsAdult()); // выводит True​

        //Создайте класс Dog, у которого есть: конструктор, принимающий 
        //2 аргумента: name, age.; метод GetDescription, который возвращает строку 
        //в виде<name> is <age> years old.; метод Speak принимающий один аргумент<sound>, 
        //который возвращает строку вида <name> says<sound>.
        //public class Dog
        //{
        //    public string Name;
        //    public int Age;
        //    public Dog(string name, int age)
        //    {
        //        Name = name;
        //        Age = age;
        //    }
        //    public string GetDescription()
        //    {
        //        return $"{Name} is {Age} years old"; 
        //    }
        //    public string Speak(string sound)
        //    {
        //        return $"{Name} says {sound}";
        //    }
        //}
        //Dog dog = new Dog("Песик", 2);
        //Console.WriteLine(dog.GetDescription()); // распечатает Песик is 2 years old
        //    Console.WriteLine(dog.Speak("Woof Woof")); // распечатает Песик says Woof Woof
        //    Console.WriteLine(dog.Speak("Bow Wow")); // распечатает Песик says Bow Wow


        //Создайте класс Point, у которого есть: конструктор, принимающий 2 аргумента 
        //целочисленного типа: x, y. ;метод Print, который возвращает строку в виде(x, y). 
        //Будьте внимательны: внутри скобок между x и y НЕТ пробела.;;; метод CalculateDistance 
        //принимающий один аргумент otherPoint типа Point, который возвращает расстояние между 
        //двумя точками. Будьте внимательны: расстояние может быть числом вещественным.
        //public class Point
        //{
        //    public int X;
        //    public int Y;
        //    public Point(int x, int y)
        //    {
        //        X = x;
        //        Y = y;
        //    }
        //    public string Print()
        //    {
        //        return $"({X},{Y})";
        //    }
        //    public double CalculateDistance(Point otherPoint)
        //    {
        //        return Math.Sqrt(Math.Pow((otherPoint.X - X), 2) + Math.Pow((otherPoint.Y - Y), 2));
        //    }
        //}
        //Point p1 = new Point(1, 2);
        //Console.WriteLine(p1.Print()); // распечатает (1,2)
        //    Point p2 = new Point(4, 6);
        //Console.WriteLine(p2.Print()); // распечатает (4,6)
        //    Console.WriteLine(p1.CalculateDistance(p2)); // распечатает 5
        //    Console.WriteLine(p2.CalculateDistance(p1)); // распечатает 5    


        //Создайте класс FootballPlayer, у которого есть: //Поле Name – имя футболиста //Поле Surname – фамилия футболиста
        //Поле Goals – общее количество голов футболиста //Поле Assists – общее количество передач футболиста 
        //Конструктор, принимающий 2 аргумента: name, surname.При создании футболиста общее 
        //количество голов и передач футболиста должны быть 0. //Метод AddScore, который принимает количество голов, 
        //забитых футболистом.Метод должен //увеличить общее количество забитых голов футболиста на переданное значение.
        //Метод AddAssists, который принимает количество передач, сделанных футболистом за матч. 
        //Метод должен увеличить общее количество сделанных передач футболистом на переданное значение.
        //Метод ShowStatistics, который вывод на экран статистику футболиста в виде: <Фамилия> <Имя> - голы: <Goals>, передачи: <Assists>
        //public class FootballPlayer
        //{
        //    public string Name;
        //    public string Surname;
        //    public int Goals;
        //    public int Assists;

        //    public FootballPlayer(string name, string surname)
        //    {
        //        Name = name;
        //        Surname = surname;
        //    }
        //    public int AddScore(int goals)
        //    {
        //        return Goals += goals;
        //    }
        //    public int AddAssists(int assists)
        //    {
        //        return Assists += assists;
        //    }
        //    public void ShowStatistics()
        //    {
        //        Console.WriteLine($"{Surname} {Name} - голы: {Goals}, передачи: {Assists}");
        //    }
        //}
        //FootballPlayer cristianoRonaldo = new FootballPlayer("Cristiano", "Ronaldo");
        //cristianoRonaldo.AddScore(711);
        //    cristianoRonaldo.AddAssists(169);
        //    cristianoRonaldo.ShowStatistics(); // выводит "Ronaldo Cristiano - голы: 711, передачи: 169"

        //    FootballPlayer lionelMessi = new FootballPlayer("Lionel", "Messi");
        //lionelMessi.AddScore(682);
        //    lionelMessi.AddAssists(240);
        //    lionelMessi.ShowStatistics(); // выводит "Messi Lionel - голы: 682, передачи: 240"

        //перегрузка конструкторов
        //public class MyClass
        //{
        //    public string Field1;
        //    public int Field2;
        //    public bool Field3;
        //    public MyClass(string f1)
        //    {
        //        Field1 = f1;
        //    }
        //    public MyClass(string f1, int f2)
        //    {
        //        Field1 = f1;
        //        Field2 = f2;
        //    }

        //    public MyClass(string f1, int f2, bool f3)
        //    {
        //        Field1 = f1;
        //        Field2 = f2;
        //        Field3 = f3;
        //    }
        //}


        //ключевое слово this и вызов конструктора из другого конструктора для укорачивания кода
        //(this не работает в статических методах, поскольку там не создаются экземпляры класса)
        //public class Phone
        //{
        //    public string Name; // название
        //    public int Price; // цена в рублях
        //    public int Memory; // объем памяти в ГБ
        //    public bool IsAvailable; // доступна или нет
        //    public Phone(string name)
        //    {
        //        Name = name;
        //        Price = 5000;
        //        Memory = 8;
        //        IsAvailable = true;
        //    }
        //    public Phone(string name, int price) : this(name)
        //    {
        //        Price = price;
        //        Memory = 8;
        //        IsAvailable = true;
        //    }
        //    public Phone(string name, int price, int memory): this(name, price)
        //    {
        //        Memory = memory;
        //        IsAvailable = true;
        //    }
        //    public Phone(string name, int price, int memory, bool isAvailable): this(name, price, memory)
        //    {
        //        IsAvailable = isAvailable;
        //    }
        //}

        //Без использования среды программирования, напишите, что выведет программа? ответ :4 3 2 1 
        //public class Phone
        //{
        //    public string Name; // название
        //    public int Price; // цена в рублях
        //    public int Memory; // объем памяти в ГБ
        //    public bool IsAvailable; // доступна или нет

        //    public Phone(string name) : this(name, 5000)
        //    {
        //        Console.Write("1 ");
        //    }

        //    public Phone(string name, int price) : this(name, price, 8)
        //    {
        //        Console.Write("2 ");
        //    }

        //    public Phone(string name, int price, int memory) : this(name, price, memory, true)
        //    {
        //        Console.Write("3 ");
        //    }
        //    public Phone(string name, int price, int memory, bool isAvailable)
        //    {
        //        Name = name;
        //        Price = price;
        //        Memory = memory;
        //        IsAvailable = isAvailable;
        //        Console.Write("4 ");
        //    }
        //}
        //Phone phone = new Phone("Honor");


        //инициализатор
        //public class Phone
        //{
        //    public string Name; // название
        //    public int Price; // цена в рублях
        //    public int Memory; // объем памяти в ГБ
        //    public bool IsAvailable; // доступна или нет
        //}
        //Phone myPhone = new Phone()
        //{
        //    Name = "iPhone 12 mini",
        //    Price = 70000,
        //    Memory = 128,
        //    IsAvailable = true
        //};
        //Console.WriteLine(myPhone.IsAvailable);


        ////копирование экземпляра класса с помощью конструктора принимающего другой экземпляр
        //public class Phone
        //{ 
        //    public string Name; // название
        //    public int Price; // цена в рублях
        //    public int Memory; // объем памяти в ГБ
        //    public bool IsAvailable; // доступна или нет
        //public Phone(string name)
        //{
        //    Name = name;
        //    Price = 5000;
        //    Memory = 8;
        //    IsAvailable = true;
        //}
        //public Phone(string name, int price) : this(name)
        //{
        //    Price = price;
        //    Memory = 8;
        //    IsAvailable = true;
        //}
        //public Phone(Phone phone)
        //    {
        //        Name = phone.Name;
        //        Price = phone.Price;
        //        Memory = phone.Memory;
        //        IsAvailable = phone.IsAvailable;
        //    }
        //    Phone honor1 = new Phone("Honor");
        //    //Phone honor2 = honor1;//ТЕПЕРЬ ЛЮБОЕ ИЗМЕНЕНИЕ HONOR2 ИЗМЕНИТ HONOR1 (ССЫЛОЧНЫЙ ТИП) - НЕЛЬЗЯ ТАК ДЕЛАТЬ
        //    //Phone honor2 = new Phone(honor1);//КОПИРУЕМ, В КУЧЕ СОЗДАЕТСЯ ДРУГОЙ ОБЪЕКТ
        //    //honor2.Name = "Honor_2";
        //    Console.WriteLine(honor1.Name);//Honor
        //    Console.WriteLine(honor2.Name);//Honor_2
        #endregion

        public class School
        {
            public string SchoolName;

            public List<Student> Students;
            public School(string schoolName)
            {
                SchoolName = schoolName;
                Students = new List<Student>();
            }
            public void AddNewStudent(Student student)
            {
                Students.Add(student);
                Console.WriteLine("");
                Console.WriteLine($"Ученик {student.FirstName} {student.LastName} успешно добавлен в школу {SchoolName}");
            }
            public void DeleteStudent(int index)
            {
                if (index > 0 & index <= Students.Count)
                {
                    Students.Remove(Students[index - 1]);
                    Console.WriteLine("");
                    Console.WriteLine($"Ученик с порядковым номером  {index}  успешно удалён.");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Студента с таким номером не существует");
                }
            }
            public void PrintStudents()
            {
                if (Students.Count == 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"В школе {SchoolName} пока нет учеников!");
                }
                else
                {
                    for (int i = 0; i < Students.Count; i++)
                    {
                        Console.WriteLine($"\t{i + 1}: {Students[i].FirstName} {Students[i].LastName} ({Students[i].Age})");
                    }  
                }
            }
        }
        public class Student
        {
            public string FirstName;
            public string LastName;
            public int Age;
            public Student(string firstname, string lastname, int age)
            {
                FirstName = firstname;
                LastName = lastname;
                Age = age;
            }
        }
        static void Main(string[] args)
        {

            #region Для дальнейшего сохранения 


            //Напишите программу, которая в
            //последовательности трехзначных чисел находит
            //количество всех чисел сумма цифр которых равна 8.
            //int cnt = 0;
            //for (int i = 100; i < 1000; i++)
            //{
            //    int a = i % 10;
            //    int b = i / 10 % 10;
            //    int c = i / 100;

            //    if (a + b + c == 8)
            //    {
            //        cnt++;
            //    }
            //}
            //Console.Write(cnt);


            /* Совершенное число — натуральное число, равное сумме всех своих собственных делителей 
             Напишите программу, которая будет искать совершенные числа. */
            //int sum = 0;
            //for (int i = 1; i < 1000; i++)
            //{
            //    sum = 0;
            //    for (int z = 1; z < i; z++)
            //    {
            //        if (i % z == 0)
            //        {
            //            sum = sum + z;
            //        }
            //    }
            //    if (sum == i)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //о данному числу определите, является ли оно палиндромом
            //Вывести "YES", если число является палиндромом, в противном случае -"NO".
            //int n = Convert.ToInt32(Console.ReadLine());
            //int x = n;
            //int sum = 0;
            //while (n != 0)
            //{
            //    int z = n % 10;
            //    sum = sum * 10 + z;
            //    n = n / 10;
            //}
            //if (x == sum)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}


            //Из данного числа выбросите цифры 5 5 5 и 7 7 7 , при этом порядок остальных цифр не меняется.
            //int n = Convert.ToInt32(Console.ReadLine());
            //int sum1 = 0;
            //int sum2 = 0;
            //while (n > 0)
            //{
            //    {
            //        int a = n % 10;
            //        n = n / 10;
            //        if (a == 5 || a == 7)
            //        {
            //            continue;
            //        }
            //        sum1 = sum1 * 10 + a;
            //        a = sum1;
            //    }
            //}
            //while (sum1 > 0)
            //{
            //    {
            //        int b = sum1 % 10;
            //        sum1 = sum1 / 10;
            //        if (b == 5 || b == 7)
            //        {
            //            continue;
            //        }
            //        sum2 = sum2 * 10 + b;
            //    }
            //}
            //Console.WriteLine(sum2);           

            //Найдите количество минимальных элементов в последовательности.
            //int n = Convert.ToInt32(Console.ReadLine());
            //int cnt = 0;
            //int min = 100000;
            //for (int i = 1; i <= n; i++)
            //{
            //    int Number = Convert.ToInt32(Console.ReadLine());
            //    if (Number < min)
            //    {
            //        min = Number;
            //        cnt = 0;
            //    }
            //    if (Number == min)
            //    {
            //        cnt++;
            //    }
            //}
            //Console.WriteLine(cnt);

            //int a = Convert.ToInt32(Console.ReadLine());
            //int n = Convert.ToInt32(Console.ReadLine());
            //int z = a;
            //for (int i = 1; i < n; i++)
            //{
            //    z = z * a;
            //}
            //if (n != 0)
            //{
            //    Console.WriteLine(z);
            //}
            //else
            //{
            //    Console.WriteLine("1");
            //}


            //int n = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;

            //while (n > 0)
            //{
            //    sum = 0;
            //    while (sum > 10)
            //    {
            //        int z = n % 10;
            //        sum = sum + z;
            //        n = n / 10;
            //    }
            //    sum = n;

            //}
            //Console.WriteLine(sum);


            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int cnt = 0;
            //for (int i = b; i >= a; i--)
            //{
            //    if (i % 7 == 0)
            //    {
            //        Console.WriteLine(i);
            //        cnt++;
            //        break;
            //    }
            //}
            //if (cnt == 0)
            //{
            //    Console.WriteLine("NO");
            //}

            //char k = 'L';
            //int code = (int)k;
            //Console.WriteLine(code);

            //int codes = 35;
            //char c = (char)codes;
            //Console.WriteLine(c);

            //char first = '#';
            //char second = '$';
            //Console.WriteLine(second < first);

            //k = (char)(k + 2); 
            //Console.Write(k);

            //for (char q = 'A'; q <= 'Z'; q++)
            //{
            //    int z = (int)q;
            //    Console.WriteLine(z);
            //}

            //for (int q = 65; q <= 90; q++)
            //{
            //    char z = (char)q;
            //    Console.WriteLine(z);
            //}

            //char a = Convert.ToChar(Console.ReadLine());
            //int z = (int)a;
            //if (z >= 48 & z <= 57)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            //По заданной строчной букве латинского алфавита, выведите все 
            //строчные буквы латинского алфавита, начиная от начала до заданной буквы.
            //char z = Convert.ToChar(Console.ReadLine());
            //for (char i = 'a'; i <= z; i++)
            //{
            //    Console.Write(i + " ");
            //}   

            //выведите все строчные буквы латинского алфавита, 
            //начиная от заданной буквы до конца алфавита.
            //char r = Convert.ToChar(Console.ReadLine());
            //for (char i = 'z'; i >= r; r++) НЕ ЗАБЫВАЙ ЧТО ВВОДИМУЮ ПЕРЕМЕННУЮ 
            //{                               ТОЖЕ МОЖНО СТАВИТЬ В ИНКРЕМЕНТ/ДИКРЕМЕНТ
            //    Console.Write(r + " ");
            //}

            //Измените регистр символа, если он был латинской буквой: 
            //сделайте его заглавным, если он был строчной буквой, и наоборот.
            //char r = Convert.ToChar(Console.ReadLine());
            //int z = (int)r;
            //if (z >= 65 & z <= 90) ЭТА ЗАДАЧА ТАКЖЕ РЕШАЕТСЯ ЧЕРЕЗ SWITCH CASE
            //{
            //    int q = z + 32;
            //    char t = (char)q;                
            //    Console.WriteLine(t);
            //}
            //if (z >= 97 & z <= 122)
            //{
            //    int q = z - 32;
            //    char t = (char)q;
            //    Console.WriteLine(t);
            //}

            //string s = "Hi, Baby!";
            //Console.WriteLine(s.Length); УЗНАТЬ КОЛИЧЕСТВО СИМВОЛОВ
            //string x = "Baby Bon!";
            //string c = s + x;  СТРОКИ МОЖНО СКЛАДЫВАТЬ
            //string a = x + s;  ВЫВОД ПРИ СЛОЖЕНИИ ЗАВИСИТ ОТ ПОРЯДКА СЛОГАЕМЫХ
            //Console.WriteLine(a);
            //bool q = s == x;   СТРОКИ МОЖНО СРАВНИВАТЬ (ЦЕЛИКОМ ДО СИМВОЛА)
            //Console.WriteLine(q);

            //string v = "Gilgamesh"; 
            //int count = v.Length;
            //char b = v[8];     ОБРАЩЕНИЕ К ИНДЕКСУ, ЧТОБЫ УЗНАТЬ ЭЛЕМЕНТ
            //Console.WriteLine(v[count - 1]); ИНДЕКС СТРОКИ = КОЛ-ВО СИМВОЛОВ СТРОКИ - 1

            //Дана строка, содержащая пробелы.Найдите, сколько в ней слов.
            //string s = Console.ReadLine();
            //int count = s.Length;
            //int cnt = 0;
            //for (int index = 0; index <= count - 1; index++)
            //{
            //    if (s[index] == ' ')
            //    {
            //        cnt++;
            //    }
            //}
            //Console.WriteLine(cnt + 1);

            //Дана строка. Найдите перевернутую ей строку.
            //string s = Console.ReadLine();
            //int count = s.Length;
            //for (int index = count - 1; index >= 0; index--)
            //{
            //    Console.Write(index);
            //}

            //Дана строка. Определите, какой символ в ней встречается 
            //раньше: 'x' или 'w'.Если таких символов нет, вывести "-1".
            //string s = Console.ReadLine();
            //int k = s.Length;
            //int cnt = 0;
            //for (int index = 0; index <= k - 1; index++)
            //{
            //    if (s[index] == 'w')
            //    {
            //        cnt++;
            //        Console.WriteLine("w");
            //        break;
            //    }
            //    else if (s[index] == 'x')
            //    {
            //        cnt++;
            //        Console.WriteLine("x");
            //        break;
            //    }                          
            //}
            //if (cnt == 0)
            //{
            //    Console.WriteLine("-1");
            //}

            //По данной строке, найдите ее k - ый символ.
            //string s = Console.ReadLine();
            //int k = Convert.ToInt32(Console.ReadLine());
            //int z = s.Length;
            //if (k <= z & k > 0)
            //{
            //    Console.WriteLine(s[k - 1]);
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            //По данным ФИО сформируйте строку, содержащую фамилию 
            //с инициалами. Например, по ‘Ivanov Ivan Ivanovich’ получите "Ivanov I.I.".
            //string a = Console.ReadLine();
            //string b = Console.ReadLine();
            //string c = Console.ReadLine();
            //Console.Write(a + " " + b[0] + "." + c[0] + ".");


            //Даны две строки.Верно ли, что первая строка начинается на ту же букву, 
            //на которую заканчивается вторая строка? 
            //Регистр букв имеет значение, то есть 'a' и 'A' считаются разными буквами.
            //string a = Console.ReadLine();
            //string b = Console.ReadLine();
            //int z = b.Length;
            //if (a[0] == b[z - 1])
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            //Дано предложение, составленное из строчных букв латинского алфавита.
            //Определить, сколько в нем гласных букв.Гласными считаются буквы a, e, i, o, u.
            //string a = Console.ReadLine();
            //int z = a.Length;
            //int cnt = 0;
            //for (int index = 0; index <= z - 1; index++)
            //{
            //    if (a[index] == 'a' || a[index] == 'e' || a[index] == 'i' || a[index] == 'o' || a[index] == 'u')
            //    {
            //        cnt++;
            //    }
            //}
            //Console.WriteLine(cnt);

            //Дан текст, составленный из букв латинского алфавита и цифр. 
            //Напечатать все имеющиеся в нем цифры.
            //string a = Console.ReadLine();
            //int z = a.Length;
            //for (int index = 0; index <= z - 1; index++)
            //{
            //    if (a[index] >= '0' && a[index] <= '9')
            //    {
            //        Console.Write(a[index] + " ");
            //    }
            //}

            //int[] a = new int[8]; 
            //a[0] = 5;
            //a[2] = 3;
            //Console.WriteLine(a[0]); //содержимое ячейки узнается по ее индексу
            //Console.WriteLine(a.Length);// узнать размерность массива


            //int[] array = new int[5];
            //array[1] = 3;
            //array[0] = 10;
            //int a = array[1];
            //Console.WriteLine(array.Length);

            //int[] array = new int[] { 1, 3, 6, 5 }; в скобках можно сразу задать содержание 
            //можно указать кол - во, а можно не указывать, можно даже не указывать тип данных

            //int[] array2 = Enumerable.Repeat(5, 10).ToArray();
            //повторять ввод одного числа в нужное кол - во ячеек


            //int[] array3 = Enumerable.Range(4, 5).ToArray();
            //увеличивать числа, начиная с введенного(включая), в нужное кол - во ячеек

            //int[] array = new int[] { 2, 12, 14, 5 };

            //for (int i = 0; i < array.Length; i++) //i используется в роли индекса элементов массива
            //{
            //    Console.WriteLine(array[i]); // переводим индексы в знаки массива, содержание
            //}

            // найдите сумму четных чисел в массиве
            // int[] array = new int[] { 1, 2, 3, 5, 7, 4 };
            // int sum = 0;
            // for (int index = array.Length - 1 ; index >= 0; index--)
            // {               
            //     if (array[index] % 2 == 0)
            //     {
            //         sum = sum + array[index];
            //     }                               
            // }
            //Console.WriteLine(sum);

            //найдите наименьшее число в массиве
            //int[] array = new int[] { 9, 2, 3, 5, 7, 4, 1 };
            //int min = array.Length;
            //for (int index = array.Length - 1; index >= 0; index--)
            //{
            //    if (array[index] < min)
            //    {
            //        min = array[index];
            //    }
            //}
            //Console.WriteLine(min);

            //Дан массив, состоящий из целых чисел.Напишите программу,
            //которая выведет элементы массива, индексы которых кратны трем(0, 3, 6...).
            //Сначала задано число N — количество элементов в массиве.
            //Далее через пробел записаны N чисел — элементы массива.
            //int n = Convert.ToInt32(Console.ReadLine());
            //string s = Console.ReadLine();
            //string[] array = s.Split(' ');
            //for (int index = 0; index < n; index++)
            //{
            //    if (index % 3 == 0)
            //    {
            //        Console.Write(array[index] + " ");
            //    }
            //}


            //Дан массив, состоящий из целых чисел.Напишите программу, которая подсчитает 
            //количество элементов массива, больших предыдущего(элемента с предыдущим номером).
            //Сначала задано число N — количество элементов в массиве.
            //Далее через пробел записаны N чисел — элементы массива.
            //int n = Convert.ToInt32(Console.ReadLine());
            //string s = Console.ReadLine();
            //string[] array = s.Split(' ');
            //int cnt = 0;    
            //for (int index = 0; index < n - 1; index++)
            //{
            //    int z = Convert.ToInt32(array[index]);
            //    int c = Convert.ToInt32(array[index + 1]);
            //    if (c > z)
            //    {
            //        cnt++;
            //    }
            //}
            //Console.Write(cnt);

            //Дан массив, состоящий из целых чисел.Напишите программу, которая определяет, 
            //есть ли в массиве пара соседних элементов с одинаковыми знаками.
            //Сначала задано число N N N — количество элементов в массиве
            //Далее через пробел записаны N N N чисел — элементы массива.
            //int n = Convert.ToInt32(Console.ReadLine());
            //string s = Console.ReadLine();
            //string[] array = s.Split(' ');
            //int cnt = 0;
            //for (int index = 0; index < n - 1; index++)
            //{
            //    int z = Convert.ToInt32(array[index]);
            //    int x = Convert.ToInt32(array[index + 1]);
            //if (z > 0 & x > 0 || z < 0 & x < 0)
            //    {
            //        cnt++;
            //    }
            //}
            //if (cnt > 0)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            //Напишите программу, которая циклически сдвигает элементы
            //массива вправо.Например, если элементы нумеруются, начиная с нуля, 
            //то 0 - й элемент становится 1 - м, 1 - й становится 2 - м, ..., последний
            //становится 0 - м, то есть массив [3, 5, 7, 9] превращается в массив[9, 3, 5, 7]. 

            //======= "НЕЧЕСТНАЯ" ВЕРСИЯ=========
            //int n = Convert.ToInt32(Console.ReadLine());
            //string s = Console.ReadLine();
            //string[] array = s.Split(' ');
            //Console.Write(array[n - 1] + " ");
            //for (int index = 0; index < n - 1; index++)
            //{
            //    Console.Write(array[index] + " ");
            //}
            //======== "ЧЕСТНАЯ" ВЕРСИЯ ==========
            //int n = Convert.ToInt32(Console.ReadLine());
            //string s = Console.ReadLine();
            //string[] array = s.Split(' ');
            //for (int index = 0; index < n - 1; index++)
            //{
            //    string z = array[index];
            //    array[index] = array[index + 1];
            //    array[index + 1] = z;
            //}
            //for (int index = 0; index < n; index++)
            //{
            //    Console.Write(array[index] + " ");
            //}
            //======= ВЕРСИЯ С ЦИКЛИЧЕСКИМ СДВИГОМ ВЛЕВО ======
            //----/ /-----
            //for (int index = n - 1; index > 0; index--)
            //{
            //    string z = array[index];
            //    array[index] = array[index - 1];
            //    array[index - 1] = z;
            //}
            //for (int index = 0; index < n; index++)
            //{
            //    Console.Write(array[index] + " ");
            //}

            //Дан массив, состоящий из целых чисел.Напишите программу, которая 
            //выведет индекс минимального элемента массива.Индексация начинается с нуля.
            //int n = Convert.ToInt32(Console.ReadLine());
            //string s = Console.ReadLine();
            //string[] array = s.Split(' ');
            //int minnum = Convert.ToInt32(array[0]); ;
            //int minindex = 0;
            //for (int index = 1; index < n; index++)
            //{               
            //    int z = Convert.ToInt32(array[index]);
            //    if (z < minnum)
            //    {
            //        minnum = z;
            //        minindex = index;
            //    }               
            //}
            //Console.WriteLine(minindex);

            //Дан массив, состоящий из целых чисел.Напишите программу, 
            //которая уменьшает все элементы массива на минимальный элемент.
            //int n = Convert.ToInt32(Console.ReadLine());
            //string s = Console.ReadLine();
            //string[] array = s.Split(' ');
            //int minnum = Convert.ToInt32(array[0]); ;            
            //for (int index = 0; index < n; index++)
            //{
            //    int z = Convert.ToInt32(array[index]);
            //    if (z < minnum)
            //    {
            //        minnum = z;                   
            //    }
            //}
            //for (int index = 0; index < n; index++)
            //{
            //    int x = Convert.ToInt32(array[index]) - minnum;
            //    Console.Write(x + " ");
            //}    

            //Дан массив, состоящий из целых чисел.Напишите программу, которая 
            //выведет разность индексов максимального и минимального элементов массива. 
            //int n = Convert.ToInt32(Console.ReadLine());
            //string s = Console.ReadLine();
            //string[] array = s.Split(' ');
            //int minnum = Convert.ToInt32(array[0]);
            //int maxnum = Convert.ToInt32(array[0]);
            //int minindex = 0;
            //int maxindex = 0;
            //for (int index = 0; index < n; index++)
            //{
            //    int z = Convert.ToInt32(array[index]);
            //    if (z < minnum)
            //    {
            //        minnum = z;
            //        minindex = index;
            //    }
            //}
            //for (int index = 0; index < n; index++)
            //{
            //    int z = Convert.ToInt32(array[index]);
            //    if (z > maxnum)
            //    {
            //        maxnum = z;
            //        maxindex = index;
            //    }
            //}
            //Console.WriteLine(maxindex - minindex);


            //Дан массив, состоящий из целых чисел.Напишите программу, которая 
            //меняет местами первый минимальный и последний максимальный 
            //элементы массива.Индексация начинается с нуля.
            //int n = Convert.ToInt32(Console.ReadLine());
            //string s = Console.ReadLine();
            //string[] array = s.Split(' ');
            //int nummax = Convert.ToInt32(array[0]);
            //int nummin = Convert.ToInt32(array[0]);
            //int indexmax = 0;
            //int indexmin = 0;
            //for (int index = 0; index < n; index++)
            //{
            //    int z = Convert.ToInt32(array[index]);
            //    if (z >= nummax)
            //    {
            //        nummax = z;
            //        indexmax = index;
            //    }
            //}
            //for (int index = 0; index < n; index++)
            //{
            //    int z = Convert.ToInt32(array[index]);
            //    if (z < nummin)
            //    {
            //        nummin = z;
            //        indexmin = index;
            //    }
            //}
            //for (int index = 0; index < n; index++)
            //{
            //    int v = Convert.ToInt32(array[index]);
            //    if (index == indexmax)
            //    {
            //        v = nummin;
            //    }
            //    if (index == indexmin)
            //    {
            //        v = nummax;
            //    }
            //    Console.Write(v + " ");
            //}

            //Дан массив, состоящий из целых чисел.Напишите программу, 
            //которая определяет является ли массив палиндромом.
            //То есть если перевернуть массив, то получится массив, равный первоначальному.                                        
            //int n = Convert.ToInt32(Console.ReadLine());
            //string s = Console.ReadLine();
            //string[] array = s.Split(' ');
            //int cnt = 0;
            //for (int index = 0; index < n; index++)
            //{
            //    if (array[index] == array[n - 1 - index])
            //    { 
            //        cnt++;
            //    }
            //}
            //if (cnt == n) Console.Write("YES");
            //else Console.Write("NO");

            //Дан массив, состоящий из целых чисел.Напишите программу, которая 
            //определяет, есть ли в массиве ХОТЯ БЫ два одинаковых элемента.
            //Необходимо вывести "YES", если в массиве существуют 
            //ХОТЯ БЫ два одинаковых элемента.В противном случае следует вывести "NO".
            //int n = Convert.ToInt32(Console.ReadLine());
            //string s = Console.ReadLine();
            //string[] array = s.Split(' ');
            //int cnt = 0;
            //for (int numbers = 0; numbers < n; numbers++)
            //{
            //    for (int index = 0; index < n; index++)
            //    {
            //        if (index != numbers & array[numbers] == array[index])
            //        {
            //            cnt++;
            //        }
            //    }
            //}
            //if (cnt > 0) Console.WriteLine("YES");
            //else Console.WriteLine("NO");


            //Дан список. Выведите те его элементы, которые 
            //встречаются в списке только один раз.
            //int n = Convert.ToInt32(Console.ReadLine());
            //string s = Console.ReadLine();
            //string[] array = s.Split(' ');
            //for (int numbers = 0; numbers < n; numbers++)
            //{
            //    int cnt = 0;                
            //    for (int index = 0; index < n; index++)
            //    {                  
            //        if (array[index] == array[numbers])
            //        {   
            //            cnt++;
            //        }                    
            //    }
            //    if (cnt == 1) Console.Write(array[numbers] + " ");
            //}

            //int[] a = new int[] { 1, 2, 18, 8, 14, 9, 23, 7, 51, 99 };
            //int i = 0;
            //int j = 9;
            //while (a[i] < 10)
            //{
            //    i = i + 1;
            //}
            //while (a[j] > 10)
            //{
            //    j = j - 1;
            //}
            //int t = a[i] - a[j];

            //int[,] gen = new int[4, 4];
            //Console.WriteLine(gen[2, 1]); //выйдет 0, не задано значение
            //gen[2, 3] = 34;
            //Console.WriteLine(gen[2, 3]); //выйдет 34

            //int[,] myArray = new int[4, 4]
            //{
            //    { 1, 3, 2, 1 },
            //    { 13, 25, 65, 4 },
            //    { 12, 21, 33, 15 },
            //    { 5, 65, 42, 9 }
            //};
            //Console.WriteLine(myArray[2, 3]); //выведет 15

            //foreach (var item in myArray) //перебирает элементы из структуры
            //{                             //с автоматическим присвоением типа 
            //    Console.Write(item + " ");
            //}

            //int[,] myArray = new int[4, 5]
            //{
            //    { 1, 3, 2, 1, 6 },
            //    { 13, 25, 65, 4, 43 },
            //    { 12, 21, 33, 15, 34 },
            //    { 5, 65, 42, 9, 18 }

            //};
            //Console.WriteLine(myArray.Rank); // эта команда показывает мерность массива
            //Console.WriteLine(myArray.Length);// показывает сколько чисел в массиве

            //Console.WriteLine(myArray.GetLength(1));// показывает количество элементов 
            //                              //в указанном измерении (0 - строки, 1 - столбцы)

            //int[,] myArray = new int[4, 5]
            //{
            //    { 1, 3, 2, 1, 6 },
            //    { 13, 25, 65, 4, 43 },
            //    { 12, 21, 33, 15, 34 },
            //    { 5, 65, 42, 9, 18 }
            //};
            //int height = myArray.GetLength(0);
            //int width = myArray.GetLength(1);
            //for (int y = 0; y < height; y++)
            //{
            //    for (int x = 0; x < width; x++)
            //    {
            //        Console.Write(myArray[y, x] + "\t");
            //    }
            //    Console.WriteLine();
            //}


            //ДВУМЕРНЫЙ МАССИВ С ГЕНЕРАЦИЕЙ СЛУЧАЙНЫХ ЧИСЕЛ
            //int[,] myArray = new int[4, 5];         
            //int height = myArray.GetLength(0);
            //int width = myArray.GetLength(1);
            //Random random = new Random();

            //for (int i = 0; i < height; i++)
            //{
            //    for (int j = 0; j < width; j++)
            //    {
            //        myArray[i, j] = random.Next(1000); //в ячейки встаю случайные числа до 1000
            //    }
            //}
            //for (int y = 0; y < height; y++)
            //{
            //    for (int x = 0; x < width; x++)
            //    {
            //        Console.Write(myArray[y, x] + "\t"); //перебор и вывод
            //    }
            //    Console.WriteLine();
            //}

            //ДВУМЕРНЫЙ МАССИВ С ВПИСАНИЕМ В НЕГО ЧИСЕЛ С КОНСОЛИ
            //int[,] myArray = new int[3, 4];
            //int height = myArray.GetLength(0);
            //int width = myArray.GetLength(1);
            //Random random = new Random();

            //for (int i = 0; i < height; i++)
            //{ 
            //    for (int j = 0; j < width; j++)
            //    {
            //        Console.WriteLine("i: " + i + " " + "j: " + j);
            //        myArray[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //for (int y = 0; y < height; y++)
            //{
            //    for (int x = 0; x < width; x++)
            //    {
            //        Console.Write(myArray[y, x] + "\t"); 
            //    }
            //    Console.WriteLine();
            //}

            //в консоль вводится число n.Создайте массив n×n и заполните его по следующему правилу:
            //-числа на диагонали, идущей из правого верхнего в левый нижний угол, равны 1;
            //-числа, стоящие выше этой диагонали, равны 0;
            //-числа, стоящие ниже этой диагонали, равны 2.
            //int n = Convert.ToInt32(Console.ReadLine()); 
            //int[,] gen = new int[n, n];           
            //for (int index1 = 0; index1 < n; index1++)
            //{
            //    for (int index2 = 0; index2 < n; index2++)
            //    {
            //        if (index1 + index2 == n - 1) gen[index1, index2] = 1;
            //        if (index1 + index2 > n - 1) gen[index1, index2] = 2;
            //        if (index1 + index2 < n - 1) gen[index1, index2] = 0;
            //        Console.Write(gen[index1, index2] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //Даны два числа n & m. Создайте двумерный массив A[n, m], 
            //заполните его таблицей умножения A[i, j] = i*j, и выведите на экран.
            //string s = Console.ReadLine(); //ввод строки
            //string[] ss = s.Split(' '); //создание массива (по другому никак)
            //int n = Convert.ToInt32(ss[0]); //кол-во строк - это первое число массива ss
            //int m = Convert.ToInt32(ss[1]);
            //int[,] a = new int[n, m];

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        a[i, j] = (i + 1) * (j + 1);

            //        Console.Write(a[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Даны два числа n  и  m. Создайте двумерный массив A[n, m] 
            //и заполните его по следующим правилам: 
            //Числа, стоящие в строке 0 или в столбце 0 равны 1. 
            //Для всех остальных элементов массива-элемент равен 
            //сумме двух элементов, стоящих слева и сверху от него.
            //string s = Console.ReadLine();
            //string[] ss = s.Split(' ');
            //int n = Convert.ToInt32(ss[0]);
            //int m = Convert.ToInt32(ss[1]);
            //int[,] gen = new int[n, m];
            //for (int i = 0; i < n; i++)
            //{
            //    for (int g = 0; g < m; g++)
            //    {
            //        if (i == 0 || g == 0)
            //        {
            //            gen[i, g] = 1;
            //        }
            //        else
            //        {
            //            gen[i, g] = gen[i, g - 1] + gen[i - 1, g];
            //        }                   
            //        Console.Write(gen[i, g] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Дано целое число N и набор из N целых чисел. 
            //Вывести все четные числа из данного набора, далее на 
            //новой строке выведите количество этих чисел
            //int n = Convert.ToInt32(Console.ReadLine());
            //string s = Console.ReadLine();
            //string[] array = s.Split(' ');
            //int cnt = 0;
            //for (int index = 0; index < n; index++)
            //{
            //    int z = Convert.ToInt32(array[index]);
            //    if (z % 2 == 0)
            //    {
            //        cnt++;
            //        Console.Write(z + " ");
            //    }            
            //}
            //Console.WriteLine();
            //Console.WriteLine(cnt);

            //Дан одномерный массив, состоящий из целых чисел.
            //Напишите программу, которая подсчитает количество
            //элементов массива, которые меньше следующего за ним элемента.
            //int n = Convert.ToInt32(Console.ReadLine());
            //string s = Console.ReadLine();
            //string[] array = s.Split(' ');
            //int cnt = 0;
            //for (int g = 0; g < n - 1; g++)
            //{
            //    int z = Convert.ToInt32(array[g]);
            //    int c = Convert.ToInt32(array[g + 1]);
            //    if (z < c) cnt++;
            //}
            //Console.WriteLine(cnt);

            //Дан список положительных целых чисел.Найдите все числа кратные 3 
            //и при этом оканчивающиеся на 7, и замените каждое из этих 
            //чисел на их количество в массиве.
            //int n = Convert.ToInt32(Console.ReadLine());
            //string s = Console.ReadLine();
            //string[] array = s.Split(' ');
            //int cnt = 0;
            //for (int g = 0; g < n; g++)
            //{
            //    int z = Convert.ToInt32(array[g]);
            //    if (z % 3 == 0 & z % 10 == 7)
            //    {
            //        cnt++;                    
            //    }                               
            //}
            //for (int v = 0; v < n; v++)
            //{
            //    int z = Convert.ToInt32(array[v]);
            //    if (z % 10 == 7)
            //    {
            //        z = cnt;
            //    }
            //    Console.Write(z + " ");
            //}


            //Дан список чисел.Определите, есть ли в нем два противоположных
            //(то есть дающих в сумме 0) числа.Если такие числа есть в массиве,
            //выведите их индексы в порядке возрастания.Если таких
            //чисел в массиве нет, ничего не выводите. 
            //int n = Convert.ToInt32(Console.ReadLine());
            //string s = Console.ReadLine();
            //string[] array = s.Split(' ');
            //for (int i = 0; i < n; i++)
            //{
            //    int ii = Convert.ToInt32(array[i]);
            //    for (int g = 0; g < n; g++)
            //    {
            //        int gg = Convert.ToInt32(array[g]);
            //        if (gg + ii == 0 & gg != 0 & ii != 0)
            //        {
            //            Console.Write(i + " ");
            //        }
            //    }
            //}


            //static int func(int a, int b)// тип - имя - аргументы
            //{
            //    int sum = a + b;
            //    return sum; // эта функция возвращает значение
            //}
            //int v = 3; int n = 8; // переменные можно назвать как угодно
            //int summa = func(v, n);// вызов функции 
            //Console.WriteLine(summa);
            //Console.WriteLine(func(100, 25));


            //static void x(string name) // с типом void функция ничего не возвращает 
            //{
            //    Console.Write("Hello, " + name); // эта функция не возвращает значение
            //}
            //string k = "Sasha"; // переменную можно назвать как угодно
            //x(k); // вызов функции


            //static void greetings() //функция, не принимающая аргументов 
            //{
            //    Console.WriteLine("Hello, World!"); //это не напишется, если не вызвать
            //}
            //greetings(); //вызов функции 


            //Вводится одно натуральное число n;
            //Необходимо вывести "prime", если число простое, 
            //или "composite", если число составное.
            //static int z(int number)
            //{
            //    int w = 0;
            //    for (int i = 1; i < number; i++)
            //    {
            //        if (number % i == 0)
            //        {
            //            w++;
            //        }
            //    }
            //    return w;
            //}
            //int n = Convert.ToInt32(Console.ReadLine());
            //if (z(n) > 1)
            //{
            //    Console.WriteLine("composite");
            //}
            //else Console.WriteLine("prime");


            //Вводятся два числа a и b на одной строке.
            //Найдите значение z = sign(a) + sign(b), где
            //(x < 0) x = -1;
            //(x == 0) x = 0;
            //(x > 0) x = 1;
            //============================
            //static int sign (int x)
            //{
            //    if (x < 0) x = -1;
            //    if (x == 0) x = 0;
            //    if (x > 0) x = 1;
            //    return x;
            //}
            //string s = Console.ReadLine();
            //string[] ss = s.Split(' ');
            //int a = Convert.ToInt32(ss[0]);
            //int b = Convert.ToInt32(ss[1]);
            //Console.WriteLine(sign(a) + sign(b));


            //Напишите функцию, возводящую число a в степень n.
            //Вводится 2 числа - вещественное число a и целое число n, 
            //при этом число n может быть отрицательным.
            //static double step(double a, double n)
            //{
            //    double q = 1;
            //    for (int i = 1; i <= Math.Abs(n); i++)
            //    {
            //        q = q * a;
            //    }
            //    if (n > 0) return q;
            //    if (n < 0) return 1 / q;

            //    return 1;
            //}
            //string s = Console.ReadLine();
            //string[] ss = s.Split(' ');
            //double a = Convert.ToDouble(ss[0]);
            //double n = Convert.ToDouble(ss[1]);
            //Console.WriteLine(step(a, n));


            //static int nod(int a, int b)
            //{
            //    while (a != 0 & b != 0)
            //    {
            //        if (a > b) a = a % b;
            //        if (b > a) b = b % a;
            //    }
            //    return (a + b);
            //}


            //Дано N чисел.Найти самое большое число, на которое 
            //делятся все N чисел, учитывая что НОД(a, b, c) = НОД(НОД(a, b), c).
            //static int Nod(int a, int b)
            //{
            //    while (a != 0 & b != 0)
            //    {
            //        if (a > b) a = a % b;
            //        else b = b % a;
            //    }
            //    return (a + b);
            //}
            //int n = Convert.ToInt32(Console.ReadLine());
            //string s = Console.ReadLine();
            //string[] ss = s.Split(' ');
            //if (n == 1)
            //{
            //    for (int index = Convert.ToInt32(ss[0]); index > 1; index--)
            //    {
            //        int q = Convert.ToInt32(ss[0]);
            //        if (q % index == 0)
            //        {   
            //            Console.WriteLine(index);
            //            break;
            //        }
            //    }
            //}
            //if (n == 2)
            //{
            //    for (int index = 0; index < n - 1; index++)
            //    {
            //        int z = Convert.ToInt32(ss[index]);
            //        int v = Convert.ToInt32(ss[index + 1]);
            //        Console.WriteLine(Nod(z, v));
            //    }
            //}
            //if (n >= 3)
            //{
            //    for (int index = 0; index < n - 2; index++)
            //    {
            //        int z = Convert.ToInt32(ss[index]);
            //        int v = Convert.ToInt32(ss[index + 1]);
            //        int h = Convert.ToInt32(ss[index + 2]);
            //        Console.WriteLine(Nod(Nod(z, v), h));
            //        break;
            //    }              
            //}

            //Даны две последовательности.Первая: 1,2,3,...,n, 
            //а вторая: 1,2,3,...,m. Найдите средние арифметические обеих 
            //последовательностей и выведите их сумму.
            //Вводятся два натуральный числа : n, m.
            //static double summa(double n)
            //{
            //    double sum = 0;
            //    for (double i = 0; i <= n; i++)
            //    {
            //        sum = sum + i;
            //    }
            //    return sum;
            //}
            //double n = Convert.ToInt32(Console.ReadLine());
            //double m = Convert.ToInt32(Console.ReadLine());
            //double z = summa(n) / n + summa(m) / m;
            //Console.WriteLine(z);


            //Дано два натуральных числа. Найдите количество 
            //разрядов каждого из них и выведите их произведение.
            //static int raz(int g)
            //{
            //    int cnt = 0;
            //    while (g / 10 != 0)
            //    {
            //        cnt++;
            //        g = g / 10;
            //    }
            //    return cnt + 1;
            //}
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(raz(a) * raz(b));


            //С помощью этой функции вычислите суммы чисел от A до B 
            //и от B до C, если даны числа A,B,C. Затем найдите 
            //сумму найденных двух чисел.
            //static int range(int a, int b)
            //{
            //    int sum = 0;
            //    for (int i = a; i <= b; i++)
            //    {
            //        sum = sum + i;
            //    }
            //    return sum;
            //}            
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(range(a, b) + range(b, c));


            //По данному числу x x x, вычислить сумму ряда << здесь
            //приводится уравнение, смотреть его в работе над ошибками >>
            //static double res(double x)
            //{
            //    double sum = 0;
            //    int mult = 1;
            //    for (int i = 1; i <= 5; i++)
            //    {
            //        mult = mult * i;
            //        double q = ((-1) * i * (x / mult));
            //        sum = sum + q;
            //    }
            //    return sum;
            //}
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(res(x));

            //Дано два натуральных числа, не заканчивающиеся на 0.
            //Замените каждое число на обратное и вычислите их сумму. 
            //static int a(int x)
            //{
            //    int sum = 0;
            //    while (x > 0)
            //    {
            //        int z = x % 10;
            //        sum = sum * 10 + z;
            //        x = x / 10;
            //    }
            //    return sum;
            //}         
            //int v = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(a(v) + a(b));


            //Описать функцию Fact2(N), вычисляющую двойной факториал:
            //1⋅3⋅5⋅...⋅N, где N−нечетное
            //2⋅4⋅6⋅...⋅N, где N−четное​
            //static int fact2(int x)
            //{
            //    int dfact = 1;
            //    for (int i = 1; i <= x; i++)
            //    {
            //        if (x % 2 != 0)
            //        {
            //            if (i % 2 != 0) dfact = dfact * i;
            //            if (i % 2 == 0) continue;
            //        }
            //        if (x % 2 == 0)
            //        {
            //            if (i % 2 != 0) continue;
            //            if (i % 2 == 0) dfact = dfact * i;
            //        }
            //    }
            //    return dfact;
            //}
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //Console.Write(fact2(a) + " " + fact2(b) + " " + fact2(c));

            //Даны два натуральных числа a и b. Выяснить, в каком из
            //них сумма цифр больше. Если в первом, вывести "1",
            //если во втором, вывести "2", если суммы равны, вывести "0"
            //static int sum(int x)
            //{
            //    int sum = 0;
            //    while (x > 0)
            //    {
            //        int z = x % 10;
            //        sum = sum + z; //в отличии от выведения "перевертыша"
            //        x = x / 10;    //не нужно умножать sum на 10
            //    }
            //    return sum;
            //}
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //if (sum(a) > sum(b)) Console.WriteLine("1");
            //if (sum(a) < sum(b)) Console.WriteLine("2");
            //if (sum(a) == sum(b)) Console.WriteLine("0");


            //static int count(int x)
            //{
            //    int cnt = 0;
            //    while (x != 0) //отсчет влево, до тех пор пока первое 
            //    {              // число не окажется 0
            //        cnt++;    
            //        x = x / 10;
            //    }
            //    return cnt;
            //}
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //if (count(a) > count(b)) Console.WriteLine("1");
            //if (count(a) < count(b)) Console.WriteLine("2");
            //if (count(a) == count(b)) Console.WriteLine("0");


            //Даны два предложения(две строки).
            //Найти общее количество букв 'b' в них.
            //===========================
            //РЕШЕНИЕ С ФУНКЦИЕЙ:
            //static int z(string x)
            //{
            //    int cnt = 0;
            //    for (int index = 0; index < x.Length; index++)
            //    {
            //        if (x[index] == 'b') cnt++;
            //    }
            //    return cnt;
            //}
            //string a = Console.ReadLine();
            //string b = Console.ReadLine();
            //Console.WriteLine(z(a) + z(b));
            //================================
            //РЕШЕНИЕ БЕЗ ФУНКЦИИ:
            //int cnt = 0;
            //for (int index = 0; index < a.Length; index++)
            //{
            //    if (a[index] == 'b') cnt++;
            //}
            //for (int index = 0; index < b.Length; index++)
            //{
            //    if (b[index] == 'b') cnt++;
            //}
            //Console.WriteLine(cnt);


            //int n = Convert.ToInt32(Console.ReadLine());

            //int summax = 0;
            //int sum = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    sum = 0;
            //    while (i != 0)
            //    {
            //        int z = i % 10;
            //        sum = sum + i;
            //        n = n / 10;
            //    }
            //    if (sum > summax) summax = sum;
            //    Console.WriteLine(summax);
            //}

            //Среди натуральных чисел от 1 до N (включая N), найдите число 
            //наибольшее по сумме цифр. Вывести это число и сумму его цифр
            //на одной строке через пробел.
            //int n = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //int summax = 0;
            //int nummax = 0;
            //for (int i = 10; i <= n; i++)             
            //{
            //    sum = 0;
            //    int x = i;
            //    while (x != 0)
            //    {
            //        int z = x % 10;
            //        sum = sum + z;

            //        if (sum > summax)
            //        {
            //            summax = sum;
            //            if (i > nummax) nummax = i;                       
            //        }                    
            //        x = x / 10;
            //    }                    
            //}
            //Console.WriteLine(nummax + " " + summax);


            //Вывести представление целого числа N в виде произведения простых чисел.
            //Например, если на ввод дается число 30, вывод должен быть 2 3 5.
            //int n = Convert.ToInt32(Console.ReadLine());
            //int i = 2;
            //while (i <= n)
            //{
            //    if (n % i == 0)
            //    {
            //        n = n / i;
            //        Console.Write(i + " ");
            //    }
            //    else i++;
            //}

            //Найти цифровой корень числа N.
            //Например цифровой корень 65536 = 7, потому что 
            //6+5+5+3+6 = 25, а 2+5 = 7.
            //int n = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //int sum2 = 0;
            //int sum3 = 0;
            //while (n != 0)
            //{
            //    int z = n % 10;
            //    sum = sum + z;
            //    n = n / 10;
            //}
            //if (sum > 10)
            //{
            //    while (sum != 0)
            //    {
            //        int x = sum % 10;
            //        sum2 = sum2 + x;
            //        sum = sum / 10;
            //    }
            //    if (sum2 >= 10)
            //    {
            //        while (sum2 != 0)
            //        {
            //            int c = sum2 % 10;
            //            sum3 = sum3 + c;
            //            sum2 = sum2 / 10;
            //        }
            //        Console.WriteLine(sum3);
            //    }
            //    else Console.WriteLine(sum2);
            //}
            //else Console.WriteLine(sum);            

            //Автоморфное число — неотрицательное целое число, десятичная 
            //запись квадрата которого оканчивается цифрами самого этого числа.
            //Вводится число k, нужно найти все автоморфные числа от 0 до k включительно.
            //int k = Convert.ToInt32(Console.ReadLine());
            //int x;                              //переменная отвечает за рязряд числа 
            //for (int i = 0; i <= k; i++)
            //{
            //    string z = Convert.ToString(i); //перевод в строку, чтобы можно было подсчитать кол-во цифр
            //    x = z.Length;                   //длину строки принимаем за разряд числа (кол-во цифр в i)
            //    if (Math.Pow(i, 2) % Math.Pow(10, x) == i) //если остаток от деления квадрата числа i на 
            //                                               //10 в степени разряда числа равен самому числу i
            //    {
            //        Console.Write(i + " ");
            //    }
            //}


            //По данной строке определите, является ли она палиндромом? 
            //То есть, которое одинаково читается слева направо и справа налево.
            //На вход подается одна строка без пробелов.
            //string s = Console.ReadLine();
            //int cnt = 0;
            //for (int i = 0; i < s.Length / 2; i++)
            //{
            //    if (s[i] == (s[s.Length - i - 1])) //обрати внимание что требуется "- 1"
            //    {
            //        cnt++;
            //    }
            //}
            //if (cnt == s.Length / 2) Console.WriteLine("YES");
            //else Console.WriteLine("NO");

            //Дана строка. Известно, что она содержит ровно две одинаковые
            //буквы.Найдите эти буквы.Гарантируется, что повторяются
            //буквы только одного вида.
            //string s = Console.ReadLine();
            //int cnt = 0;
            //for (int i = 0; i < s.Length; i++)
            //{
            //    cnt = 0;
            //    for (int z = 0; z < s.Length; z++)
            //    {
            //        if (z != i & s[z] == s[i]) cnt++; //исключение совпадения первых элементов
            //    }                         //необязательно ставить, когда идет работа только с одним 
            //                              //повторяющимся символом, однако желательно сразу все делать как положено
            //    if (cnt > 0)
            //    {
            //        Console.WriteLine(s[i]);
            //        break;
            //    }
            //}

            //Определить, является ли введенное слово идентификатором, 
            //т.е.начинается ли оно с английской буквы в любом регистре или 
            //знака подчеркивания и не содержит других символов, кроме букв 
            //английского алфавита(в любом регистре), цифр и знака подчеркивания. 
            //РЕШЕНИЕ № 1 С МАССИВАМИ
            //char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz01234567890_".ToCharArray();
            //char[] z = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz_".ToCharArray();
            //string s = Console.ReadLine();
            //int cnt = 0;
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (letters.Any(letter => letter == s[i] & z.Any(z => z == s[0])))
            //    {
            //        cnt++;
            //    }
            //    else
            //    {
            //        Console.WriteLine("NO");
            //        cnt = 0;
            //        break;
            //    }
            //}
            //if (cnt > 0) Console.WriteLine("YES");
            //===============================================
            //РЕШЕНИЕ № 2 БЕЗ МАССИВОВ
            //string s = Console.ReadLine();
            //string d = "";
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (s[i] >= '0' && s[i] <= '9' && i != 0 
            // || s[i] >= 'A' && s[i] <= 'Z' || s[i] == '_' || s[i] >= 'a' && s[i] <= 'z') d = "YES";
            //    else { d = "NO"; break; }
            //}
            //Console.WriteLine(d);


            //Вводится ненормированная строка, у которой может быть 
            //более одного пробела между словами.Привести ее к 
            //нормированному виду, т.е.между словами оставить 
            //только один пробел. Гарантируется, что в начале и в конце строки нет пробелов.
            //==========================
            //РЕШЕНИЕ ЧЕРЕЗ ЦИКЛ С CONTINUE
            ////string s = Console.ReadLine();            
            ////for (int i = 0; i <= s.Length - 1; i++)
            ////{
            ////    if (s[i] == ' ' && s[i] == s[i + 1])
            ////    {
            ////        continue;
            ////    }                
            ////    Console.Write(s[i]);
            ////}
            //================================
            //РЕШЕНИЕ ЧЕРЕЗ КОМАНДУ ЗАМЕНЫ REPLACE
            //string s = Console.ReadLine();
            //while (s.Contains("  "))
            //{
            //    s = s.Replace("  ", " ");
            //}
            //Console.WriteLine(s);

            //Напишите программу, которая переставляет соседние элементы
            //массива(1 - й элемент поменять с 2 - м, 3 - й с 4 - м и т.д.Если
            //элементов нечетное число, то последний элемент остается на своем месте).
            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] ss = Console.ReadLine().Split(' ');
            //for (int i = 0; i < ss.Length - 1; i = i + 2) //шаг i обязательно + 2
            //{
            //    string rev = ss[i]; //алгоритм перестановки соседних элементов через третью int
            //    ss[i] = ss[i + 1];
            //    ss[i + 1] = rev;
            //}
            //for (int g = 0; g < ss.Length; g++)
            //{
            //    Console.Write(ss[g] + " ");
            //}

            //Проверьте, является ли двумерный массив симметричным 
            //относительно главной диагонали. Главная диагональ — та, 
            //которая идёт из левого верхнего угла двумерного массива в правый нижний.
            //Вводится число N - количество строк и столбцов. Далее во входном потоке 
            //идет n строк по n чисел разделенных пробелами, являющихся элементами массива.
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[,] array = new int[n, n]; //ввод кол-ва строк и столбцов, иниц. массива
            //int cnt = 0;
            //for (int i = 0; i < n; i++) //цикл считающий количество вводимых строк
            //{
            //    string s = Console.ReadLine(); //ввод строки массива N раз (цикл)
            //    string[] ss = s.Split(' ');

            //    for (int j = 0; j < n; j++) 
            //    {
            //        array[i, j] = Convert.ToInt32(ss[j]);// конвертация введенных строк в Int32
            //    }
            //}
            //for (int i = 0; i < n; i++) // пересчет массива непосредственно для операции задачи
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (array[i, j] != array[j, i]) cnt++;
            //    }
            //}
            //if (cnt > 0) Console.WriteLine("NO");
            //else Console.WriteLine("YES");

            //Программа получает на вход два числа n и m, являющиеся числом
            //строк и столбцов в массиве.Далее во входном потоке
            //идет n строк по m чисел, являющихся элементами массива.
            //Найти максимальную сумму чисел среди всех строк, вывести эту сумму на
            //отдельной строке, далее вывести индекс строки, для которой достигается эта сумма.
            //string[] s = Console.ReadLine().Split(' ');
            //int n = Convert.ToInt32(s[0]);
            //int m = Convert.ToInt32(s[1]);
            //int[,] array = new int[n, m];
            //int sum = 0;
            //int summax = 0;
            //int str = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    string[] ss = Console.ReadLine().Split(' ');
            //    sum = 0;
            //    for (int j = 0; j < m; j++)
            //    {
            //        array[i, j] = Convert.ToInt32(ss[j]);
            //        sum = sum + array[i, j]; //можно считать сумму прямо в этом цикле
            //    }
            //    if (sum > summax) //if должен быть внутри цикла строк, но вне цикла столбцов
            //    {                  //поскольку макс.сумма находится только среди строк
            //        summax = sum;
            //        str = i;
            //    }
            //}
            //Console.WriteLine(summax);
            //Console.WriteLine(str);

            //описание задания слишком объемное, чтобы писать сюда;
            //задание смотреть в папке "работа над ошибками" на скриншоте №27
            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] array = Console.ReadLine().Split(' ');
            //int p = Convert.ToInt32(Console.ReadLine());
            //int cnt = 1;
            //for (int i = 0; i < n; i++)
            //{
            //    int x = Convert.ToInt32(array[i]); //если рост ученика выше чем у Пети, счетчик ++
            //    if (Convert.ToInt32(array[i]) >= p) cnt++; //порядковый номер = кол-во тех кто выше + 1
            //    else break;
            //}
            //Console.WriteLine(cnt);

            //По данному слову, состоящему из строчных латинских букв, 
            //посчитайте количество каждой буквы. Выведите на каждой 
            //строке в алфавитном порядке только те символы, которые 
            //встречаются в строке.Возле каждого символа выведите 
            //сколько раз встречается данный символ.
            //string ss = Console.ReadLine();
            //int cnt = 0;           
            //for (char i = 'a'; i <= 'z'; i++)
            //{              
            //    cnt = 0;
            //    for (int g = 0 ; g < ss.Length; g++)
            //    {
            //        if (ss[g] == i)
            //        {
            //            cnt++;                        
            //        }                  
            //    }
            //    if (cnt > 0) Console.WriteLine(i + " " + cnt);               
            //}

            //Вычислить сумму значений нижеприведенной функции 
            //в диапазоне значений x от −25 до 15 включительно, с шагом, равным 1.
            //если -5 <= x & x <= 5  то  y = x;
            //если x < -5  то y = 2 * |x|- 1;
            //если x > 5 то y = 2 * x;
            //static int func(int x)
            //{
            //    int y = 0;
            //    if (-5 <= x & x <= 5) y = x;
            //    if (x < -5) y = 2 * Math.Abs(x) - 1;
            //    if (x > 5) y = 2 * x;
            //    return y;
            //}
            //int sum = 0;
            //int z = 0;
            //for (int i = -25; i <= 15; i++)
            //{
            //    sum = sum + func(i);
            //}
            //Console.WriteLine(sum);

            //Последовательность состоит из различных натуральных 
            //чисел и завершается числом 0. Определите значение второго 
            //по величине элемента в этой последовательности. Числа, 
            //следующие за числом 0, считывать не нужно.
            //int n = Convert.ToInt32(Console.ReadLine());
            //int max = 0;
            //int min = 0;
            //while (n != 0)
            //{
            //    if (n > min && n < max)
            //    {
            //        min = n;
            //    }
            //    if (n > max)
            //    {
            //        min = max;
            //        max = n;
            //    }
            //    n = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine(min);

            //Два различных натуральных числа n и m называются дружественными, 
            //если сумма делителей числа n (включая 1, но исключая само n) 
            //равна числу m и наоборот. Например, 220 и 284 – дружественные числа. 
            //По данному числу k выведите все пары дружественных чисел, 
            //каждое из которых не превосходит k. Пары необходимо выводить 
            //по одной в строке, разделяя пробелами. Каждая пара должна быть 
            //выведена только один раз. Сначала выводится меньшее из двух чисел.
            //int num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= num; i++)
            //{
            //    int summator = 1;
            //    for (int x = 2; x <= Math.Sqrt(i); x++)
            //    {
            //        if (i % x == 0)
            //        {
            //            summator = summator + x + i / x;
            //        }
            //    }
            //    int sum_ = 1;
            //    for (int j = 2; j <= Math.Sqrt(summator); j++)
            //    {
            //        if (summator % j == 0)
            //        { 
            //            sum_ = sum_ + j + summator / j; 
            //        }
            //    }
            //    if (sum_ == i && i < summator && summator <= num)
            //    {
            //        Console.WriteLine(i + " " + summator);
            //    }
            //}


            //для отсчитывания индекса с обратной стороны можно использовать
            // ^ вместо .Length        

            //int[] array = new int[] { 1, 3, 7, 8, 3, 5, 2 };
            //array[^5] = 23; //вместо 7 станет 23
            //Console.WriteLine(array[^4]); //выведет 8

            //Console.WriteLine(array[array.Length - 4]); //снова выведет 8

            //string s = "123456";
            //Console.WriteLine(s[5] * s[1]);

            //многократное дописывание содержимого строки
            //string a = "I need money. ";
            //for (int i = 0; i <= 3; i++)
            //{
            //    a += "Yes, i am. ";
            //}
            //Console.WriteLine(a);


            //тернарная операция ([первый операнд - условие] ? [второй операнд] : [третий операнд].)
            //int x = 3;
            //int y = 2;
            //Console.WriteLine("Нажмите + или -");
            //string selection = Console.ReadLine();

            //int z = selection == "+" ? (x + y) : (x - y);
            //Console.WriteLine(z);



            //count the vowels
            //int total = 0;        
            //char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            //Console.WriteLine("Enter a Sentence");
            //string sentence = Console.ReadLine().ToLower();

            //for (int i = 0; i < sentence.Length; i++)
            //{
            //    if (vowels.Contains(sentence[i]))
            //    {
            //        total++;
            //    }
            //}
            //Console.WriteLine("Your total number of vowels is: {0}", total);

            //Console.ReadLine();



            //iterate array + foreach
            //int[] numbers = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };
            //foreach (int i in numbers)
            //{
            //    System.Console.Write("{0} ", i);
            //}        
            //int[,] numbers2D = new int[3, 2] { { 9, 99 }, { 3, 33 }, { 5, 55 } };
            // Or use the short form:
            // int[,] numbers2D = { { 9, 99 }, { 3, 33 }, { 5, 55 } };
            //foreach (int i in numbers2D)
            //{
            //    System.Console.Write("{0} ", i);
            //}
            // Output: 9 99 3 33 5 55




            //ссылочный тип 
            //ps со ссылочными типами данных по умолчанию доступны только две операции сравнения: == и !=
            //int[] c = new int[4];
            //c[0] = 3;
            //int[] d = c;
            //c[0] = 7;
            //d[0] = 31;
            //Console.WriteLine(c == d);//True

            //значимый тип
            //int x = 25;
            //int y = x;
            //x = 31;//no rewriting
            //Console.WriteLine(y);//25


            //double a = 25.5;
            //double b = 25.5;
            //double[] c = new double[1];
            //c[0] = a;
            //Console.WriteLine(a == b);
            //Console.WriteLine(a == c); //compilation error (цифра сравнивается с массивом)


            //array output styles exept cycles
            //char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            //Array.ForEach(vowels, Console.WriteLine);//standart: each symbol - new line
            //Console.WriteLine("[{0}]", string.Join(", ", vowels)); //[ 'a', 'e', 'i', 'o', 'u' ]
            //vowels.ToList().ForEach(i => Console.WriteLine(i.ToString())); //standart: each symbol - new line


            //stepik strings
            //string s; // s = null, ссылка на несуществующий объект
            //s = string.Empty; // s = "", ссылка на объект, который не содержит символов

            //string s = "just a string";
            //s[0] = "J"; // ошибка компиляции, нельзя изменять символы в строке
            //s += "!";
            //Console.WriteLine(s); // на консоль выведется строка "just a string!"(но это другой объект в куче)

            //string s = "csharpessential";
            //Console.WriteLine(s[0]+ s[3]);//без ToString будут складываться коды а буквы

            //string s = "01234567891011121314151617";
            //for (int i = 2; i < s.Length; i = i + 3)
            //{
            //    Console.Write(s[i]);
            //}

            //На вход программе подается одна строка. Напишите программу, 
            //которая определяет сколько раз в строке встречаются символы + и *.
            //string str = Console.ReadLine();
            //int cnt1 = 0, cnt2 = 0;
            //foreach(char x in str)
            //{
            //    if (x == '+') cnt1++;

            //    if (x == '*') cnt2++;
            //}
            //Console.WriteLine("Символ + встречается " + cnt1 + " раз");
            //Console.WriteLine("Символ * встречается " + cnt2 + " раз");

            //На вход программе подается одна строка. Напишите программу, 
            //которая определяет сколько в ней одинаковых соседних символов.
            //string str = Console.ReadLine();
            //int cnt = 0;
            //for(int i = 1; i < str.Length; i++)
            //{
            //    if (str[i] == str[i - 1]) cnt++;          
            //}
            //Console.WriteLine(cnt);


            //проверка на цифры и буквы
            //char c = Convert.ToChar(Console.ReadLine());//благодаря этому принимается только один символ
            //if (char.IsDigit(c))//OR c >= '0' && c <= '9'
            ////if (char.IsLetter(c))
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            //смена регистра и проверка регистра
            //Console.WriteLine(char.IsLower('b')); // True
            //Console.WriteLine(char.IsUpper('b')); // False
            //Console.WriteLine(char.ToLower('B')); // 'b'
            //Console.WriteLine(char.ToUpper('b')); // 'B'

            //Измените регистр символа: сделайте его заглавным, 
            //если он был строчной буквой и наоборот.
            //char c = Convert.ToChar(Console.ReadLine());
            //if (char.IsLower(c))
            //{
            //    Console.WriteLine(char.ToUpper(c));
            //}
            //else
            //{
            //    Console.WriteLine(char.ToLower(c));
            //}


            //Определите начинается ли слово ss с большой буквы, то есть с буквы верхнего регистра.
            //string str = Convert.ToString(Console.ReadLine());
            //if (char.IsUpper(str[0]))
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}
            //ИЛИ используя тернарный оператор
            //Console.WriteLine(char.IsUpper(str[0]) ? "YES" : "NO");


            //Даны две строки. Верно ли, что первая строка начинается на ту же букву, 
            //на которую заканчивается вторая строка? Регистр букв НЕ имеет значение
            //===написано через тернарный оператор
            //string a = Console.ReadLine();
            //string b = Console.ReadLine();
            //Console.WriteLine(char.ToLower(a[0]) == char.ToLower(b[b.Length - 1])? "YES" : "NO");


            //Дан текст, составленный из букв латинского алфавита и цифр. 
            //Напечатать все имеющиеся в нем цифры через пробел.
            //string str = Console.ReadLine();
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (char.IsDigit(str[i])) Console.Write(str[i] + " ");
            //}

            //=======STRING METHODS=======
            //split
            //string line = "name:age:status";
            //string[] words = line.Split(':'); // ["name", "age", "status"] 
            //​
            //            string s = "abacabac";
            //string[] words2 = s.Split('b'); // ["a", "aca", "ac"]

            //string t = "aba caba c";
            //string[] words3 = t.Split('b', ' '); // ["a", "a", "ca", "a", "c"]

            //=======================STRING METHODS===============================
            ////Substring 
            //string s = "Hello World";
            //Console.WriteLine(s.Substring(6)); //World --- ОТ какого индекса и до конца
            //Console.WriteLine(s.Substring(6, 2)); //Wo --- ОТ какого , СКОЛЬКО знаков
            ////ps eсли значение первого аргумента равно длине строки, то метод возвратит пустую строку 

            ////Insert
            //string z = "Hello World";
            //Console.WriteLine(z.Insert(11, "!!!"));//Hello World!!! --- ОТ какого индекса, ЧТО вставить

            ////Remove
            //string e = "Hello World";
            //Console.WriteLine(e.Remove(5));//Hello --- ОТ какого индекса и до конца
            //Console.WriteLine(e.Remove(4, 1));//Hello --- ОТ какого (включительно) , СКОЛЬКО знаков

            ////Replace
            //string x = "Hello World";
            //Console.WriteLine(x.Replace("l", "z"));//Hezzo Worzd 
            //Console.WriteLine(x.Replace("Hello", "Hi"));//Hi World --- можно заменять как символы, так и слова 

            //Trim
            //string s = "#csharp essentials##";
            //string t = s.Trim('#'); // удаляет в начале и в конце символ #
            //Console.WriteLine(t); // "csharp essentials"
            //string z = "<  csharp essentials > ";
            //Console.WriteLine(z.Trim('<', '>', ' '));//можно указать несколько символов
            ////При вызове метода без параметров удаляет символы пробела

            //ToLower и ToUpper (применимо и к символам, и к целым строкам)
            //string s = "Some String";
            //Console.WriteLine(s.ToUpper()); //SOME STRING
            //Console.WriteLine(s.ToLower()); //some string

            //IndexOf и LastIndexOf
            //string s = "i like my house and my car, my car is amazing"; // 
            //Console.WriteLine(s.IndexOf("my")); // найдет индекс начала подстроки "my" в строке s (7)
            //Console.WriteLine(s.IndexOf('x')); // выведет -1, т.к. в исходной строке нет символа x
            ////можно указать позицию, начиная с которой будет осуществляться поиск
            //Console.WriteLine(s.IndexOf("like", 7)); // -1
            ////LastIndexOf возвращает индекс последнего вхождения искомого элемента 
            //Console.WriteLine(s.LastIndexOf("car"));//31 т.е. второе слово "car"

            ////Concat 
            //string s1 = "a b c";
            //string s2 = "d e f";
            //string s3 = "g h i";
            //Console.WriteLine(string.Concat(s1, s2, s3)); // "a b c d e f g h i" (порядок важен)
            ////в метод в качестве аргументов можно передавать сразу массив строк
            //string[] arr = new string[] { "a b ", "с d ", "e f ", "g h " };
            //Console.WriteLine(string.Concat(arr)); // "a b c d e f g h i "
            ////concat two arrays
            //int[] array1 = { 1, 3, 5 };
            //int[] array2 = { 0, 2, 4 };
            //int[] result = array1.Concat(array2).ToArray();
            //Array.ForEach(result, Console.WriteLine); // 1 3 5 0 2 4

            //Join
            //string[] array = new string[] { "день", "месяц", "год" };
            //Console.WriteLine(string.Join("-", array)); // "день-месяц-год"
            ////array to string
            //int[] arr = new int[] { 25, 2, 52, 24, 13 };
            //Console.WriteLine(string.Join("::", arr)); //25::2::52::24::13
            ////string to array
            //string s = "sdasd asfaqf asdad";
            //string[] ss = new string[] { s };
            //=============================================================


            //Дана строка, содержащая пробелы. Найдите, сколько в ней слов.
            //string s = Console.ReadLine();
            //string[] arr = s.Split(' ');//!!!! ковычки ОДИНАРНЫЕ
            //Console.WriteLine(arr.Length);


            //На вход программе подается строка состоящая из имени и фамилии человека, 
            //разделенных одним пробелом. Напишите программу, которая проверяет, 
            //что имя и фамилия начинаются с заглавной буквы.
            //string s = Console.ReadLine();
            //string[] arr = s.Split();
            //Console.WriteLine(char.IsUpper(arr[0][0]) & char.IsUpper(arr[1][0]) ? "YES" : "NO");


            //Дана строка. Удалите kk-ый символ в ней и выведете
            //string s = Console.ReadLine();
            //int k = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(s.Remove(k - 1, 1));


            //удалить все "WUB", оставив только буквы или слова между ними; эти слова
            //или буквы должны быть разделены одним пробелом; примеры ввода:
            //WUBWUBIWUBAMWUBWUBX //RWUBWUBWUBLWUB
            //РЕШНИЕ №1 мое
            //string s = Console.ReadLine();
            //s = s.Replace("WUB", " ");
            //s = s.Replace("  ", " ");
            //if (s.Contains("  "))
            //{
            //    s = s.Replace("  ", " ");
            //}
            //Console.WriteLine(s);

            //РЕШЕНИЕ №2 преподавателя
            //string s = Console.ReadLine();
            //string[] words = s.Split(new string[] { "WUB" }, StringSplitOptions.RemoveEmptyEntries);

            //for (int i = 0; i < words.Length; i++)
            //{
            //    Console.Write(words[i] + " ");
            //}

            //На вход дается строка текста; Программа должна вывести «YES» 
            //если текст имеет в себе набор букв "хорош" (любого регистра) и «NO» в противном случае.
            //string s = Console.ReadLine();
            //#1
            //Console.WriteLine(s.ToLower().Contains("хорош")? "YES": "NO");
            //#2
            //Console.WriteLine(s.ToLower().IndexOf("хорош") > 0 ? "YES" : "NO");

            //На вход программе подается строка. Напишите программу, 
            //которая подсчитывает количество буквенных символов в нижнем регистре.
            //string s = Console.ReadLine();
            //int cnt = 0; 
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (char.IsLetter(s[i]) & char.IsLower(s[i])) cnt++;
            //}
            //Console.WriteLine(cnt);


            //Дана строка. Определите, какой символ в ней встречается раньше: x или w. 
            //Если таких символов нет, вывести -1. Если есть один из символов - вывести его.
            //string s = Console.ReadLine();
            //if (s.IndexOf('x') != -1 & s.IndexOf('w') != -1)
            //{
            //    Console.WriteLine(s.IndexOf('x') < s.IndexOf('w') ? "x" : "w");
            //}
            //else if (s.IndexOf('x') != -1 & s.IndexOf('w') == -1)
            //{
            //    Console.WriteLine("x");
            //}
            //else if (s.IndexOf('x') == -1 & s.IndexOf('w') != -1)
            //{
            //    Console.WriteLine("w");
            //}
            //else Console.WriteLine("-1");

            //Вывести строку удалив все повторяющиеся символы (Distinct)
            //string s = Console.ReadLine();
            //s = new string(s.Distinct().ToArray());
            //Console.WriteLine(string.Join(",", s));

            //Убрать в вводимой строке все лишние пробелы
            //string s = Console.ReadLine();
            //s = s.Replace("  ", " ");
            //if (s.Contains("  "))
            //{
            //    s = s.Replace("  ", " ");
            //}
            //Console.WriteLine(s);


            //Дана строка. Известно, что она содержит ровно две одинаковые 
            //буквы(регистр ИМЕЕТ значение).Найти и вывести ту букву, которая 
            //повторяется.Гарантируется, что повторяются буквы только одного вида.
            //string s = Console.ReadLine();
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (s.IndexOf(s[i]) != s.LastIndexOf(s[i]))
            //    {
            //        Console.WriteLine(s[i]);
            //        break;
            //    }
            //}

            //StringBuilder + stopwatch=========================
            //Stopwatch sw = new Stopwatch();//requires Using.System.Diagnostics;
            //sw.Start();

            //string s = string.Empty;

            //for (int i = 0; i < 50000; i++)
            //{
            //    s += "новая запись";
            //}
            //sw.Stop();
            //Console.WriteLine(sw.ElapsedMilliseconds);// 7200 ms

            //Stopwatch sw = new Stopwatch();//requires Using.System.Diagnostics;
            //sw.Start();

            //var builder = new StringBuilder();//== char[], default capacity = 16
            ////can input capacity, for example "new StringBuilder(size)", where int size = 50000 * 12;

            //for (int i = 0; i < 50000; i++)
            //{
            //    builder.Append("новая запись");
            //}
            //sw.Stop();
            //Console.WriteLine(sw.ElapsedMilliseconds);//2 ms
            //Console.WriteLine(builder.ToString());
            //================================

            //String.Format
            //int km = 25;
            //string mark = "dodge";
            //string speed = "150";
            //string output = String.Format("Car: {0}, distance: {1}, av.speed: {2}", mark, km, speed);
            //Console.WriteLine(output);
            ////.Format встроен в метод Console.WriteLine
            //Console.WriteLine("Car: {0}, distance: {1}, av.speed: {2}", mark, km, speed);
            ////пример произвольного порядка
            //string a = "C#";
            //int b = 6;
            //double c = 15.5;
            //Console.WriteLine("Begin: {0} {2} {0} End", b, c, a);//Begin: 6 C# 6 End

            //Напишите программу, которая считывает строку-разделитель и три 
            //строки, а затем выводит указанные строки через разделитель.
            //string sep = Console.ReadLine();
            //string a = Console.ReadLine();
            //string b = Console.ReadLine();
            //string c = Console.ReadLine();
            //string output = String.Format("{0}{3}{1}{3}{2}", a, b, c, sep);
            //Console.WriteLine(output); 
            //ИЛИ Console.WriteLine($"{s1}{sep}{s2}{sep}{s3}"); интерполяция


            //Console.WriteLine("{0:0000}", 7); // "0007" - добавление нулей перед числом
            //Console.WriteLine("{0:0000}", 12345); //"12345"

            ////Округление с фиксированным количеством знаков после запятой (заполняет нулями недостаток)
            //Console.WriteLine("{0:0.00}", 12345.325); //с 5 УЖЕ ИДЕТ ОКРУГЛЕНИЕ "12345,33"
            //Console.WriteLine("{0:0.00}", 248.156412); // "248,16"
            //Console.WriteLine("{0:0.00}", 74.1); // "74,10"
            //Console.WriteLine("{0:0.000}", 25.29); // "25.290" 
            ////Округление с указанием максимального количества знаков после запятой (не заполняет нулями)
            //Console.WriteLine("{0:0.##}", 74.1); // "74,1"
            //Console.WriteLine("{0:0.###}", 25.29); // "25.29" 
            //Console.WriteLine("{0:0.##}", 25); "25"
            ////Отображение числа в формате номера телефона:
            //Console.WriteLine("{0:+#(###)-###-##-##}", 79118500000); //+7(911)-850-00-00
            ////выравнивание по левому и правому краю
            //Console.WriteLine("{0,10}", 7);  // "         7" - выравнивание по правому краю колонки шириной 10
            //Console.WriteLine("{0,-10}", 7); // "7         " - выравнивание по левому краю колонки шириной 10


            //Таблица с использованием отступов
            //Console.WriteLine("||{0, -15}||{1, -15}||{2, -15}||", "   --name--", "   --age--", "   --weight--");
            //Console.WriteLine("||{0, -15}||{1, 15}||{2, 15}||", "Ann", "19", "55");
            //Console.WriteLine("||{0, -15}||{1, 15}||{1, 15}||", "Josh", "32", "78");
            //Console.WriteLine("||{0, -15}||{1, 15}||{1, 15}||", "Bill", "28", "84");


            //Интерполяция (не требует String.Format) введена в C# 6.0
            //int km = 25;
            //string mark = "dodge";
            //string speed = "150";
            //string output = $"Car: {mark}, distance: {km}, av.speed: {speed}";
            //Console.WriteLine(output);
            ////Интерполяция для вычислений
            //int x = 12;
            //Console.WriteLine($"10*4 = {x * 4}; 18/6 = {18 / 6}");


            //управляющие последовательности(escape-последовательности)=======================
            //Console.Write("первая строка \n вторая строка \n"); //перевод на новую строку
            //Console.WriteLine("автор романа \"Война и мир\"");//экранирование

            //while (true) //возврат каретки. Переводит курсор в начало текущей строки
            //{
            //    Console.Write("\r{0:Текущее время: HH:mm:ss }", DateTime.Now);
            //}
            //На каждой итерации цикла курсор будет возвращаться на начальную позицию 
            //и на консоль выводиться строка с текущим временем. Предыдущая строка 
            //будет "перекрываться" новой и таким образом часы на консоли будут "тикать".

            //Console.WriteLine("Ivan\tKarash");//табуляция - вставляет TAB

            //Console.WriteLine("c:\\Documents\\file");//экранирование \

            //игнорирование управляющих символов и зарезервированных команд с помощью @
            //Console.WriteLine(@"c:\Documents\file");
            //int default = 25; //ошибка, default зарезервировано 
            //int @default = 25;//резервирование игнорируется, но ТАК ДЕЛАТЬ НЕЛЬЗЯ
            //===========================================================

            //Напишите программу, которая считывает строку, 
            //а затем выводит указанную строку в двойных кавычках.
            //string s = $"\"{Console.ReadLine()}\"";
            //Console.WriteLine(s);
            //ИЛИ string s = Console.ReadLine();
            //Console.Write("\"{0}\"", s);

            //интернирование + проверка того, ссылаются ли объекты на одну и ту же область памяти
            //======================================================
            //string a = "abc";
            //string b = "abc";
            //Console.WriteLine(object.ReferenceEquals(a, b));//true, авто интернирование

            //string x = "abcde";
            //string y = "abc";
            //string c = y + "de";//abcde
            //Console.WriteLine(object.ReferenceEquals(c, x));//false, нет авто интернирования для вычисляемых строк
            ////потому что слишком затратно сканировать пул интернирования при каждой операции вычислений строк
            //string z = string.Intern(y + "de");//abcde
            //Console.WriteLine(object.ReferenceEquals(z, x));//true, ручное интернирование запустило сканирование пула
            ////и с найденным совпадением ссылка была присвоена совпавшему куску памяти

            ////ВАЖНО при string.Copy интернирование не происходит 
            //string a = "abc";
            //string b = string.Copy(a);
            //Console.WriteLine(object.ReferenceEquals(a, b)); //false

            ////дополнение
            //string a = "abc";
            //string b = "ab";
            //string c = b + "c";
            //string.Intern(c); // выведет false т.к. ссылка не сохранена в объект "с" 
            //c = string.Intern(c);// true
            //Console.WriteLine(object.ReferenceEquals(a, c));

            //Строчные литералы автоматически заносятся в пул интернирования
            //string b = "ab";
            //Console.WriteLine(string.IsInterned(b) == null);//false
            //Console.WriteLine(string.IsInterned("ab") == null);//false
            //==============================================================    
            #endregion
           
            Console.WriteLine("Введите название школы");
            string schoolName = Convert.ToString(Console.ReadLine());
            
            School school = new School(schoolName);
            Console.WriteLine($"Школа {schoolName} успешно создана.");

            while(true)
            {
                Console.WriteLine("");
                Console.WriteLine($"Хотите посмотреть список всех учеников школы {schoolName}?");
                string answer = Convert.ToString(Console.ReadLine());
                if (answer.ToLower() == "да")
                {
                    school.PrintStudents();
                }

                Console.WriteLine("");
                Console.WriteLine("Хотите добавить нового ученика?");
                string answer2 = Convert.ToString(Console.ReadLine());
                if (answer2 == "Да" || answer2 == "да")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Введите имя ученика");
                    string addFirstName = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Введите фамилию ученика");
                    string addLastName = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Введите возраст ученика");
                    int addAge = Convert.ToInt32(Console.ReadLine());

                    Student student = new Student(addFirstName, addLastName, addAge);
                    school.AddNewStudent(student);
                
                }
                Console.WriteLine("");
                Console.WriteLine($"Хотите посмотреть список всех учеников школы {schoolName}?");
                string answer3 = Convert.ToString(Console.ReadLine());
                if (answer3 == "Да" || answer3 == "да")
                {
                    school.PrintStudents();
                }
                
                Console.WriteLine("");
                Console.WriteLine("Хотите удалить ученика из списка?");
                string answer4 = Convert.ToString(Console.ReadLine());
                if (answer4 == "Да" || answer4 == "да")
                {
                    school.PrintStudents();
                    Console.WriteLine("");
                    Console.WriteLine("Введите порядковый номер ученика");
                    int indexToDelete = Convert.ToInt32(Console.ReadLine());
                    school.DeleteStudent(indexToDelete);
                }
            }










        }
    }
}






















