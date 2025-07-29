using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YouTubeVideos;

namespace week04
{
    public class Video
    {
        public string _title;
        public string _author;
        public int _length;
        public List<Comment> _comments = new List<Comment>();

        public Video()
        {

        }

        public void DisplayVideo()
        {
            Console.WriteLine($"Video: {_title}");
            Console.WriteLine($"Author: {_author}");
            Console.WriteLine($"Length: {_length} seconds");
            Console.WriteLine();
            
            Console.WriteLine($"{NumberOfComments()} Comments:");
            DisplayComments();

        }

        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        public void DisplayComments()
        {
            foreach (Comment comment in _comments)
            {
                Console.WriteLine(comment.GetComment());
                Console.WriteLine();
            }
        }

        public int NumberOfComments()
        {
            return _comments.Count;
        }
    }
}