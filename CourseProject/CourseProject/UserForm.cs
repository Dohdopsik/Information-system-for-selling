using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class UserForm : Form
    {
        int i;
        Model1 db = new Model1();
        public UserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Visible = true;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Users usr = db.Users.FirstOrDefault(x => x.Логин == Login.USER.Логин);
            Product product = (Product)productbindingSource.Current;
            Orders ord = db.Orders.Find(i);
            ord = db.Orders.Find(i);
            if (ord == null)
            {
                ord = new Orders();
                ord.НомерЗаказа = i;
                ord.Дата = DateTime.Now;
                ord.ТипЗаказа = product.ТипТовара;
                ord.СтатусЗаказа = "Оформлен";
                ord.Клиент = usr.Логин;
                ord.АртикулТовара = product.АртикулТовара;
                ord.Стоимость = product.Стоимость;
                db.Orders.Add(ord);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Заказ успешно создан");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            productbindingSource.DataSource = db.Product.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
