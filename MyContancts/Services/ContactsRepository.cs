using MyContancts.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContancts.Services
{
    class ContactsRepository : IContactsRepository
    {
        private string connectionString = "Data Source =.; Initial Catalog = Contact_DB; Integrated Security = true ";

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
            string query = "Select * from MyContacts";
            //درگاه اتصال به پایگاه داده را تعریف می‌کنیم
            SqlConnection connection = new SqlConnection(connectionString);

            //اکنون می‌خواهیم بگوییم تمامی داده‌های پایگاه داده را برایم فراخوانی کن
            //SqlDataAdapter -> یک وانت یا مخزن می‌باشد که داده‌های پایگاه داده را برایمان نگهداری می‌کند
            //اکنون با استفاده از دستور زیر تمامی داده‌ها برایمان فراهم شده است
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            //اکنون باید متغیری را تعریف کنیم تا داده‌ها را از مخزن دریافت کند و داخل خودش بریزد تا استفاده کنیم
            DataTable data = new DataTable();
            adapter.Fill(data);

            //در نهایت می‌خواهیم این داده‌ها را برگردانیم
            return data;

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
