using ProjetoOOP.ContentContext.Enums;
using ProjetoOOP.SharedContext;

namespace ProjetoOOP.ContentContext
{
    public class Lecture : BaseContent
    {
        public int Order { get; set; }
        public string Title { get; set; }

        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}