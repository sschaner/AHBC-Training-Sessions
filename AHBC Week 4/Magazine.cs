using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcWeekFour
{
    public class Magazine
    {
        private string author;
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value;  }
        }

        public Magazine (string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}
