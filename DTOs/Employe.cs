using System.Collections.Generic;

namespace BugBase.DTOs
{
    public class Employe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }

        public List<Bug> Bugs { get; set; } = new List<Bug>();

        public Employe(string name, string profession) 
        {
            Name = name;
            Profession = profession;
        }
        public Employe() { }
    }
}
