
namespace Poem_to_Library
{

    #region Class Explanation
        /*
         this is a class that lets us add contents to a library. It can be used not just for books, 
            but also extended to add things like properties to a house, tools to a toolbox, buildings to a street, etc..
            I will be improving the code as time goes on, but for now.. here's Library manager v1.1
        */
    #endregion

    public class LibraryManager<Tcontent, TLibrary> where TLibrary : ICollection<Tcontent>
    {
        //method to add to Library
        public void AddTo(Tcontent content, TLibrary library)
        {
            library.Add(content);
        }
    }
}
