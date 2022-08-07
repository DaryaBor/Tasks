using System;
using System.Collections.Generic;
using System.Linq;
namespace PracticeC
{
    class School
    {
        static public void Main(String[] args)
        {
            Class classA = new Class("A");
            classA.AddStudent("Петров");
            classA.AddStudent("Васильев");
            classA.AddStudent("Иванова");
            classA.AddStudent("Дмитриева");

            Class classB = new Class("B");
            classB.AddStudent("Иванов");
            classB.AddStudent("Смирнов");
            classB.AddStudent("Васильева");
            classB.AddStudent("Дмитриев");
           
            classA.GetStudent("Петров").AddMark(new Mark(4, "5A", new DateTime(2021, 10, 11)));
            classA.GetStudent("Васильев").AddMark(new Mark(4, "5A", new DateTime(2021, 10, 11)));
            classA.GetStudent("Дмитриева").AddMark(new Mark(4, "5A", new DateTime(2021, 10, 11)));
            classA.GetStudent("Иванова").AddMark(new Mark(3, "5A", new DateTime(2021, 10, 11)));

            classB.GetStudent("Иванов").AddMark(new Mark(5, "6B", new DateTime(2021, 10, 11)));
            classB.GetStudent("Смирнов").AddMark(new Mark(5, "6B", new DateTime(2021, 10, 11)));
            classB.GetStudent("Васильева").AddMark(new Mark(5, "6B", new DateTime(2021, 10, 11)));
            classB.GetStudent("Дмитриев").AddMark(new Mark(5,"6B", new DateTime(2021, 10, 11)));

           
            foreach (Student student in classA.GetStudentsOrderedByMarks())
            {
                Console.WriteLine($"{student.Name} {student.GetAvgMark():0.00##}");
            }
            Console.ReadKey();
            foreach (Student student in classB.GetStudentsOrderedByMarks())
            {
                Console.WriteLine($"{student.Name} {student.GetAvgMark():0.00##}");
            }
        }
    }

   
    
    
}