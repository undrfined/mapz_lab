using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab4.AdminPanel
{
    public class ProjectViewPanel
    {
        public IEnumerable<Project> GetUserProjects(Guid userId)
        {
            return new []
            {
                new Project()
                {
                    Id = Guid.NewGuid(),
                    Author = Guid.NewGuid(),
                    Name = "Test Project"
                }
            };
        }

        public void SetProjectStatus(Guid projectId, ProjectStatus status)
        {
            // TODO
        }
    }
}