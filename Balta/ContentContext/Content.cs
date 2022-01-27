using Balta.SharedContext;

namespace Balta.ContentContext
{
    public abstract class Content : Entity
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public Content(string title, string url)
        {
            Title = title;
            Url = url;
        }
    }
}