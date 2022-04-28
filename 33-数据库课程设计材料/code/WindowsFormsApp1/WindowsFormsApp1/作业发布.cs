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
    public partial class teacher2 : Form
    {
        public teacher2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dao dao = new Dao();
            string sql = $"updata 作业 set 作业要求='{textBox2.Text}' where 课程号='{textBox1.Text}'";
            int n=dao.Execute(sql);
            if (n>0)
            {
                MessageBox.Show("发布成功");

            }
            else
            {
                MessageBox.Show("发布失败");
            }
        }
    }
}
