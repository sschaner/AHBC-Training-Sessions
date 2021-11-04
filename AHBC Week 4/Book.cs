using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace AhbcWeekFour
{
    public class Book
    {
        // This exists but is invisible
        //public Book()
        //{

        //}

        /*
        // The book must have a title
        public Book(string title)
        {
            // think of this as the class saying "mine." my title = title
            this.title = title;
        }

        public Book(string title, string description)
        {
            this.title = title;
            this.description = description;
        }
        */

        public Book(string title, string description, int pageCount = 100) // 100 is the default for pageCount
        {
            this.title = title;
            this.description = description;
            this.pageCount = pageCount;
            authors = new List<string>(); // <- He does it this way
        }

        // Having just one constructor makes it so they have to use that constructor

        // Everything that is in the Book class should be in the Book class.

        // Attributes (characteristics of the object)
        private List<string> authors = new List<string>(); // Nothing wrong with this but doesn't need to be in both.
        public string description;

        private string title; // field
        public string Title
        {
            get { return title; } // public string get(){}
            set { title = value; } // public void set(string value)
        }

        // This is the same as above
        //  public string Title { get; set; } <-- use auto properties on your job. Not in Bootcamp

        public double MyProperty { get; set; }

        private int pageCount;
        public int PageCount
        {
            get { return pageCount; }
            set {
                if (value < 1)
                {
                    throw new ArgumentException("Page count must be greater than 0.");
                }
                pageCount = value;
            }
        }

        private DateTime copyrightDate;
        public DateTime CopyrightDate
        {
            get { return copyrightDate; }
            set { copyrightDate = value; }
        }

        public double DaysSinceCopyright
        {
            get { return (DateTime.Now - copyrightDate).TotalDays; }
        }

        private double salesCommisionPercentage = 7;

        public double SalesCommisionPercentage
        {
            get { return salesCommisionPercentage; }
        }

        /*
         * This is what's behind the scenes
        public string get()
        {
            return title;
        }

        public void set(string value)
        {
            title = value;
        }
        */



        public string AddAuthor(string authorName)
        {
            string message = "";

            if (string.IsNullOrEmpty(authorName))
            {
                message = "Author cannot be empty.";
                return message;
            }

            string pattern = "^[A-Za-z ]+$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(authorName) == false)
            {
                message = "Author can only contain letters and spaces.";
                return message;
            }

            message = "The author has been added to the book.";
            authors.Add(authorName);
            return message;
        }

        public string GetBookDisplayText()
        {
            string output = $"{title} was written by {authors.FirstOrDefault()} with {pageCount} pages.";

            return output;
        }
    }

}
