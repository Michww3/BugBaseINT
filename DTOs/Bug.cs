using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        
        public int EmployeId { get; set; }
        public Employe Employe { get; set; }

        public string Base64Image { get; set; }

        public Bug(string name, string description, string priority, DateTime endDate, bool isComplited, int employeId)
        {
            Name = name;
            Description = description;
            Priority = priority;
            EndDate = endDate;
            IsComplited = isComplited;
            EmployeId = employeId;
        }
        public Bug()
        {
            
        }
    }
}
