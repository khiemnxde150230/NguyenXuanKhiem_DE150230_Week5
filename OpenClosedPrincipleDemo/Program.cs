using OpenClosedPrincipleDemo.Utilities;
using OpenClosedPrincipleDemo.Model;

class Program
{
    static List<Book> bookList;
    static void PrintBooks(List<Book> books)
    {
        Console.WriteLine(" List of Books");
        Console.WriteLine("---------------------");
        foreach (var item in books)
        {
            Console.WriteLine($" {item.Title.PadRight(39, ' ')}" + $"{item.Author.PadRight(15, ' ')} {item.Price}");
        }
        Console.ReadLine();
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Please type 'yes' to read an extra file, ");
        Console.WriteLine("or any other word for a single file");
        var ans = Console.ReadLine();
        bookList = (ans.ToLower() != "yes") ? Utilities.ReadData() : Utilities.ReadDataExtra();
        PrintBooks(bookList);
    }
}