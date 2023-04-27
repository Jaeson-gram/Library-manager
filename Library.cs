
using System.Collections;
using System.ComponentModel;

namespace Poem_to_Library
{
    public class Library : CollectionBase
    {
        public string _name;
        public string _location;

        private int _numberOfBooksInLibrary
        {
            get
            {
               return Count();
            }
        }

        public void Add(Book book)
        {
            InnerList.Add(book);
        }

        //to get number of books in the library, we first have to use the Count method from ArrayList
        public int Count()
        {
            return InnerList.Count;
        }

        //See details about the library
        public void AboutLibrary()
        {
            Console.WriteLine($"Name - {_name} \nLocation - {_location} \nNumber Of Books - {_numberOfBooksInLibrary}");
        }
    }
}
