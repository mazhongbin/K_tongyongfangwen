﻿namespace 通用访问.工具
{
    partial class F主窗口
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F主窗口));
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("设备001");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("节点4");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("节点5");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("类型001", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("节点6");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("节点7");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("节点8");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("节点1", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("节点2");
            this.out设备菜单 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.do设备_断开 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.u窗口背景1 = new Utility.WindowsForm.U窗口背景();
            this.u窗体脚1 = new Utility.WindowsForm.U窗体脚();
            this.u窗体头1 = new Utility.WindowsForm.U窗体头();
            this.out标题 = new System.Windows.Forms.Label();
            this.do显示版本 = new System.Windows.Forms.PictureBox();
            this.out设备列表 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.out命令明细容器 = new Utility.WindowsForm.U容器();
            this.do编辑设备 = new Utility.WindowsForm.U按钮();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.out提示 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.do折叠 = new Utility.WindowsForm.U按钮();
            this.out设备菜单.SuspendLayout();
            this.u窗口背景1.SuspendLayout();
            this.u窗体头1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.do显示版本)).BeginInit();
            this.out提示.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // out设备菜单
            // 
            this.out设备菜单.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.do设备_断开});
            this.out设备菜单.Name = "out设备菜单";
            this.out设备菜单.Size = new System.Drawing.Size(99, 26);
            // 
            // do设备_断开
            // 
            this.do设备_断开.Name = "do设备_断开";
            this.do设备_断开.Size = new System.Drawing.Size(98, 22);
            this.do设备_断开.Text = "断开";
            // 
            // u窗口背景1
            // 
            this.u窗口背景1.Controls.Add(this.splitContainer1);
            this.u窗口背景1.Controls.Add(this.u窗体脚1);
            this.u窗口背景1.Controls.Add(this.u窗体头1);
            this.u窗口背景1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.u窗口背景1.Location = new System.Drawing.Point(0, 0);
            this.u窗口背景1.Margin = new System.Windows.Forms.Padding(0);
            this.u窗口背景1.Name = "u窗口背景1";
            this.u窗口背景1.Size = new System.Drawing.Size(1280, 740);
            this.u窗口背景1.TabIndex = 0;
            this.u窗口背景1.边框颜色 = System.Drawing.Color.Gainsboro;
            this.u窗口背景1.面板颜色 = System.Drawing.Color.Empty;
            // 
            // u窗体脚1
            // 
            this.u窗体脚1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.u窗体脚1.BackColor = System.Drawing.Color.White;
            this.u窗体脚1.Cursor = System.Windows.Forms.Cursors.PanSE;
            this.u窗体脚1.Location = new System.Drawing.Point(1269, 724);
            this.u窗体脚1.Name = "u窗体脚1";
            this.u窗体脚1.Size = new System.Drawing.Size(10, 15);
            this.u窗体脚1.TabIndex = 20;
            // 
            // u窗体头1
            // 
            this.u窗体头1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.u窗体头1.BackColor = System.Drawing.Color.White;
            this.u窗体头1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("u窗体头1.BackgroundImage")));
            this.u窗体头1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.u窗体头1.Controls.Add(this.out标题);
            this.u窗体头1.Controls.Add(this.do显示版本);
            this.u窗体头1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.u窗体头1.Location = new System.Drawing.Point(1, 1);
            this.u窗体头1.Name = "u窗体头1";
            this.u窗体头1.Size = new System.Drawing.Size(1278, 45);
            this.u窗体头1.TabIndex = 4;
            this.u窗体头1.显示Logo = false;
            this.u窗体头1.显示最大化按钮 = true;
            this.u窗体头1.显示最小化按钮 = true;
            this.u窗体头1.显示标题 = false;
            this.u窗体头1.显示设置按钮 = false;
            this.u窗体头1.标题 = "标题";
            // 
            // out标题
            // 
            this.out标题.AutoSize = true;
            this.out标题.BackColor = System.Drawing.Color.Transparent;
            this.out标题.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.out标题.ForeColor = System.Drawing.Color.DarkGray;
            this.out标题.Location = new System.Drawing.Point(49, 15);
            this.out标题.Name = "out标题";
            this.out标题.Size = new System.Drawing.Size(112, 19);
            this.out标题.TabIndex = 2;
            this.out标题.Text = "通用访问 (命令版)";
            // 
            // do显示版本
            // 
            this.do显示版本.Cursor = System.Windows.Forms.Cursors.Hand;
            this.do显示版本.Image = global::通用访问.工具.Properties.Resources.K;
            this.do显示版本.Location = new System.Drawing.Point(11, 11);
            this.do显示版本.Name = "do显示版本";
            this.do显示版本.Size = new System.Drawing.Size(26, 26);
            this.do显示版本.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.do显示版本.TabIndex = 1;
            this.do显示版本.TabStop = false;
            // 
            // out设备列表
            // 
            this.out设备列表.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.out设备列表.BackColor = System.Drawing.Color.Gainsboro;
            this.out设备列表.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.out设备列表.ContextMenuStrip = this.out设备菜单;
            this.out设备列表.Location = new System.Drawing.Point(3, 35);
            this.out设备列表.Name = "out设备列表";
            treeNode10.Name = "节点3";
            treeNode10.Text = "设备001";
            treeNode11.Name = "节点4";
            treeNode11.Text = "节点4";
            treeNode12.Name = "节点5";
            treeNode12.Text = "节点5";
            treeNode13.Name = "节点0";
            treeNode13.Text = "类型001";
            treeNode14.Name = "节点6";
            treeNode14.Text = "节点6";
            treeNode15.Name = "节点7";
            treeNode15.Text = "节点7";
            treeNode16.Name = "节点8";
            treeNode16.Text = "节点8";
            treeNode17.Name = "节点1";
            treeNode17.Text = "节点1";
            treeNode18.Name = "节点2";
            treeNode18.Text = "节点2";
            this.out设备列表.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode17,
            treeNode18});
            this.out设备列表.Size = new System.Drawing.Size(180, 641);
            this.out设备列表.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "设备列表";
            // 
            // out命令明细容器
            // 
            this.out命令明细容器.Dock = System.Windows.Forms.DockStyle.Fill;
            this.out命令明细容器.Location = new System.Drawing.Point(0, 0);
            this.out命令明细容器.Name = "out命令明细容器";
            this.out命令明细容器.Size = new System.Drawing.Size(1074, 679);
            this.out命令明细容器.TabIndex = 11;
            // 
            // do编辑设备
            // 
            this.do编辑设备.BackColor = System.Drawing.Color.White;
            this.do编辑设备.BackgroundImage = global::通用访问.工具.Properties.Resources.编辑;
            this.do编辑设备.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.do编辑设备.FlatAppearance.BorderSize = 0;
            this.do编辑设备.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.do编辑设备.ForeColor = System.Drawing.Color.White;
            this.do编辑设备.Location = new System.Drawing.Point(162, 9);
            this.do编辑设备.Name = "do编辑设备";
            this.do编辑设备.Size = new System.Drawing.Size(20, 20);
            this.do编辑设备.TabIndex = 13;
            this.toolTip1.SetToolTip(this.do编辑设备, "编辑设备列表");
            this.do编辑设备.UseVisualStyleBackColor = false;
            this.do编辑设备.大小 = new System.Drawing.Size(20, 20);
            this.do编辑设备.文字颜色 = System.Drawing.Color.White;
            this.do编辑设备.颜色 = System.Drawing.Color.White;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "第一步:  双击访问设备, 查看可访问对象";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(302, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "第二步:  双击命令, 查看执行结果或者输入参数后再执行";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "第三步:  右键点击设备或点击退出按钮断开设备";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(13, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "使用说明";
            // 
            // out提示
            // 
            this.out提示.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.out提示.Controls.Add(this.label7);
            this.out提示.Controls.Add(this.label6);
            this.out提示.Controls.Add(this.label5);
            this.out提示.Controls.Add(this.label4);
            this.out提示.Location = new System.Drawing.Point(6, 0);
            this.out提示.Name = "out提示";
            this.out提示.Size = new System.Drawing.Size(1065, 676);
            this.out提示.TabIndex = 21;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(8, 52);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.out设备列表);
            this.splitContainer1.Panel1.Controls.Add(this.do编辑设备);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.do折叠);
            this.splitContainer1.Panel2.Controls.Add(this.out提示);
            this.splitContainer1.Panel2.Controls.Add(this.out命令明细容器);
            this.splitContainer1.Size = new System.Drawing.Size(1263, 679);
            this.splitContainer1.SplitterDistance = 185;
            this.splitContainer1.TabIndex = 22;
            // 
            // do折叠
            // 
            this.do折叠.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(164)))), ((int)(((byte)(221)))));
            this.do折叠.FlatAppearance.BorderSize = 0;
            this.do折叠.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.do折叠.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.do折叠.Location = new System.Drawing.Point(0, 309);
            this.do折叠.Name = "do折叠";
            this.do折叠.Size = new System.Drawing.Size(5, 26);
            this.do折叠.TabIndex = 32;
            this.toolTip1.SetToolTip(this.do折叠, "显示/隐藏设备列表");
            this.do折叠.UseVisualStyleBackColor = false;
            this.do折叠.大小 = new System.Drawing.Size(5, 26);
            this.do折叠.文字颜色 = System.Drawing.Color.WhiteSmoke;
            this.do折叠.颜色 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(164)))), ((int)(((byte)(221)))));
            // 
            // F主窗口
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 740);
            this.Controls.Add(this.u窗口背景1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1050);
            this.Name = "F主窗口";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "通用访问 (命令版)";
            this.out设备菜单.ResumeLayout(false);
            this.u窗口背景1.ResumeLayout(false);
            this.u窗体头1.ResumeLayout(false);
            this.u窗体头1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.do显示版本)).EndInit();
            this.out提示.ResumeLayout(false);
            this.out提示.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Utility.WindowsForm.U窗口背景 u窗口背景1;
        private Utility.WindowsForm.U窗体头 u窗体头1;
        private System.Windows.Forms.PictureBox do显示版本;
        private System.Windows.Forms.Label out标题;
        private System.Windows.Forms.ContextMenuStrip out设备菜单;
        private System.Windows.Forms.ToolStripMenuItem do设备_断开;
        private System.Windows.Forms.ToolTip toolTip1;
        private Utility.WindowsForm.U窗体脚 u窗体脚1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView out设备列表;
        private Utility.WindowsForm.U按钮 do编辑设备;
        private System.Windows.Forms.Panel out提示;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Utility.WindowsForm.U容器 out命令明细容器;
        private Utility.WindowsForm.U按钮 do折叠;
    }
}

