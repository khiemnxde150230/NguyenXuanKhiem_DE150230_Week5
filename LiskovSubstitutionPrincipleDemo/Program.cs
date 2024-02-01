using LiskovSubstitutionPrincipleDemo.Model;
using LiskovSubstitutionPrincipleDemo.Utilities;

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
        Console.WriteLine("'topic' to include topic books or any other word for single file");
        var ans = Console.ReadLine();
        bookList = (ans.ToLower() != "yes") && (ans.ToLower() != "topic") ? Utilities.ReadData() : Utilities.ReadData(ans);
        PrintBooks(bookList);
    }
}