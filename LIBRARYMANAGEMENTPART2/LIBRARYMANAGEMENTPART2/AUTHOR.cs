using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARYMANAGEMENTPART2
{
    public class AUTHOR
    {

        private string _authorfirstname;
        public string AuthorFirstName
        {
            get { return _authorfirstname; }
            set { _authorfirstname = value; }
        }

        private string _authorlastname;
        public string AuthorLastName
        {
            get { return _authorlastname; }
            set { _authorlastname = value; }
        }

        public AUTHOR() { }

        public AUTHOR(string lastname, string firstname)
        {
            AuthorLastName = lastname;
            AuthorFirstName = firstname;
        }

        public override string ToString()
        {
            return AuthorLastName + ", " + AuthorFirstName;
        }
    }
}
