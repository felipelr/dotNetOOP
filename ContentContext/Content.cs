using ProjetoOOP.SharedContext;

namespace ProjetoOOP.ContentContext
{
    public abstract class Content : BaseContent
    {
        public Content(string title, string url)
        {
            Title = title;
            Url = url;
        }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}