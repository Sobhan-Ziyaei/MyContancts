using MyContancts.Repository;
using MyContancts.Services;

namespace MyContancts
{
    public partial class Form1 : Form
    {
        //ابتدا یک شی از کلاس اینترفیس میسازیم ولی آنرا مقداردهی نمی‌کنیم و در کانستراکتور آن را مقدار دهی میکنیم
        IContactsRepository repository;
        public Form1()
        {
            InitializeComponent();
            //fill repository with implements class -> شی ریپازیتوری را با کلاس هایی که ایمپلمنت کرده بودیم پر میکنیم
            repository = new ContactsRepository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form_Load -> زمانی که این فرم ساخته می‌شود این متود فراخوانی می‌شود

            BindGrid();

        }



        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            //می‌خواهیم قبل از بارگزاری داده‌ها سربرگ‌ها را تغییر دهیم مثلا فارسی شان بکنیم
            dgContacts.AutoGenerateColumns = false;



            //DataGridView -> این کامپوننت یک منبع داده دارد که می‌توان آنرا پر کرد مانند مثال زیر
            dgContacts.DataSource = repository.selectAll();
        }

        private void btnNewContact_Click(object sender, EventArgs e)
        {
            //میخواهیم بگوییم زمانی که روی این کلیک زده شد بره و فرم جدید که برای ثبت اطلاعات فرد ساختیم را فراخوانی بکند
            frmAddOrEdit frmAddOrEdit = new frmAddOrEdit();
            //frmAddOrEdit.Show();
            frmAddOrEdit.ShowDialog();
            //ShowDialog vs Show -> تفاوت اش این است که در شو معمولی کاربر می‌تواند دوباره مثلا دکمه‌های فرم را بزند ولی در اون یکی نمی‌تواند
            //----------------------------------------
        }
    }
}