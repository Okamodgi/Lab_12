public class UserBook : IBook, IUser
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string PublicationDate { get; set; }
    public int PageCount { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }

    public void Purchase()
    {
        Console.WriteLine($"Пользователь {Username} купил книгу \"{Title}\".");
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Название: {Title}, Автор: {Author}, Дата публикации: {PublicationDate}, Количество страниц: {PageCount}");
    }

    public void DisplayBookInfo()
    {
        Console.WriteLine($"Название: {Title}, Автор: {Author}, Дата публикации: {PublicationDate}, Количество страниц: {PageCount}");
    }

    public void DisplayUser()
    {
        Console.WriteLine($"Имя: {Username}, Пароль: {Password}");
    }
}