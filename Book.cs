

namespace Poem_to_Library
{
    public class Book
    {
        public string title;
        public string author;
        public int noOfPages;

        private Dictionary<int, string> chapters = new Dictionary<int, string>();



        public void makeBook(string title, string author, int noOfPages)
        {
            this.title = title;
            this.author = author;
            this.noOfPages = noOfPages; 
        }

        //Add chapters
        public void addChapters(int chapter, string chapterName)
        {
            chapters.Add(chapter, chapterName);
        }

        //Retrieve the details of a chapter
        public void getChapters(int numberOfChapter)
        {
            foreach (var chapter in this.chapters)
            {
                if (chapter.Key == numberOfChapter)
                {
                    Console.WriteLine($"Chapter {chapter.Key} - {chapter.Value}");
                }
            }
        }
    }
}
