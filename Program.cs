using System.Net.Http.Json;

namespace c_working;

class Program
{
    static void Main(string[] args)
    {
        GenericEnumerable<User> userEnumerable = new GenericEnumerable<User>();

        userEnumerable.Add(new User {Name = "Baran", Age = 24});
        userEnumerable.Add(new User {Name = "Baran", Age = 25});

        GenericEnumerable<Book> bookEnumerable = new GenericEnumerable<Book>();

        bookEnumerable.Add(new Book { AuthorName = "Author 1", PageCount = 152});
        bookEnumerable.Add(new Book { AuthorName = "Author 2", PageCount = 690 });

        foreach (User item in userEnumerable)
        {
            Console.WriteLine(item.Name + " " + item.Age.ToString());
        }

        foreach (Book item in bookEnumerable)
        {
            Console.WriteLine(item.AuthorName + " " + item.PageCount.ToString());
        }

        Console.ReadKey();
    }
}
