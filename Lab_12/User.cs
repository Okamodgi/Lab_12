using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class User : IUser
{
    public string Username { get; set; }
    public string Password { get; set; }
    public void DisplayUser()
    {
        Console.WriteLine($"Имя: {Username}, Пароль: {Password}");
    }
}
