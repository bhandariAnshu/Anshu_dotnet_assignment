using System;
using System.ComponentModel.DataAnnotations;  // Required for [Key]

namespace ProjectManagement.Models
{
    public class Projects
    {
        [Key]  // Marks this as the Primary Key
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectManager {  get; set; }
        public string ProjectVersion { get; set; } = string.Empty;
        public DateTime ProjectDeadline { get; set; }
    }
}
