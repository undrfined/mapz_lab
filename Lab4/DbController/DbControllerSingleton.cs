using System;
using System.Collections.Generic;

namespace Lab4.DbController
{
    public class DbControllerSingleton
    {
        private static DbControllerSingleton _instance;

        private readonly Dictionary<Guid, Project> _cachedProjects;

        public DbControllerSingleton()
        {
            _cachedProjects = new Dictionary<Guid, Project>();
        }

        public static DbControllerSingleton Instance => _instance ??= new DbControllerSingleton();

        public Project FetchProject(Guid id)
        {
            if (_cachedProjects.ContainsKey(id))
            {
                return _cachedProjects[id];
            }
            
            // Fetch
            var project = new Project()
            {
                Id = id,
                Name = "Hello " + new Random().Next(0, 43)
            };
            
            _cachedProjects.Add(project.Id, project);

            return project;
        }
    }
}