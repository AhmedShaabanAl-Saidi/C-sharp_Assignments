using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_
{
    public struct Book
    {
        public string Title {  get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        public Book(string _title , string _author , string _ISBN) 
        {
            Title = _title;
            Author = _author;
            ISBN = _ISBN;
        }

        public override string ToString()
        {
            return $"Book Details : \nBook Title : {Title} , Book Auther : {Author} , Book ISBN : {ISBN}\n";
        }
    }
}
