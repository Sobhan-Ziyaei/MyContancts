using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContancts.Repository
{
    interface IContactsRepository
    {
        bool insert(string name, string familyName, string mobile, string Email, int age, string address);

        bool update(int contactId, string name, string familyName, string mobile, string Email, int age, string address);

        bool delete(int contactId);

        DataTable selectAll();

        DataTable selectRow(int contactId);
    }
}
