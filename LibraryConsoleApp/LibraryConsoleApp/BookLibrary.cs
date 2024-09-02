class BookLibrary : Library
{
    List<IItem>? books;

    public override void Add(IItem book)
    {
        books.Add(book);
    }
    public override void Remove(string title)
    {
        if (!books.Any())
            Console.WriteLine("The library is currently empty.");
        else
        {
            foreach (IItem book in books)
            {
                if (string.Equals(title, book.Title))
                {
                    books.Remove(book);
                }
            }
        }
    }
    public override void Print()
    {
        foreach (IItem book in books)
        {
            Console.WriteLine(book.GetInfo());
        }
    }
}
