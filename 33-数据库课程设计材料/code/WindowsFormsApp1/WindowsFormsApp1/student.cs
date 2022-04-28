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
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }

        private void 作业查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            student1 s1 = new student1();
            s1.ShowDialog();
        }

        private void 分数查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            student3 s3 = new student3();
            s3.ShowDialog();
        }

        private void 作业提交ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            student2 s2 = new student2();
            s2.ShowDialog();
        }
    }
}
