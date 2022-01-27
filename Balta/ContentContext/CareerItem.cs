using Balta.NotificationContext;
using Balta.SharedContext;

namespace Balta.ContentContext
{
    public class CareerItem : Entity
    {

        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
        public CareerItem(int order, string title, string description, Course course)
        {
            if (course is null)
            {
                var notification = new Notification("course", "O curso é inválido");
                AddNotification(notification);
            }
            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }
    }
}