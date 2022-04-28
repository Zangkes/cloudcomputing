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
    public partial class student2 : Form
    {
        public student2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Dao dao = new Dao();
            string sql = $"update 作业 set 作业内容=('{textBox2}')";
            int n = dao.Execute(sql);
            if (n > 0)
            {
                MessageBox.Show("提交成功");

            }
            else
            {
                MessageBox.Show("提交失败");
            }
        }
    }
}
