﻿using MyContancts.Repository;
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

        public DataTable search(string parameter)
        {
            //in Sql -> example : where Name like N'%ن' -> get data where Name end with ن
            //----------------- : where Name like N'ن%' -> get data where Name start with ن
            //----------------- : where Name like N'%ن%' -> get data where Name include ن 
            //----------------- : where Name like N'%ن%' or(and) Family like N'%ن%' 
            string query = "Select * From MyContacts where Name like @parameter or Family like @parameter";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query , connection);
            adapter.SelectCommand.Parameters.AddWithValue("@parameter", "%" + parameter + "%");
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;

        }

        bool IContactsRepository.delete(int contactId)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Delete From MyContacts where ContactId=@Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", contactId);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {

                connection.Close();
            }
        }

        bool IContactsRepository.insert(string name, string familyName, string mobile, string email, int age, string address)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                string query = "Insert Into MyContacts (Name,Family,Mobile,Email,Age,Address) values (@name,@familyName,@mobile,@email,@age,@address)";
                //SqlCommand -> تنها کلاسی هست که می‌تواند تغییراتی را در بانک ایجاد بکند
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@familyName", familyName);
                command.Parameters.AddWithValue("@mobile", mobile);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@address", address);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
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
            string query = "Select * from MyContacts where ContactId=" + contactId;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        bool IContactsRepository.update(int contactId, string name, string familyName, string mobile, string email, int age, string address)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Update MyContacts Set Name=@name,Family=@familyName,Mobile=@mobile,Email=@email,Age=@age,Address=@address where ContactId=@Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", contactId);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@familyName", familyName);
                command.Parameters.AddWithValue("@mobile", mobile);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@address", address);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();

            }
        }
    }
}
