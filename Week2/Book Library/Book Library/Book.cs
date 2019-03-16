using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Library
{
    public enum eCoverType
    {
        softCover,
        hardCover
    }

    public class Book
    {
        private string _title;
        private string _author;
        private int _price;
        private eCoverType _coverType;

        public string getTitle()
        {
            return _title;
        }
        public string getAuthor()
        {
            return _author;
        }
        public int getPrice()
        {
            return _price;
        }
        public eCoverType getCoverType()
        {
            return _coverType;
        }
        public Book(string title, string author, int price, eCoverType coverType)
        {
            this._title = title; 
            this._author = author; 
            this._price = price; 
            this._coverType = coverType; 
        }
    }
}
