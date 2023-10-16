using MyContancts.Repository;
using MyContancts.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContancts
{
    public partial class frmAddOrEdit : Form
    {
        IContactsRepository repository;
        public frmAddOrEdit()
        {
            InitializeComponent();
            repository = new ContactsRepository();
        }


        bool validateInputs()
        {


            if (txtName.Text == "")
            {
                MessageBox.Show("لطفا نام خود را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtFamily.Text == "")
            {
                MessageBox.Show("لطفا نام خانوادگی خود را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;


            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("لطفا ایمیل خود را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;


            }
            if (txtAge.Value == 0)
            {
                MessageBox.Show("لطفا سن خود را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (txtMobile.Text == "")
            {
                MessageBox.Show("لطفا موبایل خود را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmAddOrEdit_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (validateInputs())
            {
                bool isSuccess = repository.insert(txtName.Text, txtFamily.Text, txtMobile.Text, txtEmail.Text, (int)txtAge.Value, txtAddress.Text);

                if (isSuccess == true)
                {
                    MessageBox.Show("عملیات با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //DialogResult -> زمانی می‌توانید از این استفاده بکنید که از شودیالوگ استفاده کرده باشید
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("عملیات با شکست مواجه شد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
