using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_
{
    public class LibraryItem
    {
        public int ItemId { get; set; }
        public bool IsAvailable { get; set; }

        public LibraryItem(int _itemId , bool _isAvailable) 
        {
            ItemId = _itemId ;
            IsAvailable = _isAvailable ;
        }

        public string CheckOut(int ItemId)
        {
            return $"Item With that ID : {ItemId} is not Available";
        }

        public string ReturnItem(int ItemId)
        {
            return $"Item With that ID : {ItemId} is Available";
        }
    }
}
