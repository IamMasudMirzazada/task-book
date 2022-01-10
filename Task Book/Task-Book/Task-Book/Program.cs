using System;
using System.Collections.Generic;

namespace Task_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Library libraryManager = new Library();

            while (true)
            {
                Console.WriteLine(" - Etmek istediyiniz emeliyyatin qarshisindaki ededi daxil edin ");
                Console.WriteLine(" 1 - Kitab Elave etmek ");
                Console.WriteLine(" 2-  Daxil etdiyimiz deyere uygun kitablari qaytarir ");
                Console.WriteLine(" 3 - Daxil etdiyimiz deyere uygun kitablari silir ");
                Console.WriteLine(" 4 - Daxil etdiyimiz deyere uygun kitablari axtarir ");
                Console.WriteLine(" 5 - Daxil etdiyimiz sehife araliqinda olan kitabi qaytarir  ");
                Console.WriteLine(" 6 - Daxil edtiyimiz Nomreye esasen kitabi silir ");
                Console.WriteLine(" 7 - Butun kitablarin siyahisi");

                string no = Console.ReadLine();
                int num = 0;
                int.TryParse(no, out num);
                switch (num)
                {
                    case 1:
                        Console.Clear();
                        AddBook(ref libraryManager);
                        break;
                    case 2:
                        Console.Clear();
                        FindAllBooksByName(ref libraryManager);
                        break;
                    case 3:
                        Console.Clear();
                        RemoveAllBookByName(ref libraryManager);
                        break;
                    case 4:
                        Console.Clear();
                        SearchBooks(ref libraryManager);
                        break;
                    case 5:
                        Console.Clear();
                        FindAllBooksByPageCountRange(ref libraryManager);
                        break;
                    case 6:
                        Console.Clear();
                        RemoveByNo(ref libraryManager);
                        break;
                    case 7:
                        Console.Clear();
                        ShowAlllist(ref libraryManager);
                        break;
                    default:
                        Console.WriteLine("duzgun eded daxil edin");
                        break;
                }
            }
        }







































        static void AddBook(ref Library libraryManager)
        {
            Console.WriteLine(" Elave edilecek Kitabin adini daxil edin ");
            string name = Console.ReadLine();

            Console.WriteLine(" Elave edilecek Kitabin muellif adini daxil edin ");
            string authorName = Console.ReadLine();

            Console.WriteLine(" Elave edilecek Kitabin sehife sayini   daxil edin ");
            string page = Console.ReadLine();
            int pageCount;
            int.TryParse(page, out pageCount);

            libraryManager.AddBook(name, authorName, pageCount);
        }
        static void ShowAlllist(ref Library libraryManager)
        {
            
            if (libraryManager.books.Count < 0)
            {
                Console.WriteLine("-------------Kitab yoxdur------------------");
            }
            else
            {
                Console.WriteLine("----Butun kitablarin siyahisi -------");
                libraryManager.ShowAlllist();
            }
             
        }
        static void FindAllBooksByName(ref Library libraryManager)
        {

            string findname = string.Empty;
            if (libraryManager.books.Count>0)
            {
                bool check = true;
                do
                {
                    if (check)
                    {
                        Console.WriteLine("Axtarmaq istediyiniz kitabin adini daxil edin.");
                    }
                    else
                    {
                        Console.WriteLine("Axtaris etdiyiniz kitab movcud deyil...");
                    }
                    findname = Console.ReadLine();
                    check = false;
                } while (!(libraryManager.books.Exists(X=>X.Name.ToUpper().Contains(findname.ToUpper()))));
                Console.WriteLine("Axtarsiniza uygun kitablar");
                libraryManager.FindAllBooksByName(findname);
            }
             
            else
            {
                Console.WriteLine("Kitabxananiz bosdur...");
            }
            
            List<Book> result1 = new List<Book>(libraryManager.books.FindAll((X => X.Name.ToLower().Contains(findname))));
            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }
            List<Book> result2 = new List<Book>(libraryManager.books.FindAll((X => X.Name.ToLower().Contains(findname))));
            libraryManager.FindAllBooksByName(findname);
        }
        static void RemoveAllBookByName(ref Library libraryManager)
        {
            Console.WriteLine("silmek istediyiniz kitaba uygun acar sozu daxil");
            string removename = Console.ReadLine();
            if (libraryManager.books.Count > 0)
            {
                libraryManager.RemoveAllBookByName(removename);
            }
            else
            {
                Console.WriteLine("kitab yoxdur");
            }
        }
        static void SearchBooks(ref Library libraryManager)
        {
            Console.WriteLine(" Axtarmaq istediyiniz acar sozu daxil edin ");
            string search = Console.ReadLine();

            libraryManager.SearchBooks(search);
        }
        static void FindAllBooksByPageCountRange(ref Library libraryManager)
        {
            Console.WriteLine(" Axtarmaq istediyiniz kitabin sehife araliqina daxil edin ");
            string page1 = Console.ReadLine();
            int pagecount1;
            int.TryParse(page1, out pagecount1);
            string page2 = Console.ReadLine();
            int pagecount2;
            int.TryParse(page2, out pagecount2);
            libraryManager.FindAllBooksByPageCountRange(pagecount1, pagecount2);
        }
        static void RemoveByNo(ref Library libraryManager)
        {

        }










































    }
}