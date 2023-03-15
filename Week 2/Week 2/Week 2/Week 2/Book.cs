using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2
{
    internal class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }
        public int PublicationYear { get; set; }

        public Book(string title, int pages, int year)
        {
            Title = title;
            Pages = pages;
            PublicationYear = year;
        }

        public string GetTitle()
        {
            return Title;
        }

        public string GetDetails()
        {
            return $"{Title}, {Pages} pages, {PublicationYear}";
        }
    }
}
