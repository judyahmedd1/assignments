using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace oops2q3
{
    class StackOverFlowPost
    {
        //fields
        private string _title;
        private string _description;
        private int _vote;
        private DateTime _createdat;
        //constructor
        public StackOverFlowPost(string title, string description)
        {
            if (string.IsNullOrEmpty(title)) throw new ArgumentException("invalid, title can't be null or empty");
            if(string.IsNullOrEmpty(description)) throw new ArgumentException("invalid, description can't be null or empty");
            _title = title;
            _description = description;
            _createdat = DateTime.Now;
            _vote = 0;
        }
        //accessors / properties
        public string Title
        {
            get { return _title; }
            set {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("invalid, title can't be null or empty");
                _title = value;
            }
        }
        public string Description
        {
            get { return _description; }
            set {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("invalid, description can't be null or empty");
                _description = value;
            }
        }
        public DateTime CreatedAt
        {
            get { return _createdat; }
        }

        //methods
        public void UpVote() {
            _vote++;
        }
        public void DownVote() {
            _vote--;
        }
        public int GetCurrentVote()
        {
            return _vote;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            StackOverFlowPost Post = new StackOverFlowPost( "C#Basic", "dffsdffffffffrrrrrrr");

            do
            {
                Console.WriteLine(Post.Title);
                Console.WriteLine(Post.Description);
                Console.WriteLine(Post.CreatedAt);
                Console.WriteLine(Post.GetCurrentVote());

                Console.WriteLine("Up Vote press 1");
                Console.WriteLine("Down Vote press 2");
                Console.WriteLine("Press anything else to exit");

                var s = Console.ReadLine();
                int x = Convert.ToInt32(s);

                if (x == 1)
                {
                    Post.UpVote();
                }
                else if (x == 2)
                {
                    Post.DownVote();
                }
                else
                {
                    return;
                }

                Console.Clear();

            } while (true);
        }
    }
}
