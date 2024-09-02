using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void RunTask()
    {
        int counter = 0;
        do
        {
            Console.WriteLine("What item would you like to work with:");
            Console.WriteLine("1) Book");
            Console.WriteLine("2) DVD");
            string choice = Console.ReadLine();

            Console.WriteLine("Please enter title:");
            string title = Console.ReadLine();
            Console.WriteLine("Please enter ID:");
            string id = Console.ReadLine();
            Console.WriteLine("Please enter release date:");
            DateTime releaseDate = DateTime.TryParse(Console.ReadLine(), out DateTime result) ? result : null;
            bool isBorrowed = false;
    
            if (choice == "1")
            {
                Library bookLibrary = new BookLibrary();
                Book book = new Book();

                book.Title = title;
                book.Id = id;
                book.ReleaseDate = releaseDate;
                book.IsBorrowed = isBorrowed;
                Console.WriteLine("Please enter the author's name:");
                book.Author = Console.ReadLine();
            }
            else if (choice == "2")
            {
                Library dvdLibrary = new DVDLibrary();
                DVD dvd = new DVD();

                dvd.Title = title;
                dvd.Id = id;
                dvd.ReleaseDate = releaseDate;
                dvd.IsBorrowed = isBorrowed;
                Console.WriteLine("Please enter the duration:");
                dvd.Duration = Console.ReadLine();
            }

            Console.WriteLine("Please choose one of the following actions:");
            Console.WriteLine("1) Add to library");
            Console.WriteLine("2) Remove from library");



        } while (counter < 5);
    }
    public static void Main()
    {
        RunTask();
    }
}