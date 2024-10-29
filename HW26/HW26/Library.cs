namespace HW26
{
	public class Library
	{
		public List<Book> Books = new();
		private readonly Stack<Book> ReturnBooks = new();
		private readonly LinkedList<string> ListOfReaders = new();

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
	}
}
