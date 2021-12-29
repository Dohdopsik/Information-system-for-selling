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

    public partial class Login : Form
    {
        Model1 db = new Model1();
        
        public static Login VHOD { get; set; }
        public static Users USER { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Нужно задать пароль и логин");
                return;
            }
            Users usr = db.Users.Find(textBox2.Text);
            if ((usr != null ) && (usr.Пароль == textBox1.Text ))
            {
                USER = usr;
                VHOD = this;

                if (usr.Роль == "Клиент")
                {
                    UserForm userform = new UserForm();
                    userform.Visible = true;
                    this.Hide();
                }    
                if (usr.Роль == "Менеджер")
                {
                    ManagerForm managerForm = new ManagerForm();
                    managerForm.Visible = true;
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Такого пользователя не существует или неправильно введены данные");
                textBox1.Text = "";
                return;
            }                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register form = new Register();
            form.Visible = true;
            this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
