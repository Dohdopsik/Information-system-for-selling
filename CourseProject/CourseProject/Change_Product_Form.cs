using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class Change_Product_Form : Form
    {
        public Model1 db { get; set; }
        public Orders orders { get; set; }

        public Change_Product_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //orders.СтатусЗаказа = comboBox1.SelectedIndex.ToString();
            //try
            //{
            //    db.SaveChanges();
            //    DialogResult = DialogResult.OK;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.InnerException.InnerException.Message);
            //}
            Orders orders = null;
            using (ApplicationContext db = new ApplicationContext())
            {
                //Orders orders = new Orders {СтатусЗаказа = "Оформлен" };
                orders = db.Orders.FirstOrDefault();
                Console.WriteLine("Данные до редактирования:");
                var orders = db.Orders.ToList();
                foreach (Orders o in orders)
                {
                    Console.WriteLine($"{o.СтатусЗаказа}");
                }
            }
            using (ApplicationContext db = new ApplicationContext())
            {
                if (orders != null)
                {
                    orders.СтатусЗаказа = "Выполнен";
                }
                db.SaveChanges();
                Console.WriteLine("Данные после редактирования:");
                var orders = db.Orders.ToList();
                foreach (var o in orders)
                {
                    Console.WriteLine($"{o.СтатусЗаказа}");
                }
            }
            //Orders orders;
            //orders = new Orders();
            //orders.СтатусЗаказа = comboBox1.Text;
            //db.Entry(save).State = EntityState.Modified;
            //Orders ord = db.Orders.Find(datagridview1[j, i].Value.ToString());
            //try
            //{
            //    db.Orders.Update(orders);
            //    db.SaveChanges();
            //    MessageBox.Show("Заказ изменён");
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Товар уже добавлен");
            //    return;
            //}
        }

        private void Change_Product_Form_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}