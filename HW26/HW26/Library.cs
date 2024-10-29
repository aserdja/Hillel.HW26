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
		}

		public void Remove(string isbn)
		{
			var book = Books.Where(b => b.ISBN == isbn).FirstOrDefault();
			Books.Remove(book);
			AvailableBooksCollection.Remove(book);
		}
	}
}
