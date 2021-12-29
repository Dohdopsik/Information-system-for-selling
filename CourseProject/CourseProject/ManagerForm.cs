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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
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
            ShowOrders showOrders = new ShowOrders();
            showOrders.Visible = true;
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowProduct showProduct = new ShowProduct();
            showProduct.Visible = true;
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowClients showClients = new ShowClients();
            showClients.Visible = true;
            this.Hide();
        }

 
    }
}
