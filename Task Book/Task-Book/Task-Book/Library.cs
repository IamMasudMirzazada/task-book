using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Book
{
    class Library
    {  
        public List<Book> books = new List<Book>(0);
        public void AddBook(string name, string authorName, int pageCount)
        {
            books.Add(new Book(name, authorName, pageCount));
        }
        public void ShowAlllist()
        {
            foreach (var item in books)
            {
                Console.WriteLine(item);
            }
        } 
        public List<Book> FindAllBooksByName(string str)
        {
            return books.FindAll(x => x.Name.ToUpper().Contains(str.ToUpper()));
        } 
        public void RemoveAllBookByName(string str)
        { 
              books.RemoveAll(r => r.Name.ToUpper().Contains(str.ToUpper())); 
            Console.WriteLine(" -------------daxil etdiyiniz acar soze uygun kitab silindi----------------");
                        Console.WriteLine();
        }
        public List<Book> SearchBooks(string str)
        { 
            return books.FindAll(f => f.Name.ToLower().Contains(str.ToLower()) || f.AuthorName.ToLower().Contains(str.ToLower()) || f.PageCount.ToString() == str); 
        }
        public void FindAllBooksByPageCountRange(int p1, int p2)
        { 
            foreach (var item in books)
            {
                if (item.PageCount >= p1 && item.PageCount <= p2)
                {
                    Console.WriteLine(item);
                } 
            } 
        }
        public void RemoveByNo(string str)
        {
            begin:
            if ( books.Count>0)
            {
                foreach (Book item in books)
                {
                    if (item.Code.ToUpper()== str.ToUpper())
                    {
                        books.Remove(item);
                        Console.WriteLine(" -------------daxil etdiyiniz acar soze uygun kitab silindi----------------");
                        Console.WriteLine();
                        goto begin;
                    }

                }
               
            }
            
             
        } 







































        //public bool FindName(string str)
        //{
        //    if ( )
        //    {
        //        return true;
                 
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //public bool RemoveName(string str)
        //{
        //    if (books.Exists(r => r.Name.ToUpper().Contains(str.ToUpper())))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //public bool Searchbks(string str)
        //{
        //    if (books.Exists(s=>s.Name.ToLower().Contains(str.ToLower()) || s.AuthorName.ToLower().Contains(str.ToLower()) || s.PageCount.ToString() == str))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false; 
        //    }
        //} 

    }
    delegate bool Check(string str);
}