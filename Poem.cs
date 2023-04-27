
using System.ComponentModel;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Poem_to_Library
{
    public class Poem
    {
        public string theme;
        public string poet;
        public string category;

        //I encountered a problem trying to make this private and then pass the value gotten from writePoetry
        //so that we don't have to write the poem without the method. At runtime, "Stack Overflow" 
        //public string content
        //{
        //    get { return theme; }

        //    set { content = value; }
        //}

        //I just had the ignore the get / set thing...
        private string content;


        //move to a method so that a poem can be written without first specifying a topic beforehand
        public string albumName;

        //method to compose poem
        public void writePoetry(string poem)
        {
            content = poem;
        }


        //method to see poem details
        public void aboutPoem(string poemTheme)
        {
            if (poemTheme.ToLower() == theme.ToLower())
            {
                Console.WriteLine($"Theme - {theme.ToUpper()} \n\nPoem: \n{content} \n\nCategory - {category} \nPoet - {poet} \nAlbum - {albumName}");
            }

            else
            {
                Console.WriteLine("No poem with that theme found!");
            }
        }

    }


}
