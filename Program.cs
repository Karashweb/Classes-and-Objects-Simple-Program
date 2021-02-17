
using System;
using System.Collections.Generic;


namespace ConsoleApp1
{
    class Program
    {

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
                if (answer2.ToLower() == "да")
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
                if (answer3.ToLower() == "да")
                {
                    school.PrintStudents();
                }
                
                Console.WriteLine("");
                Console.WriteLine("Хотите удалить ученика из списка?");
                string answer4 = Convert.ToString(Console.ReadLine());
                if (answer4.ToLower() == "да")
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






















