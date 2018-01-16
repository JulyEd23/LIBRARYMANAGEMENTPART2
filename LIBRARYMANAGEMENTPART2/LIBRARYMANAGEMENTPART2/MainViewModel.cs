using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows;
using System.ComponentModel;
using System.Windows.Data;
using System.Data.SqlClient;
using System.Data;

namespace LIBRARYMANAGEMENTPART2
{
    public class MainViewModel
    {
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\JulyEd\Downloads\4th year 2nd semester\OOP\LIBRARYMANAGEMENTPART2\LIBRARYMANAGEMENTPART2\LibraryManagementSysytem.mdf;Integrated Security=True;Connect Timeout=30;");
        public DataTable dt_borrower = new DataTable();
        public DataTable dt_book = new DataTable();
        public DataTable dt_author = new DataTable();

        public MainViewModel()
        {
            SqlDataAdapter node_borrower = new SqlDataAdapter("SELECT LastName,FirstName,Gender,BorrowerType,BorrowerID,BorrowStatus FROM [BORROWER]", con);
            SqlDataAdapter node_book = new SqlDataAdapter("SELECT BookID,Title, Category, Availability,AuthorID FROM[BOOK]", con);
            SqlDataAdapter node_author = new SqlDataAdapter("SELECT AuthorID,LastName,FirstName FROM[Author]", con);

            node_borrower.Fill(dt_borrower);
            node_book.Fill(dt_book);
            node_author.Fill(dt_author);

            viewborrowers = CollectionViewSource.GetDefaultView(BORROWERSLIST);
            viewbooks = CollectionViewSource.GetDefaultView(BOOKSLIST);
            viewviolators = CollectionViewSource.GetDefaultView(VIOLATORSLIST);

            BOOKCATEGORIES.Add("Math");
            BOOKCATEGORIES.Add("Science");
            BOOKCATEGORIES.Add("Religion");
            BOOKCATEGORIES.Add("Arts");
            BOOKCATEGORIES.Add("History");
            BOOKCATEGORIES.Add("English");
            BOOKCATEGORIES.Add("Business");

            //BORROWERSLIST.Add(new Borrower(dt.Rows[0]["LastName"].ToString(), dt.Rows[0]["FirstName"].ToString(), dt.Rows[0]["Gender"].ToString(), dt.Rows[0]["BorrowerType"].ToString(),Convert.ToInt16(dt.Rows[0]["ID"]), CheckBorrowedBook.NONE.ToString()));
            //BORROWERSLIST.Add(new Borrower(dt.Rows[1]["LastName"].ToString(), dt.Rows[1]["FirstName"].ToString(), dt.Rows[1]["Gender"].ToString(), dt.Rows[1]["BorrowerType"].ToString(), Convert.ToInt16(dt.Rows[1]["ID"]), CheckBorrowedBook.NONE.ToString()));
            //BORROWERSLIST.Add(new Borrower(dt.Rows[2]["LastName"].ToString(), dt.Rows[2]["FirstName"].ToString(), dt.Rows[2]["Gender"].ToString(), dt.Rows[2]["BorrowerType"].ToString(), Convert.ToInt16(dt.Rows[2]["ID"]), CheckBorrowedBook.NONE.ToString()));
            //BORROWERSLIST.Add(new Borrower(dt.Rows[3]["LastName"].ToString(), dt.Rows[3]["FirstName"].ToString(), dt.Rows[3]["Gender"].ToString(), dt.Rows[3]["BorrowerType"].ToString(), Convert.ToInt16(dt.Rows[3]["ID"]), CheckBorrowedBook.NONE.ToString()));
            //BORROWERSLIST.Add(new Borrower(dt.Rows[4]["LastName"].ToString(), dt.Rows[4]["FirstName"].ToString(), dt.Rows[4]["Gender"].ToString(), dt.Rows[4]["BorrowerType"].ToString(), Convert.ToInt16(dt.Rows[4]["ID"]), CheckBorrowedBook.NONE.ToString()));
            //BORROWERSLIST.Add(new Borrower("Ottoman", "GG", "Male", "Teacher", 12345, CheckBorrowedBook.NONE.ToString()));
            //BORROWERSLIST.Add(new Borrower("Ferraren", "Jiji", "Female", "Teacher", 37702, CheckBorrowedBook.NONE.ToString()));
            //BORROWERSLIST.Add(new Borrower("Nursing", "Puti", "Female", "Student", 72635, CheckBorrowedBook.NONE.ToString()));
            //BORROWERSLIST.Add(new Borrower("Saluage", "Angelito", "Male", "Teacher", 25363, CheckBorrowedBook.NONE.ToString()));
            ShowTable();
            //BOOKSLIST.Add(new Book(dt1.Rows[0]["Title"].ToString(), dt1.Rows[0]["Category"].ToString(),dt2.Rows[0]["LastName"].ToString(), dt2.Rows[0]["FirstName"].ToString(), Convert.ToInt16(dt1.Rows[0]["ID"]), dt1.Rows[0]["Availability"].ToString()));
            //BOOKSLIST.Add(new Book(dt1.Rows[1]["Title"].ToString(), dt1.Rows[1]["Category"].ToString(),dt2.Rows[1]["LastName"].ToString(), dt2.Rows[1]["FirstName"].ToString(), Convert.ToInt16(dt1.Rows[1]["ID"]), dt1.Rows[1]["Availability"].ToString()));
            //BOOKSLIST.Add(new Book(dt1.Rows[2]["Title"].ToString(), dt1.Rows[2]["Category"].ToString(),dt2.Rows[2]["LastName"].ToString(), dt2.Rows[2]["FirstName"].ToString(), Convert.ToInt16(dt1.Rows[2]["ID"]), dt1.Rows[2]["Availability"].ToString()));
            //BOOKSLIST.Add(new Book(dt1.Rows[3]["Title"].ToString(), dt1.Rows[3]["Category"].ToString(),dt2.Rows[3]["LastName"].ToString(), dt2.Rows[3]["FirstName"].ToString(), Convert.ToInt16(dt1.Rows[3]["ID"]), dt1.Rows[3]["Availability"].ToString()));
            //BOOKSLIST.Add(new Book(dt1.Rows[4]["Title"].ToString(), dt1.Rows[4]["Category"].ToString(),dt2.Rows[4]["LastName"].ToString(), dt2.Rows[4]["FirstName"].ToString(), Convert.ToInt16(dt1.Rows[4]["ID"]), dt1.Rows[4]["Availability"].ToString()));
        }

        public void ShowTable()
        {
            con.Open();
            for (int i = 0;i<dt_borrower.Rows.Count;i++)
            {
                BORROWERSLIST.Add(new BORROWER(dt_borrower.Rows[i]["LastName"].ToString(), dt_borrower.Rows[i]["FirstName"].ToString(), dt_borrower.Rows[i]["Gender"].ToString(), dt_borrower.Rows[i]["BorrowerType"].ToString(), Convert.ToInt16(dt_borrower.Rows[i]["BorrowerID"]), dt_borrower.Rows[i]["BorrowStatus"].ToString()));
            }
            for(int i = 0; i<dt_book.Rows.Count;i++)
            {
                BOOKSLIST.Add(new BOOK(dt_book.Rows[i]["Title"].ToString(), dt_book.Rows[i]["Category"].ToString(), int.Parse(dt_book.Rows[i]["AuthorID"].ToString()), Convert.ToInt16(dt_book.Rows[i]["BookID"]), dt_book.Rows[i]["Availability"].ToString()));
            }
            con.Close();
        }

        //public void Insert_Testing()
        //{
        //    SqlCommand _cmmnd = new SqlCommand();
        //    _cmmnd = new SqlCommand("INSERT INTO [AUTHOR](Id,LastName,FirstName) VALUES(@Id,@LastName,@FirstName)", con);
        //    _cmmnd.Parameters.AddWithValue("@Id", 8);
        //    _cmmnd.Parameters.AddWithValue("@LastName", "WeW");
        //    _cmmnd.Parameters.AddWithValue("@FirstName", "yayayayayay");
        //    con.Open();
        //    _cmmnd.ExecuteNonQuery();
        //    con.Close();
        //}

        ////////////////////////////////////////////// ICOLLECTION ///////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////

        public ICollectionView viewborrowers;

        public ICollectionView viewbooks;

        public ICollectionView viewviolators;

        ////////////////////////////////////////////// SEARCH ///////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////

        private string _searchtextborrower;
        public string SearchTextBorrower
        {
            get { return _searchtextborrower; }
            set
            {
                _searchtextborrower = value;
                viewborrowers.Filter = FilterBorrower;
            }
        }
        private bool FilterBorrower(object o)
        {
            var item = o as BORROWER;
            if(item == null)
            {
                return false;
            }
            else
            {
                return (item.BorrowerFirstName.ToLower().Contains(SearchTextBorrower.ToLower()) || item.BorrowerGender.ToLower().Contains(SearchTextBorrower.ToLower()) || item.BorrowerIDNumber.ToString().ToLower().Contains(SearchTextBorrower.ToLower()) || item.BorrowerLastName.ToLower().Contains(SearchTextBorrower.ToLower()) || item.BorrowerType.ToLower().Contains(SearchTextBorrower.ToLower()));
            }
        }


        private string _searchtextbooks;
        public string SearchTextBooks
        {
            get { return _searchtextbooks; }
            set
            {
                _searchtextbooks = value;
                viewbooks.Filter = FilterBooks;
            }
        }
        private bool FilterBooks(object o)
        {
            var item = o as BOOK;
            if(item == null)
            {
                return false;
            }
            else
            {
                return (item.BookCategory.ToLower().Contains(SearchTextBooks.ToLower())||item.BookIDNumber.ToString().Contains(SearchTextBooks.ToLower())||item.BookTitle.ToLower().Contains(SearchTextBooks.ToLower()));
            }
        }

        //////////////////////////////////////////// BOOKS ////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////

        public BOOK SelectedBook { get; set; }

        private ObservableCollection<BOOK> BooksList = new ObservableCollection<BOOK>();
        public ObservableCollection<BOOK> BOOKSLIST
        {
            get { return BooksList; }
            set { BooksList = value; }
        }

        public string title { get; set; }
        public string category { get; set; }
        public int numberofcopies { get; set; }
        public ObservableCollection<int> bookid { get; set; } = new ObservableCollection<int>();
        public string authorfirstname { get; set; } 
        public string authorlastname { get; set; }
        //public Author selectedauthor { get; set; }
        //public ObservableCollection<Author> bookauthor { get; set; } = new ObservableCollection<Author>();

        public void AddBook()
        {
            var addbookwindow = new AddBookWindow();
            addbookwindow.DataContext = this;
            var result = addbookwindow.ShowDialog();
            if(result == true)
            {
                if (title == null | category == null | bookid.Count == 0 | authorfirstname == null|authorlastname == null)
                {
                    MessageBox.Show("incomplete of filling up the information");
                }
                else
                {
                    //for (int i = 0; i < bookid.Count; i++)
                    //{
                    //    var newbook = new BOOK();
                    //    newbook.BookTitle = title;
                    //    newbook.BookCategory = category;
                    //    newbook.BookAvailability = Availability.AVAILABLE.ToString();
                    //    for (int a = 0; a < bookauthor.Count; a++)
                    //    {
                    //        newbook.BOOKAUTHOR.Add(bookauthor[a]);
                    //    }
                    //    newbook.BookIDNumber = bookid[i];
                    //    BOOKSLIST.Add(newbook);
                    //}
                    SqlCommand command_addauthor = new SqlCommand("INSERT INTO [AUTHOR](LastName,FirstName) VALUES(@LastName,@FirstName)", con);
                    //SqlCommand command_author = new SqlCommand("INSERT INTO [AUTHOR](AuthorID,LastName,FirstName) VALUES(@AuhtorID,@LastName,@FirstName)", con);
                    //command_author.Parameters.AddWithValue("@AuhtorID",dt_author.Rows.Count+1);
                    command_addauthor.Parameters.AddWithValue("@LastName", authorlastname);
                    command_addauthor.Parameters.AddWithValue("@FirstName", authorfirstname);
                    con.Open();
                    command_addauthor.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(dt_author.Rows.Count.ToString());
                    for (int i = 0;i<bookid.Count;i++)
                    {
                        //SqlCommand command_book = new SqlCommand("INSERT INTO [BOOK](BookID,Title,Category,Availability,AuthorID) VALUES(@BookID,@Title,@Category,@Availability,@AuthorID)", con);
                        SqlCommand command_addbook = new SqlCommand("INSERT INTO [BOOK](Title,Category,Availability,AuthorID) VALUES(@Title,@Category,@Availability,@AuthorID)", con);
                        //command_book.Parameters.AddWithValue("@BookID", bookid[i]);
                        command_addbook.Parameters.AddWithValue("@Title", title);
                        command_addbook.Parameters.AddWithValue("@Category", category);
                        command_addbook.Parameters.AddWithValue("@Availability", Availability.AVAILABLE.ToString());
                        command_addbook.Parameters.AddWithValue("@AuthorID", int.Parse(dt_author.Rows[dt_author.Rows.Count-1]["AuthorID"].ToString()));
                        BOOKSLIST.Add(new BOOK(title, category, int.Parse(dt_author.Rows[dt_author.Rows.Count - 1]["AuthorID"].ToString()), bookid[i], Availability.AVAILABLE.ToString()));
                        con.Open();
                        command_addbook.ExecuteNonQuery();
                        con.Close();
                    }
                    //for(int i = 0;i<bookauthor.Count;i++)
                    //{
                    //    SqlCommand command_author = new SqlCommand()
                    //}
                }
                //title = null;
                //category = null;
                //authorfirstname = null;
                //authorlastname = null;
                //bookid.Clear();
                //bookauthor.Clear();
            }
            //else
            //{
            //    title = null;
            //    category = null;
            //    bookid.Clear();
            //    bookauthor.Clear();
            //}
            title = null;
            category = null;
            authorfirstname = null;
            authorlastname = null;
            bookid.Clear();
        }

        public void ViewBooksList()
        {
            var bookslistwindow = new BooksListWindow();
            bookslistwindow.DataContext = this;
            bookslistwindow.ShowDialog();
        }

        //public void AddBookAuthor()
        //{
        //    bookauthor.Add(new Author(authorlastname, authorfirstname));
        //}
        //public void DeleteBookAuthor()
        //{
        //    bookauthor.Remove(selectedauthor);
        //}

        public DateTime bookdateborrowed { get; set; }

        public void BorrowBook()
        {
            var borrowbookwindow = new BorrowBooksWindow();
            borrowbookwindow.DataContext = this;
            var result = borrowbookwindow.ShowDialog();
            if(result == true)
            {
                SelectedBorrower.BORROWERBOOKSBORROWED.Add(SelectedBook);
                con.Open();
                SqlCommand command_borrower = new SqlCommand("UPDATE [BORROWER] SET BorrowStatus=@BorrowStatus  WHERE BorrowerID=@BorrowerID", con);
                SqlCommand command_book = new SqlCommand("UPDATE [BOOK] SET Availability=@Availability WHERE BookID=@BookID", con);
                //SqlCommand command_process = new SqlCommand("INSERT INTO [PROCESS](LastName,FirstName) VALUES(@LastName,@FirstName)", con);
                for (int i = 0; i<dt_book.Rows.Count;i++)
                {
                    if(SelectedBook.BookIDNumber == int.Parse(dt_book.Rows[i]["BookID"].ToString()))
                    {
                        command_book.Parameters.Add("@BookID", SelectedBook.BookIDNumber);
                        command_book.Parameters.Add("@Availability",Availability.UNAVAILABLE.ToString());
                        break;
                    }
                }
                for (int i = 0; i < dt_book.Rows.Count; i++)
                {
                    if (SelectedBook.BookIDNumber == BOOKSLIST[i].BookIDNumber)
                    {
                        BOOKSLIST[i].BookAvailability = Availability.UNAVAILABLE.ToString();
                        break;
                    }
                }

                for (int i = 0;i<dt_borrower.Rows.Count;i++)
                {
                    if(SelectedBorrower.BorrowerIDNumber == int.Parse(dt_borrower.Rows[i]["BorrowerID"].ToString()))
                    {
                        command_borrower.Parameters.Add("@BorrowerID", SelectedBorrower.BorrowerIDNumber);
                        command_borrower.Parameters.Add("@BorrowStatus", CheckBorrowedBook.BORROWING.ToString());
                        break;
                    }
                }
                for (int i = 0; i < dt_borrower.Rows.Count; i++)
                {
                    if (SelectedBorrower.BorrowerIDNumber == BORROWERSLIST[i].BorrowerIDNumber)
                    {
                        BORROWERSLIST[i].BorrowerCheckBorrowingBooks = CheckBorrowedBook.BORROWING.ToString();
                        break;
                    }
                }
                command_book.ExecuteNonQuery();
                command_borrower.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully borrowed the book");




                //SelectedBook.BookAvailability = Availability.UNAVAILABLE.ToString();
                //SelectedBook.BookDateBorrowed = bookdateborrowed;
                //if(SelectedBorrower.BorrowerType == "Student")
                //{
                //    SelectedBook.BookDateDeadline = SelectedBook.BookDateBorrowed.AddDays(7);
                //    MessageBox.Show("Date Borrowed: " + SelectedBook.BookDateBorrowed.ToString("MMMM dd, yyyy") + "\n" + "Date Deadline: " + SelectedBook.BookDateDeadline.ToString("MMMM dd, yyyy"));
                //}
                //else
                //{
                //    SelectedBook.BookDateDeadline = SelectedBook.BookDateBorrowed.AddDays(14);
                //    MessageBox.Show("Date Borrowed: " + SelectedBook.BookDateBorrowed.ToString("MMMM dd, yyyy") + "\n" + "Date Deadline: " + SelectedBook.BookDateDeadline.ToString("MMMM dd, yyyy"));
                //}
                //SelectedBorrower.BORROWERBOOKSBORROWED.Add(SelectedBook);
                //if(SelectedBorrower.BORROWERBOOKSBORROWED.Count>0)
                //{
                //    SelectedBorrower.BorrowerCheckBorrowingBooks = CheckBorrowedBook.BORROWING.ToString();
                //}
                //SelectedBook = null;
            }
        }

        public void BooksListWindow()
        {
            var bookslistwindow = new BooksListWindow();
            bookslistwindow.DataContext = this;
            bookslistwindow.ShowDialog();
        }

        public void DeleteBook()
        {
            if (SelectedBook != null)
            {
                BOOKSLIST.Remove(SelectedBook);
                SelectedBook = null;
            }
            else
            {
                MessageBox.Show("Select a book to delete");
            }
        }

        ////////////////////////////////////////// BORROWER //////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////

        public BORROWER SelectedBorrower { get; set; }

        public string lastname { get; set; }
        public string firstname { get; set; }
        public string gender { get; set; }
        public string type { get; set; }
        public int idnumber { get; set; }
        
        private ObservableCollection<BORROWER> BorrowersList = new ObservableCollection<BORROWER>();
        public ObservableCollection<BORROWER> BORROWERSLIST
        {
            get { return BorrowersList; }
            set { BorrowersList = value; }
        }

        public void AddBorrower()
        {
            var addborrowerwindow = new AddBorrowerWindow();
            addborrowerwindow.DataContext = this;
            var result = addborrowerwindow.ShowDialog();
            if(result == true)
            {
                if (firstname == null | lastname == null | gender == null | type == null)
                {
                    MessageBox.Show("incomplete of filling up the information");
                }
                else
                {
                    SqlCommand command_borrower = new SqlCommand("INSERT INTO [BORROWER](LastName,Gender,FirstName,BorrowerType,BorrowStatus) VALUES(@LastName,@Gender,@FirstName,@BorrowerType,@BorrowStatus)", con);
                    //SqlCommand command_borrower = new SqlCommand("INSERT INTO [BORROWER](ID,LastName,Gender,FirstName,BorrowerType,BorrowStatus) VALUES(@ID,@LastName,@Gender,@FirstName,@BorrowerType,@BorrowStatus)", con);
                    //command_borrower.Parameters.AddWithValue("@ID", idnumber);
                    command_borrower.Parameters.AddWithValue("@LastName", lastname);
                    command_borrower.Parameters.AddWithValue("@Gender", gender);
                    command_borrower.Parameters.AddWithValue("@FirstName", firstname);
                    command_borrower.Parameters.AddWithValue("@BorrowerType", type);
                    command_borrower.Parameters.AddWithValue("@BorrowStatus", CheckBorrowedBook.NONE.ToString());
                    con.Open();
                    command_borrower.ExecuteNonQuery();
                    con.Close();
                    BORROWERSLIST.Add(new BORROWER(lastname, firstname, gender, type, idnumber, CheckBorrowedBook.NONE.ToString()));
                    MessageBox.Show("successfully added the borrower");
                }
            }
            lastname = null;
            firstname = null;
            gender = null;
            type = null;
        }
        public BORROWER editborrower = new BORROWER();
        public void EditBorrower()
        {
            var editborrowerwindow = new EditBorrowerWindow();

            editborrower.BorrowerLastName = SelectedBorrower.BorrowerLastName;
            editborrower.BorrowerFirstName = SelectedBorrower.BorrowerFirstName;
            editborrower.BorrowerGender = SelectedBorrower.BorrowerGender;
            editborrower.BorrowerType = SelectedBorrower.BorrowerType;

            editborrowerwindow.DataContext = editborrower;
            var result = editborrowerwindow.ShowDialog();
            if(result == true)
            {
                SelectedBorrower.BorrowerLastName = editborrower.BorrowerLastName;
                SelectedBorrower.BorrowerFirstName = editborrower.BorrowerFirstName;
                SelectedBorrower.BorrowerGender = editborrower.BorrowerGender;
                SelectedBorrower.BorrowerType = editborrower.BorrowerType;
            }
        }


        /////////////////////////////////////////// CATEGORY /////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////

        private ObservableCollection<string> BookCategories = new ObservableCollection<string>();
        public ObservableCollection<string> BOOKCATEGORIES
        {
            get { return BookCategories; }
            set { BookCategories = value; }
        }

        public string addcategory { get; set; }

        public void AddCategory()
        {
            var addcategorywindow = new AddCategoryWindow();
            addcategorywindow.DataContext = this;
            var result = addcategorywindow.ShowDialog();
            if(result == true)
            {
                BOOKCATEGORIES.Add(addcategory);
            }
        }

        public string selectedcategory { get; set; }

        public void DeleteCategory()
        {
            BOOKCATEGORIES.Remove(selectedcategory);
        }

        ///////////////////////////////////////////// RETURN ///////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////

        public BOOK SelectedReturnBook { get; set; }

        public void ReturnBook()
        {
            var returnbookwindow = new BorrowersBorrowedBooks();
            returnbookwindow.DataContext = this;
            var result = returnbookwindow.ShowDialog();
            if(result == true)
            {
                for(int i = 0;i<BOOKSLIST.Count;i++)
                {
                    if(SelectedReturnBook.BookIDNumber == BOOKSLIST[i].BookIDNumber)
                    {

                    }
                }

                con.Open();
                SqlCommand command_returnbook = new SqlCommand("UPDATE [BOOK] SET Availability=@Availability WHERE BookID=@BookID", con);
                SqlCommand command_returnborrower = new SqlCommand("UPDATE [BORROWER] SET BorrowStatus=@BorrowStatus  WHERE ID=@ID", con);
                for (int i =0;i<dt_book.Rows.Count;i++)
                {
                    if(int.Parse(dt_book.Rows[i]["BookID"].ToString())==SelectedReturnBook.BookIDNumber)
                    {
                        command_returnbook.Parameters.Add("@BookID", SelectedReturnBook.BookIDNumber);
                        command_returnbook.Parameters.Add("@Availability", Availability.AVAILABLE.ToString());
                        break;
                    }
                }
                for(int i = 0; i < BOOKSLIST.Count; i++)
                {
                    if (int.Parse(dt_book.Rows[i]["BookID"].ToString()) == SelectedReturnBook.BookIDNumber)
                    {
                        BOOKSLIST[i].BookAvailability = Availability.AVAILABLE.ToString();
                        break;
                    }
                }

                for (int i = 0; i < dt_borrower.Rows.Count; i++)
                {
                    if (int.Parse(dt_borrower.Rows[i]["BorrowerID"].ToString()) == SelectedBorrower.BorrowerIDNumber)
                    {
                        command_returnborrower.Parameters.Add("@BorrowerID", SelectedBorrower.BorrowerIDNumber);
                        command_returnborrower.Parameters.Add("@BorrowStatus", CheckBorrowedBook.NONE.ToString());
                        break;
                    }
                }
                for (int i = 0; i < BORROWERSLIST.Count; i++)
                {
                    if (BORROWERSLIST[i].BorrowerIDNumber == SelectedBorrower.BorrowerIDNumber)
                    {
                        BORROWERSLIST[i].BorrowerCheckBorrowingBooks = CheckBorrowedBook.NONE.ToString();
                        break;
                    }
                }

                command_returnbook.ExecuteNonQuery();
                command_returnborrower.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(SelectedBorrower.BorrowerFirstName+" returned the book "+SelectedReturnBook.BookTitle);
                //for(int a = 0;a< BOOKSLIST.Count; a++)
                //{
                //    if(BOOKSLIST[a].BookIDNumber == SelectedReturnBook.BookIDNumber)
                //    {
                //        BOOKSLIST[a].BookAvailability = Availability.AVAILABLE.ToString();
                //        SelectedBorrower.BORROWERBOOKSBORROWED.Remove(SelectedReturnBook);
                //        if (SelectedBorrower.BORROWERBOOKSBORROWED.Count > 0)
                //        {
                //            SelectedBorrower.BorrowerCheckBorrowingBooks = CheckBorrowedBook.BORROWING.ToString();
                //        }
                //        else if(SelectedBorrower.BORROWERBOOKSBORROWED.Count == 0)
                //        {
                //            SelectedBorrower.BorrowerCheckBorrowingBooks = CheckBorrowedBook.NONE.ToString();
                //        }
                //        SelectedReturnBook = null;
                //        break;
                //    }
                //}
                //MessageBox.Show("successfully returned the book");
            }
        }


        ////////////////////////////////////////////// VIOLATORS or FINES ///////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////

        private ObservableCollection<Violator> ViolatorsList = new ObservableCollection<Violator>();

        public ObservableCollection<Violator> VIOLATORSLIST
        {
            get { return ViolatorsList; }
            set { ViolatorsList = value; }
        }
        
        public DateTime violatordatefined { get; set; }
        public int violatorfine { get; set; }

        public void FinedViolators()
        {
            var newviolator = new Violator();
            newviolator.ViolatorLastName = SelectedBorrower.BorrowerLastName;
            newviolator.ViolatorFirstName = SelectedBorrower.BorrowerFirstName;
            newviolator.ViolatorDateFined = violatordatefined;
            newviolator.ViolatorTotalFine = violatorfine;

            VIOLATORSLIST.Add(newviolator);
        }
        
        /////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////

        public enum Availability
        {
            AVAILABLE,
            UNAVAILABLE
        }

        public enum CheckBorrowedBook
        {
            NONE,
            BORROWING
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void logInNewWindow()
        {
            var _loginwindow = new LogInUserWindow();
            _loginwindow.Show();
        }

    }
}
