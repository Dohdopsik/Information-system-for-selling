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
    public partial class Register : Form
    {
        Model1 db = new Model1();
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1_login.Text == "Номер телефона" || textBox6_Name.Text == "Имя" || textBox4_city.Text == "Город" 
                || textBox2_pass.Text == "Пароль" || textBox3_conf_pass.Text == "Подтверждение пароля")
            {
                MessageBox.Show("Нужно задать все данные");
                return;
            }
            if (textBox2_pass.Text != textBox3_conf_pass.Text)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }
            Users usr = db.Users.Find(textBox1_login.Text);
            Clients cl; 
            if (usr != null)
            {
                MessageBox.Show("Пользователь с таким логином уже существует");
                return;
            }
            usr = new Users();
            usr.Логин = textBox1_login.Text;
            usr.Пароль = textBox2_pass.Text;
            usr.Роль = "Клиент";
            db.Users.Add(usr);
            cl = new Clients();
            cl.Логин = textBox1_login.Text;
            cl.ФИО = textBox6_Name.Text;
            cl.Роль = "Клиент";
            cl.НомерТелефона =Convert.ToDecimal(textBox5_phone.Text);
            cl.Город = textBox4_city.Text;
            cl.Email = textBox7_email.Text;
            db.Clients.Add(cl);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Вы успешно зарегистрировались");
            this.Close();
            Login login = new Login();
            login.Visible = true;
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Visible = true;
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
