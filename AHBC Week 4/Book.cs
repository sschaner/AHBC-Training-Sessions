using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace AhbcWeekFour
{
    public class Book
    {

        private List<Author> authors = new List<Author>();

        public string Description { get; set; }
        public double Price { get; set; }

        private string title; // field
        public string Title
        {
            get { return title; } // public string get(){}
            set { title = value; } // public void set(string value)
        }

        private int pageCount;
        public int PageCount
        {
            get { return pageCount; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Page count must be greater than 0");
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

        private double salesCommissionPercentage = 7;
        public double SalesComissionPercentage
        {
            get { return salesCommissionPercentage; }
        }

        public Book(string title, string description, int pageCount = 100)
        {
            Title = title;
            Description = description;
            PageCount = pageCount;
        }

        // Added the default parameter so we wouldn't break old code
        public string AddAuthor(string authorName, string emailAddress = "test@test.com")
        {
            string message = "";

            if (string.IsNullOrEmpty(authorName))
            {
                message = "Author can not be empty";
                return message;
            }

            string pattern = "^[A-Za-z ]+$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(authorName) == false)
            {
                message = "Author can only contain letters and spaces";
                return message;
            }

            message = "The author has been added to the book.";
            Author authorToAdd = new Author(authorName, emailAddress);

            authors.Add(authorToAdd);

            return message;
        }

        public string GetBookDisplayText()
        {
            string output =
                $"{title} was written by {authors.FirstOrDefault()} with {pageCount} pages.";

            return output;
        }

        /*
        public Book(string title)
        {
            this.title = title;
        }
      
        public Book(string title,string description)
        {
            this.title = title;
            this.description = description;
        }
        */

        /*
        public string get()
        {
            return title;
        }
        public void set(string value)
        {
            title = value;
        }
        */


    }


}
