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

            //DataGridView -> این کامپوننت یک منبع داده دارد که می‌توان آنرا پر کرد مانند مثال زیر
            dgContacts.DataSource = repository.selectAll();

        }
    }
}