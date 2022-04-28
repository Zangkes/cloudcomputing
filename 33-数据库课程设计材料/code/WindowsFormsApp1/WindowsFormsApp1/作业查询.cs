using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class student1 : Form
    {
        public student1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }
        public void classID()
        {
            dataGridView1.Rows.Clear();
            Dao dao = new Dao();
            string sql = $"select 作业要求 from 作业 where 课程号='{textBox1.Text}'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(),dc[1].ToString());

            }
            dc.Close();
            dao.DaoClose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            classID();
        }

        private void student1_Load(object sender, EventArgs e)
        {
            xianshi();
        }
        public void xianshi()
        {
            dataGridView1.Rows.Clear();
            Dao dao = new Dao();
            string sql = "select 课程号,作业要求 from 作业";
            IDataReader dc = dao.read(sql);

            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString());

            }
            dc.Close();
            dao.DaoClose();
        }
    }
}
