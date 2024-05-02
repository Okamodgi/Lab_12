using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IBook : IPublisher
{
    string PublicationDate { get; set; }
    int PageCount { get; set; }
    void DisplayBookInfo();
}