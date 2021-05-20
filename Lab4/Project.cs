using System;

namespace Lab4
{
    public class Project
    {
        public Guid Id { get; set; }
        public Guid Author { get; set; }
        public string Name { get; set; }        
    }

    public enum ProjectStatus
    {
        Archived, Active
    }
}