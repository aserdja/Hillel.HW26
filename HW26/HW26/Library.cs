using System.Collections.ObjectModel;
using System.Threading.Channels;

namespace HW26
{
	public class Library
	{
		public List<Book> Books = new();
		private readonly Stack<Book> ReturnBooks = new();
		private readonly LinkedList<string> ListOfReaders = new();
		public readonly ObservableCollection<Book> AvailableBooksCollection = new();
		private readonly SortedList<string, Book> BooksISBNSortedList = new();
		private readonly HashSet<string> Genres = new();
		
		public void ReturnBook(Book book)
		{
			ReturnBooks.Push(book);
		}

		public void ProcessReturn()
		{
			Books.Add(ReturnBooks.Pop());
		}

		public void RegisterReader(string name)
		{
			ListOfReaders.AddLast(name);
		}

		public void RemoveReader(string name)
		{
			ListOfReaders.Remove(name);
		}

		public List<string> ShowAllReaders()
		{
			return ListOfReaders.ToList();
		}

		public void Add(Book book)
		{
			Books.Add(book);
			AvailableBooksCollection.Add(book);
			BooksISBNSortedList.Add(book.ISBN, book);
		}

		public void Remove(string isbn)
		{
			var book = Books.Where(b => b.ISBN == isbn).FirstOrDefault();
			Books.Remove(book);
			AvailableBooksCollection.Remove(book);
		}

		public Book FindBookByISBN(string isbn)
		{
			return BooksISBNSortedList[isbn];
		}

		public void RemoveBookByISBN(string isbn)
		{
			BooksISBNSortedList.Remove(isbn);
		}

		public void AddGenre(string genre)
		{
			Genres.Add(genre);
		}

		public List<string> ShowGenres()
		{
			return Genres.ToList();
		}
	}
}
