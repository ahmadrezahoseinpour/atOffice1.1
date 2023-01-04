using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Contacts
{
    interface IContacts
    {
        //Some Methods ...
        DataTable SelectAll();
        DataTable SelectRow(int contactId);

        //some anothers insert, update, delete

        bool Insert(string name, string family, string email, string address, int age);
        bool Update(int contactId, string name, string family, string email, string address, int age);
        bool Delete(int contactid);



    }
}
