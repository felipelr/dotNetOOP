using ProjetoOOP.NotificationContext;
using ProjetoOOP.SharedContext;

namespace ProjetoOOP.ContentContext
{
    public class CarrerItem : BaseContent
    {
        public CarrerItem(string title, string description, int order, Course course)
        {
            if (course == null)
            {
                AddNotification(new Notification("Course", "Curso inválido"));
            }

            Title = title;
            Description = description;
            Order = order;
            Course = course;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public Course Course { get; set; }
    }
}