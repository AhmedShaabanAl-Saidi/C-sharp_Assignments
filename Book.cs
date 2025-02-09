using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authers { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string _ISBN,string _Title , string[] _Authers , DateTime _PublicationDate , decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authers = _Authers;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }

        public override string ToString()
        {
            return $"""
                Book Details
                ----------------------------------
                ISBN : {ISBN}
                Title : {Title}
                Authers : {string.Join(", ", Authers)}
                PublicationDate : {PublicationDate:d}
                Price : {Price:C}
                """;
        }
    }
}
