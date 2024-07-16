using Join_Operations;
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var Std = Repo.LoadSTD();
        var ENR = Repo.LoadENR();   
        //  inner join
        var studentCourses = from student in Std
                             join enrollment in ENR
                             on student.Id equals enrollment.StudentId
                             select new
                             {
                                 StudentName = student.Name,
                                 Course = enrollment.Course
                             };
        var suc = Std.Join(ENR, s => s.Name, e => e.Course, (s, e) => new { s.Name, e.Course });

        foreach (var sc in studentCourses)
        {
            Console.WriteLine($"{sc.StudentName} is enrolled in {sc.Course}");
        }
        Console.ReadLine();
    }
}
