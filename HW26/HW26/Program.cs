namespace HW26
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var libra = new Library();
			libra.AvailableBooksCollection.CollectionChanged += (s, e) => Console.WriteLine($"{e.Action} a book!");
			libra.Add(new Book { Title = "TestBook", ISBN = "123-456" });
			libra.Remove("123-456");
		}
	}
}
