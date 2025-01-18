using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_
{
    public class BorrowedBook : LibraryItem
    {
        public Book BookDetails { get; set; }
        public string BorrowerName { get; set; }
        public DateTime BorrowedDate { get; set; }

        public BorrowedBook(int _itemId, bool _isAvailable ,Book _bookDetails, string _borrowerName , DateTime _borrowedDate) : base(_itemId , _isAvailable)
        {
            BookDetails = _bookDetails;
            BorrowerName = _borrowerName;
            BorrowedDate = _borrowedDate;
        }

        public int CalculateBorrowDuration()
        {
            return (DateTime.Now - BorrowedDate).Days;
        }

        public override string ToString()
        {
            return $"Borrowed Book Details : {BookDetails},BorrowerName : {BorrowerName} , BorrowedDate : {BorrowedDate}";
        }
    }
}
