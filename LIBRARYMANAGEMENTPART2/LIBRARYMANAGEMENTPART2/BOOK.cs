using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace LIBRARYMANAGEMENTPART2
{
    public class BOOK:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private string _booktitle;
        public string BookTitle
        {
            get { return _booktitle; }
            set { _booktitle = value; }
        }

        private string _bookcategory;
        public string BookCategory
        {
            get { return _bookcategory; }
            set { _bookcategory = value; }
        }

        private int _bookidnumber;
        public int BookIDNumber
        {
            get { return _bookidnumber; }
            set { _bookidnumber = value; }
        }

        private string bookavailability;
        public string BookAvailability
        {
            get { return bookavailability; }
            set { bookavailability = value; OnPropertyChanged("BookAvailability"); }
        }
        public DateTime BookDateBorrowed { get; set; }
        public DateTime BookDateDeadline { get; set; }
        public DateTime BookDateReturn { get; set; }
        private int bookauthorid;
        public int BookAuthorID
        {
            get { return bookauthorid; }
            set { bookauthorid = value; }
        }
        //private ObservableCollection<Author> BookAuthor = new ObservableCollection<Author>();
        //public ObservableCollection<Author> BOOKAUTHOR
        //{
        //    get { return BookAuthor; }
        //    set { BookAuthor = value; }
        //}
        /// <extra>
        //public string BookAuthorName { get; set; }
        /// </extra>

        public BOOK() { }

        public BOOK(string title, string category, int authorid, int id, string availability)
        {
            BookTitle = title;
            BookCategory = category;
            BookAuthorID = authorid;
            BookIDNumber = id;
            BookAvailability = availability;
        }
    }
}
