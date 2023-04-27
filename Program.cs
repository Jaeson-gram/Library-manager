using System;

namespace Poem_to_Library
{
    public class Program
    {
        static void Main(string[] args)
        {
            //create a poem..
            var firstPoem = new Poem
            {
                theme = "Bright Beautiful Star",
                poet = "Justice Okechukwu",
                category = "",
                albumName = "Tales By Moonlight"
            };

            //create another poem
            var secondPoem = new Poem
            {
                theme = "The Unfulled Moon",
                poet = "Justice Okechukwu",
                category = "",
                albumName = "Tales By Moonlight"
            };

            secondPoem.writePoetry("The unfulled moon gives us a hint in trial \nEven in the darkest nights, the sky can still put up a smile :)");

            Console.WriteLine("//ABOUT A POEM - PROVIDING THE TITLE"); Console.WriteLine();
            secondPoem.aboutPoem("The unfulled moon");
            Console.WriteLine();





            //create a book to add our poem to
            var firstAlbum = new Book()
            {
                //title = "Tales By Moonlight",
                //author = "Justice Oke",
                //noOfPages = 35
            };

            firstAlbum.makeBook("Tales By Moonlight", "Justice Oke", 35);

            //what if we just make the addChapters to accept just int and poem... No, because we might not be adding a poem, it might be another book
            //except we just make the class a poem Album .. when adding to library, we'll add to the poems/literature category
            firstAlbum.addChapters(1, "Holes in the Sky");
            firstAlbum.addChapters(2, "The Unfulled Moon");
            firstAlbum.addChapters(3, "Bright Beautiful Star");

            Console.WriteLine("//GET A PARTICULAR CHAPTER OF A BOOK PROVIDING THE CHAPTER NUMBER"); 
            firstAlbum.getChapters(3);
            Console.WriteLine();




            //create a Library
            Library library = new()
            {
                _name = "My Bed",
                _location = "My Room",
            };

            //Add our Book (poem album) to the library
            library.Add(firstAlbum);

            Console.WriteLine("// ABOUT LIBRARY"); 
            library.AboutLibrary();

        }
    }
}
