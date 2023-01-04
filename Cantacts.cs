using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Contacts
{
    class Cantacts : IContacts
    {
        private string connections = "Data Source = .; Initial catalog = Contact_DB; Inegrated Security = true";
        public bool Delete(int contactid)
        {
            throw new NotImplementedException();
        }

        public bool Insert(string name, string family, string email, string address, int age)
        {
            throw new NotImplementedException();
        }

        public DataTable SelectAll()
        {
            throw new NotImplementedException();
        }

        public DataTable SelectRow(int contactId)
        {
            throw new NotImplementedException();
        }

        public bool Update(int contactId, string name, string family, string email, string address, int age)
        {
            throw new NotImplementedException();
        }
    }
}
