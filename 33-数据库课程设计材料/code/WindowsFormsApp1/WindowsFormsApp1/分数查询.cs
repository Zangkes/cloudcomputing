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
    public partial class student3 : Form
    {
        public student3()
        {
            InitializeComponent();
        }

        public void grade()
        {
            dataGridView1.Rows.Clear();
            Dao dao = new Dao();
            string sql = $"select 课程号,作业评分 from 作业 where 课程号='{textBox1.Text}',学号='{textBox2.Text}'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString());

            }
            dc.Close();
            dao.DaoClose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            grade();
        }

        private void student3_Load(object sender, EventArgs e)
        {
            xianshi();
        }

        public void xianshi()
        {
            dataGridView1.Rows.Clear();
            Dao dao = new Dao();
            string sql = "select 课程号,作业评分 from 作业";
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
