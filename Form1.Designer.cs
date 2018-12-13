namespace WindowsFormsApp8
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("utilities");
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("calculator");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("utilities", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("name");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("students", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.treeView2);
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            this.panel1.DoubleClick += new System.EventHandler(this.panel1_DoubleClick);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode5.Name = "Node0";
            treeNode5.Text = "utilities";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeView1.Size = new System.Drawing.Size(800, 450);
            this.treeView1.TabIndex = 0;
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(0, 3);
            this.treeView2.Name = "treeView2";
            treeNode1.Name = "Node1";
            treeNode1.Text = "calculator";
            treeNode2.Name = "calculator";
            treeNode2.Text = "utilities";
            treeNode3.Name = "Node9";
            treeNode3.Text = "name";
            treeNode4.Name = "students";
            treeNode4.Text = "students";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4});
            this.treeView2.Size = new System.Drawing.Size(301, 447);
            this.treeView2.TabIndex = 1;
            this.treeView2.DoubleClick += new System.EventHandler(this.calculator);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(298, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 444);
            this.panel2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel2;
    }
}

