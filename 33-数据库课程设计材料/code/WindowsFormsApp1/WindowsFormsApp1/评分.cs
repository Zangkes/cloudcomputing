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
    public partial class teacher1 : Form
    {
        public teacher1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Dao dao = new Dao();
            string sql = $"select * from 作业 where 课程号，学号=('{kechenghao.Text}','{xuehao.Text}')";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString());

            }
            dc.Close();
            dao.DaoClose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Dao dao = new Dao();
            string sql = $"insert into 作业 values ('{textBox1}')";
            dao.Execute(sql);
        }

        private void teacher1_Load(object sender, EventArgs e)
        {
            xianshi();
        }
        public void xianshi()
        {
            dataGridView1.Rows.Clear();
            Dao dao = new Dao();
            string sql = "select 课程号,学号,作业评分 from 作业";
            IDataReader dc = dao.read(sql);

            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString());
                
            }
            dc.Close();
            dao.DaoClose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
