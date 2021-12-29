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
    public partial class ShowClients : Form
    {
        Model1 db = new Model1();
        public ShowClients()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ManagerForm managerForm = new ManagerForm();
            managerForm.Visible = true;
        }

        private void ShowClients_Load(object sender, EventArgs e)
        {
            clientsBindingSource.DataSource = db.Clients.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
