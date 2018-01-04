using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace LIBRARYMANAGEMENTPART2
{
    public class BORROWER:INotifyPropertyChanged
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

        private string _borrowertype;
        public string BorrowerType
        {
            get { return _borrowertype; }
            set { _borrowertype = value; OnPropertyChanged("BorrowerType"); }
        }
        private string _borrowerfirstname;
        public string BorrowerFirstName
        {
            get { return _borrowerfirstname; }
            set { _borrowerfirstname = value; OnPropertyChanged("BorrowerFirstName"); }
        }
        private string _borrowerlastname;
        public string BorrowerLastName
        {
            get { return _borrowerlastname; }
            set { _borrowerlastname = value; OnPropertyChanged("BorrowerLastName"); }
        }
        private string _borrowergender;
        public string BorrowerGender
        {
            get { return _borrowergender; }
            set { _borrowergender = value; OnPropertyChanged("BorrowerGender"); }
        }
        private int _borroweridnumber;
        public int BorrowerIDNumber
        {
            get { return _borroweridnumber; }
            set { _borroweridnumber = value; OnPropertyChanged("BorrowerIDNumber"); }
        }
        private string _borrowercheckborrowingbooks;
        public string BorrowerCheckBorrowingBooks
        {
            get { return _borrowercheckborrowingbooks; }
            set { _borrowercheckborrowingbooks = value; OnPropertyChanged("BorrowerCheckBorrowingBooks"); }
        }
        private ObservableCollection<BOOK> BorrowerBooksBorrowed = new ObservableCollection<BOOK>();
        public ObservableCollection<BOOK> BORROWERBOOKSBORROWED
        {
            get { return BorrowerBooksBorrowed; }
            set { BorrowerBooksBorrowed = value; }
        }

        public BORROWER() { }

        public BORROWER(string lastname, string firtsname, string gender, string type, int id, string checkborrowing)
        {
            BorrowerLastName = lastname;
            BorrowerFirstName = firtsname;
            BorrowerGender = gender;
            BorrowerType = type;
            BorrowerIDNumber = id;
            BorrowerCheckBorrowingBooks = checkborrowing;
        }

        public override string ToString()
        {
            return BorrowerLastName + ", " + BorrowerFirstName;
        }
    }
}
