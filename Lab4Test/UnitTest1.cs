using System;
using Lab4;
using Lab4.AdminPanel;
using Lab4.DbController;
using Lab4.Review;
using Lab4.Stats;
using Lab4.User;
using NUnit.Framework;

namespace Lab4Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        
        // Singleston (Одиночка)
        [Test]
        public void TestDbController()
        {
            var id = Guid.NewGuid();
            Console.WriteLine(DbControllerSingleton.Instance.FetchProject(id).Name);
            Console.WriteLine(DbControllerSingleton.Instance.FetchProject(id).Name);
            Assert.Pass();
        }
        
        // Factory (Фабрика)
        [Test]
        public void TestUserFactory()
        {
            UserFactory.Create("developer");
            UserFactory.Create("admin");
            UserFactory.Create("customerSupport");
        }
        
        // Prototype (прототип)
        public void TestProduct()
        {
            var project = new Lab4.Prototype.Project("Wikipedia");
            var clonedProject = project.Clone();
        }

        // Composite (Компонувальник)
        [Test]
        public void TestReview()
        {
            var thread = new ReviewCommentThread(Guid.NewGuid(), "Hello, world!");
            thread.Add(new ReviewComment(Guid.NewGuid(), "Hi there!"));
            var thread2 = new ReviewCommentThread(Guid.NewGuid(), "Now we're talking!");
            thread2.Add(new ReviewComment(Guid.NewGuid(), "ikr"));
            thread.Add(thread2);
            thread.Add(new ReviewComment(Guid.NewGuid(), "Ending!"));
            
            thread.Display();
            Assert.Pass();
        }

        // Facade (Фасад)
        [Test]
        public void TestAdminPanel()
        {
            var reviewPanel = new ReviewPanel();
            var userControlPanel = new UserControlPanel();
            var projectViewPanel = new ProjectViewPanel();
            var adminPanel = new AdminPanelFacade(reviewPanel, projectViewPanel, userControlPanel);
            
            adminPanel.BanUser(Guid.NewGuid());
            Assert.Pass();
        }

        // Decorator (Декоратор)
        [Test]
        public void TestStats()
        {
            var userStats = new UserStats();
            Console.WriteLine(userStats.ToJson());
            var anonUserStats = new WithAnonymousDecorator(userStats);
            Console.WriteLine(anonUserStats.ToJson());
            
            
            var projectStats = new ProjectStats();
            Console.WriteLine(projectStats.ToJson());
            var projectStatsAnon = new WithAnonymousDecorator(projectStats);
            Console.WriteLine(projectStatsAnon.ToJson());
            Assert.Pass();
        }
    }
}