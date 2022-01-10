using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Book
{
    class Book
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public string Code { get; set; }
        static int Count;

        public Book(string name, string authorName, int pageCount )
        {
            Count++;
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            Code = Name.ToUpper().Substring(0, 2) + Count;

        }
        public override string ToString()
        {
            return $"          Name: {Name}\n " +
                $"   AuthorName: {AuthorName}\n" +
                $"     PageCount: {PageCount}\n" +
                $"          Code: {Code}\n"; 
        }
    }
}
