using System.Reflection.Metadata.Ecma335;

namespace BooksManagement
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to Books & Author System!");
			Author author = new Author { 
				
				AuthorName = "J.K. Rowling",
				Nationalityy = "British"
			
			};
			
            Console.WriteLine(author.AuthorName, author.Nationalityy);
          



        }
	}
}