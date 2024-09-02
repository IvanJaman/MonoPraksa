class DVDLibrary : Library
{
    List<IItem>? DVDs;

    public override void Add(IItem dvd)
    {
        DVDs.Add(dvd);
    }
    public override void Remove(string title)
    {
        if (!DVDs.Any())
            Console.WriteLine("DVD library is currently empty.");
        else
        {
            foreach (IItem dvd in DVDs)
            {
                if (string.Equals(title, dvd.Title))
                {
                    DVDs.Remove(dvd);
                }
            }
        }
    }
    public override void Print()
    {
        foreach (IItem dvd in DVDs)
        {
            Console.WriteLine(dvd.GetInfo());
        }
    }
}