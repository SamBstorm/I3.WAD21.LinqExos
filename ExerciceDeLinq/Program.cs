using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LINQDataContext;

namespace ExerciceDeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext dc = new DataContext();
            #region Exos2.1

            //var resultat = dc.Students
            //    .Select(s => new { NomDeFamille = s.Last_Name, DateNaissance = s.BirthDate, s.Login, ResultatAnnuel = s.Year_Result });

            //var resultat = from s in dc.Students
            //               select new { NomDeFamille = s.Last_Name, DateNaissance = s.BirthDate, s.Login, ResultatAnnuel = s.Year_Result };

            //foreach (var item in resultat) Console.WriteLine($"{item.NomDeFamille} {item.DateNaissance} {item.Login} {item.ResultatAnnuel}");

            #endregion
            #region Exos2.2

            //var result = dc.Students.Select(student => new { NomComplet = $"{student.Last_Name} {student.First_Name}", student.Student_ID, student.BirthDate });

            var result = from student in dc.Students
                         select new { NomComplet = $"{student.Last_Name} {student.First_Name}", student.Student_ID, student.BirthDate };

            foreach (var stu in result)
            {
                Console.WriteLine($"{stu.NomComplet} - {stu.Student_ID} - {stu.BirthDate}");
            }
            #endregion

            #region Console.ReadLine()
            Console.ReadLine();
            #endregion
        }
    }
}
