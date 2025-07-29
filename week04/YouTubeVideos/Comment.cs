using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YouTubeVideos
{
    public class Comment
    {
        public string _person;
        public string _text;

        public Comment(string person, string text)
        {
            _person = person;
            _text = text;
        }

        public  string GetComment()
        {
            return $"{_person}: \n{_text}";
        }
    }
}