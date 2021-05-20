using System;

namespace Lab4.AdminPanel
{
    public class AdminPanelFacade
    {
        private ReviewPanel _reviewPanel;
        private ProjectViewPanel _projectViewPanel;
        private UserControlPanel _userControlPanel;

        public AdminPanelFacade(ReviewPanel reviewPanel, ProjectViewPanel projectViewPanel, UserControlPanel userControlPanel)
        {
            _reviewPanel = reviewPanel;
            _projectViewPanel = projectViewPanel;
            _userControlPanel = userControlPanel;
        }

        public void BanUser(Guid userId, DateTime? until = null)
        {
            var userProjects = _projectViewPanel.GetUserProjects(userId);
            foreach (var project in userProjects)
            {
                _reviewPanel.CancelReview(project.Id);
                _projectViewPanel.SetProjectStatus(project.Id, ProjectStatus.Archived);
            }
            _userControlPanel.BanUser(userId, until);
        }
    }
}