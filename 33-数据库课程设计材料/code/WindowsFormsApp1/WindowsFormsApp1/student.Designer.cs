namespace WindowsFormsApp1
{
    partial class student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.作业查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.作业提交ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分数查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(210, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生账号已登录";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.作业查询ToolStripMenuItem,
            this.作业提交ToolStripMenuItem,
            this.分数查询ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 作业查询ToolStripMenuItem
            // 
            this.作业查询ToolStripMenuItem.Name = "作业查询ToolStripMenuItem";
            this.作业查询ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.作业查询ToolStripMenuItem.Text = "作业查询";
            this.作业查询ToolStripMenuItem.Click += new System.EventHandler(this.作业查询ToolStripMenuItem_Click);
            // 
            // 作业提交ToolStripMenuItem
            // 
            this.作业提交ToolStripMenuItem.Name = "作业提交ToolStripMenuItem";
            this.作业提交ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.作业提交ToolStripMenuItem.Text = "作业提交";
            this.作业提交ToolStripMenuItem.Click += new System.EventHandler(this.作业提交ToolStripMenuItem_Click);
            // 
            // 分数查询ToolStripMenuItem
            // 
            this.分数查询ToolStripMenuItem.Name = "分数查询ToolStripMenuItem";
            this.分数查询ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.分数查询ToolStripMenuItem.Text = "分数查询";
            this.分数查询ToolStripMenuItem.Click += new System.EventHandler(this.分数查询ToolStripMenuItem_Click);
            // 
            // student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "student";
            this.Text = "学生管理界面";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 作业查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 作业提交ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 分数查询ToolStripMenuItem;
    }
}