using System;

namespace BugBase.DTOs
{
    public class Bug
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsComplited { get; set; }

        public Employe Employe { get; set; }

        public Bug(string name, string description, string priority, DateTime endDate, bool isComplited)
        {
            Name = name;
            Description = description;
            Priority = priority;
            EndDate = endDate;
            IsComplited = isComplited;
        }
    }
}
