namespace HW26
{
	public class Library
	{
		public List<Book> Books = new();
		private readonly Stack<Book> ReturnBooks = new();

		public void ReturnBook(Book book)
		{
			ReturnBooks.Push(book);
		}

		public void ProcessReturn()
		{
			Books.Add(ReturnBooks.Pop());
		}
	}
}
