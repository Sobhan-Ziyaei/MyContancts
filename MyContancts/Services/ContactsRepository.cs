using MyContancts.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContancts.Services
{
    class ContactsRepository : IContactsRepository
    {
        bool IContactsRepository.delete(int contactId)
        {
            throw new NotImplementedException();
        }

        bool IContactsRepository.insert(string name, string familyName, string mobile, string Email, int age, string address)
        {
            throw new NotImplementedException();
        }

        DataTable IContactsRepository.selectAll()
        {
            throw new NotImplementedException();
        }

        DataTable IContactsRepository.selectRow(int contactId)
        {
            throw new NotImplementedException();
        }

        bool IContactsRepository.update(int contactId, string name, string familyName, string mobile, string Email, int age, string address)
        {
            throw new NotImplementedException();
        }
    }
}
