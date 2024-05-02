using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Book : IBook
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string PublicationDate { get; set; }
    public int PageCount { get; set; }
    public void DisplayDetails()
    {
        Console.WriteLine($"Название: {Title}, Автор: {Author}, Дата публикации: {PublicationDate}, Количество страниц: {PageCount}");
    }

    public void DisplayBookInfo()
    {
        Console.WriteLine($"Название: {Title}, Автор: {Author}, Дата публикации: {PublicationDate}, Количество страниц: {PageCount}");
    }
}