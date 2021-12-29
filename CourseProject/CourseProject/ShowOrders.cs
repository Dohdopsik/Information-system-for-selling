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
    
    public partial class ShowOrders : Form
    {
        Model1 db = new Model1();
        public ShowOrders()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            ManagerForm managerForm = new ManagerForm();
            managerForm.Visible = true;
        }

        private void ShowOrders_Load(object sender, EventArgs e)
        {
            ordersBindingSource.DataSource = db.Orders.ToList(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Orders save = (Orders)ordersBindingSource.Current;
            Change_Product_Form frm = new Change_Product_Form();
            frm.db = db;
            DialogResult txt = frm.ShowDialog();
            if (txt == DialogResult.OK)
            {
                ordersBindingSource.DataSource = null;
                ordersBindingSource.DataSource = db.Orders.ToList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
