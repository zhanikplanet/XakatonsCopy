using System.Collections.Generic;

namespace Dataton_API.Modules.Entities
{
    public class Articles
    {
        public int Hashtag {get;set;} 
        public int Id { get;set;}
        public string SysLang { get;set;}
        public string Project { get;set;}
        public string Title { get;set;}
        public string Content { get; set;}
        public string URL { get; set;}
    }
}
