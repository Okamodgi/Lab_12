using System;
class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book
        {
            Title = "Лолита",
            Author = "Набоков",
            PublicationDate = "2022, 1, 1",
            PageCount = 200
        };

        Book book2 = new Book
        {
            Title = "Английский язык",
            Author = "Кистол",
            PublicationDate = "2008, 8, 21",
            PageCount = 300
        };

        User user1 = new User
        {
            Username = "покупатель1",
            Password = "123"
        };

        User user2 = new User
        {
            Username = "покупатель2",
            Password = "456"
        };

        UserBook userBook1 = new UserBook
        {
            Title = book1.Title,
            Author = book1.Author,
            PublicationDate = book1.PublicationDate,
            PageCount = book1.PageCount,
            Username = user1.Username,
            Password = user1.Password
        };
        UserBook userBook2 = new UserBook
        {
            Title = book2.Title,
            Author = book2.Author,
            PublicationDate = book2.PublicationDate,
            PageCount = book2.PageCount,
            Username = user2.Username,
            Password = user2.Password
        };

        
        userBook1.Purchase();
        userBook1.DisplayDetails();
        userBook1.DisplayUser();

        Console.WriteLine("");
        
        userBook2.Purchase();
        userBook2.DisplayDetails();
        userBook2.DisplayUser();
    }
}