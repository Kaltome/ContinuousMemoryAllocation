namespace ContinuousMemoryAllocation
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.chooseReleaseNoListBox = new System.Windows.Forms.ListBox();
            this.Title = new System.Windows.Forms.Label();
            this.MemPool = new System.Windows.Forms.TextBox();
            this.usedMemListTextBox = new System.Windows.Forms.TextBox();
            this.MenUsingListLabel = new System.Windows.Forms.Label();
            this.freeMemListTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.processListTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.getRandomNumTextBox = new System.Windows.Forms.TextBox();
            this.createRandomListButton = new System.Windows.Forms.Button();
            this.memPoolGroupBox = new System.Windows.Forms.GroupBox();
            this.memLabel5 = new System.Windows.Forms.Label();
            this.memLabel4 = new System.Windows.Forms.Label();
            this.memLabel3 = new System.Windows.Forms.Label();
            this.memLabel2 = new System.Windows.Forms.Label();
            this.memLabel1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.releaseProcessButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.getPSizeTextBox = new System.Windows.Forms.TextBox();
            this.addProcessButton = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.autoRunButton = new System.Windows.Forms.Button();
            this.clearProcessListButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.clearMessageBoxButton = new System.Windows.Forms.Button();
            this.FFAlgorithmcheckBox = new System.Windows.Forms.CheckBox();
            this.BFAlgorithmCheckBox = new System.Windows.Forms.CheckBox();
            this.runOneStepButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.memPoolGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // chooseReleaseNoListBox
            // 
            this.chooseReleaseNoListBox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chooseReleaseNoListBox.FormattingEnabled = true;
            this.chooseReleaseNoListBox.ItemHeight = 12;
            this.chooseReleaseNoListBox.Location = new System.Drawing.Point(8, 25);
            this.chooseReleaseNoListBox.Name = "chooseReleaseNoListBox";
            this.chooseReleaseNoListBox.ScrollAlwaysVisible = true;
            this.chooseReleaseNoListBox.Size = new System.Drawing.Size(138, 64);
            this.chooseReleaseNoListBox.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title.Location = new System.Drawing.Point(28, 20);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(249, 45);
            this.Title.TabIndex = 2;
            this.Title.Text = "连续内存分配示例";
            this.Title.UseCompatibleTextRendering = true;
            // 
            // MemPool
            // 
            this.MemPool.Location = new System.Drawing.Point(10, 25);
            this.MemPool.Multiline = true;
            this.MemPool.Name = "MemPool";
            this.MemPool.ReadOnly = true;
            this.MemPool.Size = new System.Drawing.Size(1000, 100);
            this.MemPool.TabIndex = 3;
            // 
            // usedMemListTextBox
            // 
            this.usedMemListTextBox.BackColor = System.Drawing.Color.White;
            this.usedMemListTextBox.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.usedMemListTextBox.Location = new System.Drawing.Point(10, 30);
            this.usedMemListTextBox.Multiline = true;
            this.usedMemListTextBox.Name = "usedMemListTextBox";
            this.usedMemListTextBox.ReadOnly = true;
            this.usedMemListTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.usedMemListTextBox.Size = new System.Drawing.Size(270, 245);
            this.usedMemListTextBox.TabIndex = 6;
            this.usedMemListTextBox.Text = "无占用区";
            // 
            // MenUsingListLabel
            // 
            this.MenUsingListLabel.AutoSize = true;
            this.MenUsingListLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MenUsingListLabel.Location = new System.Drawing.Point(399, 456);
            this.MenUsingListLabel.Name = "MenUsingListLabel";
            this.MenUsingListLabel.Size = new System.Drawing.Size(0, 21);
            this.MenUsingListLabel.TabIndex = 4;
            // 
            // freeMemListTextBox
            // 
            this.freeMemListTextBox.BackColor = System.Drawing.Color.White;
            this.freeMemListTextBox.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.freeMemListTextBox.Location = new System.Drawing.Point(10, 30);
            this.freeMemListTextBox.Multiline = true;
            this.freeMemListTextBox.Name = "freeMemListTextBox";
            this.freeMemListTextBox.ReadOnly = true;
            this.freeMemListTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.freeMemListTextBox.ShortcutsEnabled = false;
            this.freeMemListTextBox.Size = new System.Drawing.Size(270, 245);
            this.freeMemListTextBox.TabIndex = 6;
            this.freeMemListTextBox.TabStop = false;
            this.freeMemListTextBox.Text = "空闲区1 起址：0 长度：1000K";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(370, 549);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(218, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(715, 630);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 4;
            // 
            // processListTextBox
            // 
            this.processListTextBox.BackColor = System.Drawing.Color.White;
            this.processListTextBox.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.processListTextBox.Location = new System.Drawing.Point(230, 30);
            this.processListTextBox.MaxLength = 6;
            this.processListTextBox.Multiline = true;
            this.processListTextBox.Name = "processListTextBox";
            this.processListTextBox.ReadOnly = true;
            this.processListTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.processListTextBox.Size = new System.Drawing.Size(160, 245);
            this.processListTextBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.getRandomNumTextBox);
            this.groupBox1.Controls.Add(this.createRandomListButton);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(10, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 55);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "生成随机队列";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "输入队列大小";
            // 
            // getRandomNumTextBox
            // 
            this.getRandomNumTextBox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.getRandomNumTextBox.Location = new System.Drawing.Point(91, 22);
            this.getRandomNumTextBox.MaxLength = 2;
            this.getRandomNumTextBox.Name = "getRandomNumTextBox";
            this.getRandomNumTextBox.Size = new System.Drawing.Size(55, 21);
            this.getRandomNumTextBox.TabIndex = 1;
            this.getRandomNumTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.getRandomNumTextBox_KeyPress);
            // 
            // createRandomListButton
            // 
            this.createRandomListButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.createRandomListButton.Location = new System.Drawing.Point(152, 21);
            this.createRandomListButton.Name = "createRandomListButton";
            this.createRandomListButton.Size = new System.Drawing.Size(50, 23);
            this.createRandomListButton.TabIndex = 8;
            this.createRandomListButton.Text = "生成";
            this.createRandomListButton.UseVisualStyleBackColor = true;
            this.createRandomListButton.Click += new System.EventHandler(this.CreateRandomListButton_Click);
            // 
            // memPoolGroupBox
            // 
            this.memPoolGroupBox.Controls.Add(this.memLabel5);
            this.memPoolGroupBox.Controls.Add(this.memLabel4);
            this.memPoolGroupBox.Controls.Add(this.memLabel3);
            this.memPoolGroupBox.Controls.Add(this.memLabel2);
            this.memPoolGroupBox.Controls.Add(this.memLabel1);
            this.memPoolGroupBox.Controls.Add(this.MemPool);
            this.memPoolGroupBox.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.memPoolGroupBox.Location = new System.Drawing.Point(25, 420);
            this.memPoolGroupBox.Name = "memPoolGroupBox";
            this.memPoolGroupBox.Size = new System.Drawing.Size(1020, 155);
            this.memPoolGroupBox.TabIndex = 11;
            this.memPoolGroupBox.TabStop = false;
            this.memPoolGroupBox.Text = "内存池";
            // 
            // memLabel5
            // 
            this.memLabel5.AutoSize = true;
            this.memLabel5.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.memLabel5.Location = new System.Drawing.Point(978, 130);
            this.memLabel5.Name = "memLabel5";
            this.memLabel5.Size = new System.Drawing.Size(39, 16);
            this.memLabel5.TabIndex = 4;
            this.memLabel5.Text = "1000K";
            // 
            // memLabel4
            // 
            this.memLabel4.AutoSize = true;
            this.memLabel4.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.memLabel4.Location = new System.Drawing.Point(735, 130);
            this.memLabel4.Name = "memLabel4";
            this.memLabel4.Size = new System.Drawing.Size(21, 16);
            this.memLabel4.TabIndex = 4;
            this.memLabel4.Text = "0K";
            // 
            // memLabel3
            // 
            this.memLabel3.AutoSize = true;
            this.memLabel3.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.memLabel3.Location = new System.Drawing.Point(493, 130);
            this.memLabel3.Name = "memLabel3";
            this.memLabel3.Size = new System.Drawing.Size(21, 16);
            this.memLabel3.TabIndex = 4;
            this.memLabel3.Text = "0K";
            // 
            // memLabel2
            // 
            this.memLabel2.AutoSize = true;
            this.memLabel2.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.memLabel2.Location = new System.Drawing.Point(250, 130);
            this.memLabel2.Name = "memLabel2";
            this.memLabel2.Size = new System.Drawing.Size(21, 16);
            this.memLabel2.TabIndex = 4;
            this.memLabel2.Text = "0K";
            // 
            // memLabel1
            // 
            this.memLabel1.AutoSize = true;
            this.memLabel1.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.memLabel1.Location = new System.Drawing.Point(8, 130);
            this.memLabel1.Name = "memLabel1";
            this.memLabel1.Size = new System.Drawing.Size(21, 16);
            this.memLabel1.TabIndex = 4;
            this.memLabel1.Text = "0K";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.processListTextBox);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(25, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 285);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "编辑进程调度队列";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(8, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 10;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.chooseReleaseNoListBox);
            this.groupBox5.Controls.Add(this.releaseProcessButton);
            this.groupBox5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.Location = new System.Drawing.Point(10, 175);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(210, 100);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "选择释放的进程号";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(6, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 12);
            this.label9.TabIndex = 10;
            // 
            // releaseProcessButton
            // 
            this.releaseProcessButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.releaseProcessButton.Location = new System.Drawing.Point(152, 25);
            this.releaseProcessButton.Name = "releaseProcessButton";
            this.releaseProcessButton.Size = new System.Drawing.Size(50, 23);
            this.releaseProcessButton.TabIndex = 8;
            this.releaseProcessButton.Text = "释放";
            this.releaseProcessButton.UseVisualStyleBackColor = true;
            this.releaseProcessButton.Click += new System.EventHandler(this.ReleaseProcessButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 11);
            this.label5.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.getPSizeTextBox);
            this.groupBox3.Controls.Add(this.addProcessButton);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(10, 110);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 55);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "添加调入进程";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(6, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "输入进程大小";
            // 
            // getPSizeTextBox
            // 
            this.getPSizeTextBox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.getPSizeTextBox.Location = new System.Drawing.Point(91, 22);
            this.getPSizeTextBox.MaxLength = 3;
            this.getPSizeTextBox.Name = "getPSizeTextBox";
            this.getPSizeTextBox.Size = new System.Drawing.Size(55, 21);
            this.getPSizeTextBox.TabIndex = 7;
            this.getPSizeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.getPSizeTextBox_KeyPress);
            // 
            // addProcessButton
            // 
            this.addProcessButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addProcessButton.Location = new System.Drawing.Point(152, 21);
            this.addProcessButton.Name = "addProcessButton";
            this.addProcessButton.Size = new System.Drawing.Size(50, 23);
            this.addProcessButton.TabIndex = 8;
            this.addProcessButton.Text = "添加";
            this.addProcessButton.UseVisualStyleBackColor = true;
            this.addProcessButton.Click += new System.EventHandler(this.AddProcessButton_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.freeMemListTextBox);
            this.groupBox6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox6.Location = new System.Drawing.Point(455, 75);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(290, 285);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "内存空闲表";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(8, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 12);
            this.label7.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(6, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 11);
            this.label11.TabIndex = 9;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.usedMemListTextBox);
            this.groupBox7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox7.Location = new System.Drawing.Point(755, 75);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(290, 285);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "内存占用表";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(8, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 12);
            this.label10.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(6, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 11);
            this.label12.TabIndex = 9;
            // 
            // autoRunButton
            // 
            this.autoRunButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.autoRunButton.Location = new System.Drawing.Point(110, 380);
            this.autoRunButton.Name = "autoRunButton";
            this.autoRunButton.Size = new System.Drawing.Size(80, 30);
            this.autoRunButton.TabIndex = 12;
            this.autoRunButton.Text = "执行全部";
            this.autoRunButton.UseVisualStyleBackColor = true;
            this.autoRunButton.Click += new System.EventHandler(this.AutoRunButton_Click);
            // 
            // clearProcessListButton
            // 
            this.clearProcessListButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clearProcessListButton.Location = new System.Drawing.Point(840, 380);
            this.clearProcessListButton.Name = "clearProcessListButton";
            this.clearProcessListButton.Size = new System.Drawing.Size(100, 30);
            this.clearProcessListButton.TabIndex = 12;
            this.clearProcessListButton.Text = "清空进程队列";
            this.clearProcessListButton.UseVisualStyleBackColor = true;
            this.clearProcessListButton.Click += new System.EventHandler(this.ClearProcessListButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resetButton.Location = new System.Drawing.Point(735, 380);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(100, 30);
            this.resetButton.TabIndex = 12;
            this.resetButton.Text = "重置系统";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Controls.Add(this.messageTextBox);
            this.groupBox8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox8.Location = new System.Drawing.Point(25, 585);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(1020, 155);
            this.groupBox8.TabIndex = 10;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "运行信息";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(8, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 12);
            this.label13.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(6, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 11);
            this.label14.TabIndex = 9;
            // 
            // messageTextBox
            // 
            this.messageTextBox.BackColor = System.Drawing.Color.White;
            this.messageTextBox.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.messageTextBox.Location = new System.Drawing.Point(10, 25);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ReadOnly = true;
            this.messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.messageTextBox.ShortcutsEnabled = false;
            this.messageTextBox.Size = new System.Drawing.Size(1000, 120);
            this.messageTextBox.TabIndex = 6;
            this.messageTextBox.TabStop = false;
            // 
            // clearMessageBoxButton
            // 
            this.clearMessageBoxButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clearMessageBoxButton.Location = new System.Drawing.Point(945, 380);
            this.clearMessageBoxButton.Name = "clearMessageBoxButton";
            this.clearMessageBoxButton.Size = new System.Drawing.Size(100, 30);
            this.clearMessageBoxButton.TabIndex = 12;
            this.clearMessageBoxButton.Text = "清空运行信息";
            this.clearMessageBoxButton.UseVisualStyleBackColor = true;
            this.clearMessageBoxButton.Click += new System.EventHandler(this.clearMessageBoxButton_Click);
            // 
            // FFAlgorithmcheckBox
            // 
            this.FFAlgorithmcheckBox.AutoSize = true;
            this.FFAlgorithmcheckBox.Checked = true;
            this.FFAlgorithmcheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FFAlgorithmcheckBox.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FFAlgorithmcheckBox.Location = new System.Drawing.Point(200, 386);
            this.FFAlgorithmcheckBox.Name = "FFAlgorithmcheckBox";
            this.FFAlgorithmcheckBox.Size = new System.Drawing.Size(93, 20);
            this.FFAlgorithmcheckBox.TabIndex = 13;
            this.FFAlgorithmcheckBox.Text = "首次适应算法";
            this.FFAlgorithmcheckBox.UseVisualStyleBackColor = true;
            this.FFAlgorithmcheckBox.CheckedChanged += new System.EventHandler(this.FFAlgorithmcheckBox_CheckedChanged);
            // 
            // OAAlgorithmCheckBox
            // 
            this.BFAlgorithmCheckBox.AutoSize = true;
            this.BFAlgorithmCheckBox.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BFAlgorithmCheckBox.Location = new System.Drawing.Point(300, 386);
            this.BFAlgorithmCheckBox.Name = "OAAlgorithmCheckBox";
            this.BFAlgorithmCheckBox.Size = new System.Drawing.Size(93, 20);
            this.BFAlgorithmCheckBox.TabIndex = 13;
            this.BFAlgorithmCheckBox.Text = "最佳适应算法";
            this.BFAlgorithmCheckBox.UseVisualStyleBackColor = true;
            this.BFAlgorithmCheckBox.CheckedChanged += new System.EventHandler(this.BFAlgorithmCheckBox_CheckedChanged);
            // 
            // runOneStepButton
            // 
            this.runOneStepButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.runOneStepButton.Location = new System.Drawing.Point(25, 380);
            this.runOneStepButton.Name = "runOneStepButton";
            this.runOneStepButton.Size = new System.Drawing.Size(80, 30);
            this.runOneStepButton.TabIndex = 12;
            this.runOneStepButton.Text = "执行单步";
            this.runOneStepButton.UseVisualStyleBackColor = true;
            this.runOneStepButton.Click += new System.EventHandler(this.RunOneStepButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1064, 761);
            this.Controls.Add(this.BFAlgorithmCheckBox);
            this.Controls.Add(this.FFAlgorithmcheckBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.clearMessageBoxButton);
            this.Controls.Add(this.clearProcessListButton);
            this.Controls.Add(this.runOneStepButton);
            this.Controls.Add(this.autoRunButton);
            this.Controls.Add(this.memPoolGroupBox);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenUsingListLabel);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "连续内存分配示例";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.memPoolGroupBox.ResumeLayout(false);
            this.memPoolGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox chooseReleaseNoListBox;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox MemPool;
        private System.Windows.Forms.TextBox usedMemListTextBox;
        private System.Windows.Forms.Label MenUsingListLabel;
        private System.Windows.Forms.TextBox freeMemListTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox processListTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox memPoolGroupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox getRandomNumTextBox;
        private System.Windows.Forms.Button createRandomListButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button releaseProcessButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox getPSizeTextBox;
        private System.Windows.Forms.Button addProcessButton;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button autoRunButton;
        private System.Windows.Forms.Button clearProcessListButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Button clearMessageBoxButton;
        private System.Windows.Forms.CheckBox FFAlgorithmcheckBox;
        private System.Windows.Forms.CheckBox BFAlgorithmCheckBox;
        private System.Windows.Forms.Button runOneStepButton;
        private System.Windows.Forms.Label memLabel1;
        private System.Windows.Forms.Label memLabel5;
        private System.Windows.Forms.Label memLabel4;
        private System.Windows.Forms.Label memLabel3;
        private System.Windows.Forms.Label memLabel2;
    }
}

