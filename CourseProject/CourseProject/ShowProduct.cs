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
    public partial class ShowProduct : Form
    {
        Model1 db = new Model1();
        
        public ShowProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ManagerForm managerForm = new ManagerForm();
            managerForm.Visible = true;
        }

        private void ShowProduct_Load(object sender, EventArgs e)
        {
            productBindingSource.DataSource = db.Product.ToList();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            Add_Product_Form add_Product = new Add_Product_Form();
            add_Product.Visible = true;
            this.Hide();
        }

        private void Del_button_Click(object sender, EventArgs e)
        {
            Product del_product = (Product)productBindingSource.Current;
            DialogResult dr = MessageBox.Show("Удалить " + del_product.НазваниеТовара + "?", "Удаление ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.Product.Remove(del_product);
                try
                {
                    db.SaveChanges();
                    productBindingSource.DataSource = db.Product.ToList();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.InnerException.InnerException.Message);
                }
            }
        }
        //
    }
}
