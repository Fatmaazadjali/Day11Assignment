using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagement
{
	internal class Author
	{
	   string AuthName;
		string Nationality;
		//int BirthYear;

		public Author() { } //Constructor
		public Author(string AuthorName) { 
		
		  this.AuthName = AuthorName;
			this.Nationality = Nationalityy;
			//this.BirthYear = BirthY;
		}
		
		//public int BirthYear
		//{
		//	get { return BirthYear; }
		//	set { AuthName = value.ToString(); }
		//}
		
		//public int displayAuthorInfo1(int BirthYear) => $"Birth year {this.BirthYear} ";

		public string AuthorName
		{

			get { return this.AuthName; }
			set { this.AuthName = value; }

		}

		public string Nationalityy
		{

			get { return this.Nationality; }
				

		}

		//public int BirthY
		//{

		//	get { return this.BirthYear; }
		//	set { this.BirthYear = value; }
		//}

		public string displayAuthorInfo(string AuthName, string Nationality) => $"Author Name {this.AuthName}   \n Nationality: {Nationalityy}  ";


	}
}
