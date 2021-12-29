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
    
    public partial class Add_Product_Form : Form
    {
        Model1 db = new Model1();
        public Add_Product_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product;
            product = new Product();
            product.АртикулТовара =Convert.ToInt32(textBox1.Text);
            product.НазваниеТовара = textBox2.Text;
            product.Стоимость = Convert.ToDecimal( textBox3.Text);
            product.ТипТовара = textBox4.Text;
            product.Производитель = textBox5.Text;
            db.Product.Add(product);
            try
            {
                db.SaveChanges();
                MessageBox.Show("Товар добавлен");
            }
            catch (Exception)
            {
                MessageBox.Show("Товар уже добавлен");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowProduct show = new ShowProduct();
            show.Visible = true;
            this.Hide();
        }

        private void Add_Product_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
