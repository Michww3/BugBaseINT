using BugBase.DTOs;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace BugBase.Helpers
{
    public class DbInitilize : DropCreateDatabaseAlways<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            List<Employe> employes = new List<Employe>()
            {
                new Employe("Artem", "Developer"),
                new Employe("Ignat", "Developer"),
                new Employe("Dima", "Developer"),
                new Employe("Pascal", "Developer"),
                new Employe("Timofei", "QA"),
                new Employe("Alex", "QA"),
                new Employe("Vlad", "QA"),
                new Employe("Mihail", "QA"),
                new Employe("Egor", "QA")
            };

            context.Employes.AddRange(employes);
            base.Seed(context);
        }
    }
}
