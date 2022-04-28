using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           if(textBox1.Text!=""&&textBox2.Text!="")
           {
                denglu();
           }
           else
           {
                MessageBox.Show("输入不能为空");
           }

        }

        private void 登录_Load(object sender, EventArgs e)
        {
        }
        public void denglu()
        {
            //教师
            if(radioButton1.Checked==true)
            {
                Dao dao = new Dao();
                string sql = "select * from 老师 where 老师账号='" + textBox1.Text + "'and 密码='" + textBox2.Text + "'";
                IDataReader dc = dao.read(sql);
                if(dc.Read())
                {
                    MessageBox.Show("登陆成功");

                    teacher t = new teacher();
                    this.Hide();
                    t.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登陆失败");
                }
                dao.DaoClose();
            }


            //学生
            if (radioButton2.Checked == true)
            
            {
                Dao dao = new Dao();
                string sql = "select * from 学生 where 学号='" + textBox1.Text + "'and 账户密码='" + textBox2.Text + "'";
                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {
                    MessageBox.Show("登陆成功");

                    student s = new student();
                    this.Hide();
                    s.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登陆失败");
                }
                dao.DaoClose();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" ;textBox2.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }

        
}
