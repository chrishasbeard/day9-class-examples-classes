using System;
using System.Collections.Generic;

namespace StudentClassExample
{
    #region classwork goals
    //Objectives for inclass work
    //1] create a new course
    //2] create a student list
    //3] add student list to course
    //4] print out the students in that course
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Course october2019CSharp = new Course("C#.Net Oct 2019", DateTime.Parse("10/14/2019"), DateTime.Parse("12/20/2019"));

            october2019CSharp.Instructor = "Anna B.";

            List<Student> studentList = new List<Student>
            {
                new Student("Gus", "Gus", "gus@gusgus.gus"),
                new Student("Kenny", "McCormick", "kenny@sp.com"),
                new Student("Frank", "Reynolds", "Frankrey@ias.co"),
                new Student("Sparky","Anderson","sanderson@tiger.co")
            };

            october2019CSharp.StudentList = studentList;
            foreach (Student student in october2019CSharp.StudentList)
            {
                Console.WriteLine(student.FirstName);

            }
        }
    }
}
