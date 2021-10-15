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

            //var resultat = dc.Students
            //    .Select(s => new { NomDeFamille = s.Last_Name, DateNaissance = s.BirthDate, s.Login, ResultatAnnuel = s.Year_Result });

            var resultat = from s in dc.Students
                           select new { NomDeFamille = s.Last_Name, DateNaissance = s.BirthDate, s.Login, ResultatAnnuel = s.Year_Result };

            foreach (var item in resultat) Console.WriteLine($"{item.NomDeFamille} {item.DateNaissance} {item.Login} {item.ResultatAnnuel}");

            #region Console.ReadLine()
            Console.ReadLine();
            #endregion
        }
    }
}
