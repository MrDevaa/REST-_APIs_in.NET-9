using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using FirstAPI.Models;

namespace FirstAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BookController : ControllerBase
	{
		 static List<Book> books = new List<Book>
		{
			new Book { Id = 1, Title = "1984", Author = "George Orwell", YearPublished = 1949 },
			new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", YearPublished = 1960 }
			new Book { Id = 3, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", YearPublished = 1925 }
			new Book { Id = 4, Title = "Pride and Prejudice", Author = "Jane Austen", YearPublished = 1813 }
			new Book { Id = 5, Title = "The Catcher in the Rye", Author = "J.D. Salinger", YearPublished = 1951 }
		};
	}
}