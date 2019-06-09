using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContinuousMemoryAllocation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            freeMem = memSize;
            freeMemList = new FreeMemList(new MemBlock(0, memSize));
            usedMemList = new UsedMemList();
            PrintFreeMemList();
            memLabel2.Text = (1 * memSize / 4) + "K";
            memLabel3.Text = (2 * memSize / 4) + "K";
            memLabel4.Text = (3 * memSize / 4) + "K";
            memLabel5.Text = (4 * memSize / 4) + "K";
        }

        public MainForm(int size)
        {
            InitializeComponent();
            memSize = size;
            freeMem = size;
            freeMemList = new FreeMemList(new MemBlock(0, memSize));
            usedMemList = new UsedMemList();
            PrintFreeMemList();
            memLabel2.Text = (1 * memSize / 4) + "K";
            memLabel3.Text = (2 * memSize / 4) + "K";
            memLabel4.Text = (3 * memSize / 4) + "K";
            memLabel5.Text = (4 * memSize / 4) + "K";
        }


        //单步执行函数
        private void RunOneStep()
        {
            //检查进程列表是否为空
            if (processList.Count == 0)
            {
                MessageBox.Show("进程列表为空", "提示");
                return;
            }
            //确定执行的进程及其操作
            ProcessAction processAction = processList.First();
            if (processAction.op)
            {
                //记录下一个未调度的进程序号
                nextProcessNo++;
                AddProcess(processAction.process);
            }
            else ReleaseProcess(processAction.process);
            //移除进程列表已执行的项（首项）
            processList.RemoveAt(0);
            //检查是否执行完毕
            if(processList.Count == 0)
            {
                MessageBox.Show("执行完成\r\n\r\n进程调入失败次数：" + falseNum, "提示");
                ClearProcessList();
            }
        }


        //自动执行函数
        private async void AutoRun()
        {
            //检查调度列表是否为空
            if (processList.Count == 0)
            {
                MessageBox.Show("进程列表为空", "提示");
                return;
            }
            //屏蔽按钮交互响应
            SetButton(false);
            //顺序执行
            foreach (var processAction in processList)
            {
                await Task.Delay(1000);
                //判断是调入进程还是释放进程
                if (processAction.op)
                {
                    //记录下一个未调度的进程序号
                    nextProcessNo++;
                    AddProcess(processAction.process);
                }
                else ReleaseProcess(processAction.process);
            }
            MessageBox.Show("执行完成\r\n\r\n进程调入失败次数：" + falseNum, "提示");
            //清空调度队列
            ClearProcessList();
            //恢复按钮交互响应
            SetButton(true);
        }

        //调入进程
        private void AddProcess(Process process)
        {
            //获取调入位置，如果成功则执行调入操作，不能便统计失败信息
            if (GetPositon(out int position, process.size))
            {
                //新建TextBoxUI控件
                process.memBlock = new TextBox();
                process.memBlock.Multiline = true;
                process.memBlock.ReadOnly = true;
                process.memBlock.BackColor = Color.LightSkyBlue;
                process.memBlock.Text = "\r\n进\r\n程\r\n" + process.processNo;
                process.memBlock.Font = new Font("微软雅黑", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
                process.memBlock.Size = new Size((process.size * memUISize / memSize), 100);
                process.memBlock.Location = new Point(10 + position * memUISize / memSize, 25);
                memPoolGroupBox.Controls.Add(process.memBlock);
                process.memBlock.BringToFront();
                process.memBlock.Refresh();

                //记录获取的进程位置，更新内存剩余空间容量，更新占用表
                process.processStarting = position;
                freeMem -= process.size;
                UpdateUsedMemList_AddProcess(position, process.size);
                messageTextBox.AppendText("进程" + process.processNo + " 调入成功，插入位置：" + position + "K\r\n");
            }
            else
            {
                falseNum++;
                messageTextBox.AppendText("无插入内存空间，进程" + process.processNo + "调入失败\r\n");
            }
        }

        //获取调入位置，若无调入空间，返回false
        private bool GetPositon(out int p, int size)
        {
            p = -1;
            MemBlock freeMemBlock = null;
            //首次适应算法
            if (algorithm)
            {
                freeMemBlock = freeMemList.first;
                while (freeMemBlock != null)
                {
                    if (freeMemBlock.blockSize >= size)
                    {
                        p = freeMemBlock.starting;
                        UpdateFreeMemList_AddProcess(freeMemBlock, size);
                        break;
                    }
                    freeMemBlock = freeMemBlock.next;
                }
            }
            //最佳适应算法
            else
            {
                int maxSize = 0;
                MemBlock block = freeMemList.first;
                //寻找最大且足够大的块
                while(block != null)
                {
                    if (block.blockSize >= size && block.blockSize > maxSize)
                    {
                        freeMemBlock = block;
                        maxSize = block.blockSize;
                    }
                    block = block.next;
                }
                if (freeMemBlock != null)
                {
                    p = freeMemBlock.starting;
                    UpdateFreeMemList_AddProcess(freeMemBlock, size);
                }
            }
            return (p >= 0);
        }

        //调入进程后更新空闲区表信息
        private void UpdateFreeMemList_AddProcess(MemBlock freeMemBlock, int size)
        {
            //若无需删除整个空闲块结点，更改起点与大小
            if (freeMemBlock.blockSize != size)
            {
                freeMemBlock.starting += size;
                freeMemBlock.blockSize -= size;
            }
            //若要删除空闲区表头结点，将下一个结点当做头结点
            else if (freeMemBlock == freeMemList.first)
            {
                freeMemList.first = freeMemBlock.next;
                if (freeMemList.first != null) freeMemList.first.last = null;
            }
            //删除某个空闲块结点
            else
            {
                MemBlock lastBlock = freeMemBlock.last;
                lastBlock.next = freeMemBlock.next;
                if (lastBlock.next != null) lastBlock.next.last = lastBlock;
            }
            //更新空闲区表信息
            PrintFreeMemList();
        }

        //调入进程后更新占用区表信息
        private void UpdateUsedMemList_AddProcess(int start, int size)
        {
            //若占用表为空，创建头结点
            if (usedMemList.first == null) usedMemList.first = new MemBlock(start, size);
            else
            {
                MemBlock block = usedMemList.first;
                //若新表项在表头前，更新头结点
                if (start < usedMemList.first.starting)
                {
                    MemBlock newBlock = new MemBlock(start, size);
                    newBlock.next = block;
                    block.last = newBlock;
                    usedMemList.first = newBlock;
                    block = newBlock;
                }
                //新表项紧挨某项后方（增大某项体积）
                else
                {
                    while (block != null && block.starting + block.blockSize != start) block = block.next;
                    block.blockSize += size;
                }

                //检测是否要与下一个结点项合并
                if (block.next != null && block.starting + block.blockSize == block.next.starting)
                {
                    block.blockSize += block.next.blockSize;
                    block.next = block.next.next;
                    if (block.next != null) block.next.last = block;
                }
            }
            //更新占用表信息
            PrintUsedMemList();
        }

        //释放进程
        private void ReleaseProcess(Process process)
        {
            //若该进程已被调入内存，则进行释放操作，否则输出失败信息
            if (process.processStarting != -1)
            {
                //删除UI控件，更新占用表，空闲表信息，更新内存剩余空间大小
                process.memBlock.Dispose();
                UpdateFreeMemList_Release(process.processStarting, process.size);
                UpdateUsedMemList_Release(process.processStarting, process.size);
                freeMem += process.size;
                process.processStarting = -1;

                messageTextBox.AppendText("进程" + process.processNo + " 已释放\r\n");
            }
            else messageTextBox.AppendText("进程" + process.processNo + " 并未在内存中，释放失败\r\n");
        }

        //释放进程后更新空闲表
        private void UpdateFreeMemList_Release(int start, int size)
        {
            //若空闲表为空，创建头结点
            if (freeMemList.first == null) freeMemList.first = new MemBlock(start, size);
            else
            {
                //储存已修改的结点及其上一项，下一项的结点信息，便于执行合并操作
                MemBlock block = new MemBlock(start, size);
                MemBlock lastBlock = freeMemList.first;
                MemBlock nextBlock = null;
                //若新表项添加在头结点前，更改头结点
                if (start < lastBlock.starting)
                {
                    block.next = lastBlock;
                    lastBlock.last = block;
                    freeMemList.first = block;
                    lastBlock = block;
                    block = lastBlock.next;
                    nextBlock = block.next;
                }
                else
                {
                    //寻找插入的位置（插在哪一结点后方）
                    while (lastBlock.next != null && lastBlock.next.starting < start) lastBlock = lastBlock.next;
                    //若该结点不是尾节点，连接下一项
                    if(lastBlock.next != null)
                    {
                        nextBlock = lastBlock.next;
                        block.next = nextBlock;
                        nextBlock.last = block;
                    }
                    //连接上一项
                    lastBlock.next = block;
                    block.last = lastBlock;
                }
                //合并操作
                //检查是否要与上一项合并
                if(lastBlock != null)
                {
                    if(lastBlock.starting + lastBlock.blockSize == block.starting)
                    {
                        lastBlock.blockSize += block.blockSize;
                        lastBlock.next = nextBlock;
                        if (nextBlock != null) nextBlock.last = lastBlock;
                        block = lastBlock;
                    }
                }
                //检查是否要与下一项合并
                if(nextBlock != null)
                {
                    if(block.starting + block.blockSize == nextBlock.starting)
                    {
                        block.blockSize += nextBlock.blockSize;
                        block.next = nextBlock.next;
                        if (block.next != null) block.next.last = block;
                    }
                }
            }
            //更新空闲表信息
            PrintFreeMemList();
        }

        //释放进程后更新占用表
        private void UpdateUsedMemList_Release(int start, int size)
        {
            //若删去整个头结点，修改新的头结点
            if (usedMemList.first.starting == start && usedMemList.first.blockSize == size) usedMemList.first = usedMemList.first.next;
            else
            {
                MemBlock block = usedMemList.first;
                while (!(block.starting <= start && block.starting + block.blockSize > start)) block = block.next;
                //若要删去某个节点
                if(start == block.starting && size == block.blockSize)
                {
                    block.last.next = block.next;
                    if(block.next != null) block.next.last = block.last;
                }
                //若要删去某个节点前半部分，更新起址，大小
                else if (start == block.starting)
                {
                    block.starting += size;
                    block.blockSize -= size;
                }
                //若要删去某个节点后半部分，更新大小
                else if (start + size == block.starting + block.blockSize)
                {
                    block.blockSize -= size;
                }
                //删去某个节点的中间部分，创建新的结点并连接
                else
                {
                    MemBlock newBlock = new MemBlock(start + size, block.starting + block.blockSize - start - size);
                    block.blockSize = start - block.starting;
                    newBlock.next = block.next;
                    if (newBlock.next != null) newBlock.next.last = newBlock;
                    block.next = newBlock;
                    newBlock.last = block;
                }
            }
            PrintUsedMemList();
        }

        //打印空闲表信息
        private void PrintFreeMemList()
        {
            freeMemListTextBox.Text = string.Empty;
            if (freeMemList.first == null) freeMemListTextBox.AppendText("无空闲区");
            else
            {
                int i = 1;
                for (MemBlock block = freeMemList.first; block != null; block = block.next, i++)
                {
                    freeMemListTextBox.AppendText(
                        "空闲区" + i + " " +
                        "起址：" + block.starting + "K " +
                        "长度：" + block.blockSize + "K\r\n");
                }
            }
        }

        //打印占用表信息
        private void PrintUsedMemList()
        {
            usedMemListTextBox.Text = string.Empty;
            if (usedMemList.first == null) usedMemListTextBox.AppendText("无占用区");
            else
            {
                int i = 1;
                for (var block = usedMemList.first; block != null; block = block.next, i++)
                {
                    usedMemListTextBox.AppendText(
                        "占用区" + i + " " +
                        "起址：" + block.starting + "K " +
                        "长度：" + block.blockSize + "K\r\n");
                }
            }
        }

        //清除调度进程列表
        private void ClearProcessList()
        {
            //清除已创建但未调度的进程
            processes.RemoveRange(nextProcessNo - 1, nextProcessNoInCreate - nextProcessNo);
            //清除调度进程列表
            processList.Clear();
            //清除调度进程列表信息
            processListTextBox.Clear();
            //更新选择释放进程列表栏信息
            //先清空
            //添加仍处在内存中的进程
            chooseReleaseNoListBox.Items.Clear();
            for(int i = 0; i < nextProcessNo - 1; i++)
            {
                if (processes[i].processStarting != -1) chooseReleaseNoListBox.Items.Add(processes[i].processNo);
            }
            //更新编辑列表时创建下一个调入进程的编号
            nextProcessNoInCreate = nextProcessNo;
            //重置记录失败次数为0
            falseNum = 0;
        }

        //重置系统
        private void Reset()
        {
            //重置下一个要调入的进程编号
            nextProcessNo = 1;
            nextProcessNoInCreate = 1;
            //重置空闲区表占用区表
            freeMemList.first = new MemBlock(0, memSize);
            usedMemList.first = null;
            PrintFreeMemList();
            PrintUsedMemList();
            //清除内存
            freeMem = memSize;
            foreach (var process in processes)
            {
                if (process.memBlock != null) process.memBlock.Dispose();
            }
            //清除已创建的所有进程
            processes.Clear();
            //清除调度进程列表
            ClearProcessList();
            //清除运行信息
            messageTextBox.Clear();
        }




        //UI控件与交互---------------------------------------------------------------------------------------------------------------------
        private void getRandomNumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) CreateRandomListButton_Click(sender, e);
        }

        private void getPSizeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) AddProcessButton_Click(sender, e);
        }

        //随机创建进程列表
        private void CreateRandomListButton_Click(object sender, EventArgs e)
        {
            //检查数据规范性
            if (string.IsNullOrEmpty(getRandomNumTextBox.Text)) MessageBox.Show("数据未填写", "提示");
            else if (int.TryParse(getRandomNumTextBox.Text, out int randomNum) && randomNum >= 3 && randomNum <= 30)
            {
                //初始化（清除）调度进程列表
                ClearProcessList();
                //获取剩余空间大小
                int freeMemInRd = freeMem;
                //储存可释放的进程的编号
                List<int> rdCreatedProcess = new List<int>();
                //随机数引擎
                Random rd = new Random();
                bool isRdAction = false;
                //将目前在内存中的进程的编号添加进可释放的进程的编号的列表
                foreach (var process in processes)
                {
                    if (process.processStarting != -1) rdCreatedProcess.Add(process.processNo);
                }

                for (int i = 0; i < randomNum; i++)
                {
                    bool rdAction;
                    //随机状态下创建新调入进程的概率为（剩余内存空间 / 总内存空间 * 1.2）
                    //生成随机队列时先让内存充满至大于70%，再进行随机操作
                    if (isRdAction) rdAction = rd.Next(0, memSize) < freeMemInRd * 1.2;
                    else rdAction = true;
                    if (rdAction)
                    {
                        //创建新进程，加入创建进程列表
                        int rdProcessSize = rd.Next(25 * memSize / 10000 + 1, 30) * 10;

                        Process process = new Process(nextProcessNoInCreate, rdProcessSize);
                        ProcessAction processAction = new ProcessAction(process, rdAction);
                        processes.Add(process);
                        //添加进调度进程列表，添加进可释放进程列表，更新选择调出进程列表栏信息
                        processList.Add(processAction);
                        rdCreatedProcess.Add(nextProcessNoInCreate);
                        chooseReleaseNoListBox.Items.Add(nextProcessNoInCreate);
                        //更新下一个被创建的进程的编号，更新（随机创建状态下）剩余内存容量
                        nextProcessNoInCreate++;
                        freeMemInRd -= rdProcessSize;

                        processListTextBox.AppendText("进程" + process.processNo + " 申请" + rdProcessSize + "K\r\n"); 

                        if (!isRdAction) if (freeMemInRd < memSize * 0.3) isRdAction = true;
                    }
                    else
                    {
                        //从可释放的进程中随机选择一个进程进行释放操作
                        int rdReleaseProcess = rd.Next(0, rdCreatedProcess.Count);

                        Process process = processes[rdCreatedProcess[rdReleaseProcess] - 1];
                        ProcessAction processAction = new ProcessAction(process, rdAction);

                        //添加进调度进程列表，从可释放进程列表中剔除，更新选择调出进程列表栏信息，更新（随机创建状态下）剩余内存容量
                        processList.Add(processAction);
                        rdCreatedProcess.RemoveAt(rdReleaseProcess);
                        chooseReleaseNoListBox.Items.Remove(process.processNo);
                        freeMemInRd += process.size;

                        processListTextBox.AppendText("进程" + process.processNo + " 释放\r\n");
                    }
                }
            }
            else
            {
                MessageBox.Show("需要填入3~30之间的数字", "提示");
                getRandomNumTextBox.Text = string.Empty;
            }
        }

        //添加一个调入进程
        private void AddProcessButton_Click(object sender, EventArgs e)
        {
            //检查数据规范性
            if (string.IsNullOrEmpty(getPSizeTextBox.Text)) MessageBox.Show("数据未填写", "提示");
            else if (int.TryParse(getPSizeTextBox.Text, out int getProcessSize) && getProcessSize >= 25 * memSize / 1000 && getProcessSize <= 300)
            {
                //检查是否已到调度列表规模上限
                if (processList.Count < maxProcessListSize)
                {
                    //创建一个调入进程并添加进调度列表，更新选择调释放进程列表栏信息
                    Process process = new Process(nextProcessNoInCreate, getProcessSize);
                    ProcessAction processAction = new ProcessAction(process, true);
                    processes.Add(process);
                    processList.Add(processAction);
                    chooseReleaseNoListBox.Items.Add(nextProcessNoInCreate);

                    nextProcessNoInCreate++;
                    processListTextBox.AppendText("进程" + process.processNo + " 申请" + getProcessSize + "K\r\n");

                }
                else MessageBox.Show("进程列表已满(30)", "提示");
            }
            else MessageBox.Show("需要填入" + (25 * memSize / 1000) + "~300之间的数字", "提示");
            getPSizeTextBox.Text = string.Empty;
        }

        //选择一个要释放的进程
        private void ReleaseProcessButton_Click(object sender, EventArgs e)
        {
            //检查是否已选择
            if (chooseReleaseNoListBox.SelectedItem != null)
            {
                //检查是否已到调度列表规模上限
                if (processList.Count < maxProcessListSize)
                {
                    //从选择调出进程列表栏中选取到要释放的进程，添加进调度列表，更新选择调出进程列表栏信息
                    int chooseNo = (int) chooseReleaseNoListBox.SelectedItem;
                    Process process = processes[chooseNo - 1];
                    ProcessAction processAction = new ProcessAction(process, false);
                    processList.Add(processAction);
                    chooseReleaseNoListBox.Items.Remove(chooseNo);

                    processListTextBox.AppendText("进程" + chooseNo + " 释放\r\n");
                }
                else MessageBox.Show("进程列表已满(30)", "提示");
            }
            else MessageBox.Show("未选择任何进程", "提示");
        }

        private void FFAlgorithmcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FFAlgorithmcheckBox.Checked)
            {
                algorithm = true;
                BFAlgorithmCheckBox.Checked = false;
            }
            else BFAlgorithmCheckBox.Checked = true;
        }

        private void BFAlgorithmCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BFAlgorithmCheckBox.Checked)
            {
                algorithm = false;
                FFAlgorithmcheckBox.Checked = false;
            }
            else FFAlgorithmcheckBox.Checked = true;
        }

        private void AutoRunButton_Click(object sender, EventArgs e)
        {
            AutoRun();
        }

        private void RunOneStepButton_Click(object sender, EventArgs e)
        {
            RunOneStep();
        }

        private void ClearProcessListButton_Click(object sender, EventArgs e)
        {
            ClearProcessList();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void clearMessageBoxButton_Click(object sender, EventArgs e)
        {
            messageTextBox.Clear();
        }

        private void SetButton(bool set)
        {
            createRandomListButton.Enabled = set;
            addProcessButton.Enabled = set;
            releaseProcessButton.Enabled = set;
            runOneStepButton.Enabled = set;
            autoRunButton.Enabled = set;
            resetButton.Enabled = set;
            clearProcessListButton.Enabled = set;
            clearMessageBoxButton.Enabled = set;
            FFAlgorithmcheckBox.Enabled = set;
            BFAlgorithmCheckBox.Enabled = set;
        }

        private static int maxProcessListSize = 30;
        private static int memUISize = 1000;                                    //UI界面内存大小
        private readonly int memSize = 1000;                                    //内存总容量
        private int freeMem;                                                    //内存剩余容量
        private int falseNum = 0;                                               //存储调度时调入进程失败次数
        private int nextProcessNo = 1;                                          //下一个调入进程的编号
        private int nextProcessNoInCreate = 1;                                  //编辑列表时创建下一个调入进程的编号
        private bool algorithm = true;                                          //算法的选择，true为FF，False为BF
        private List<Process> processes = new List<Process>();                  //已创建进程的列表
        private List<ProcessAction> processList = new List<ProcessAction>();    //进程调度队列
        private FreeMemList freeMemList;                                        //内存空闲区表
        private UsedMemList usedMemList;                                        //内存占用区表

    }







    //进程类
    public class Process
    {
        public Process(int no, int s)
        {
            processNo = no;
            size = s;
        }
        public int processNo;
        public int size;
        public int processStarting = -1;
        public TextBox memBlock;
    }

    //进程及其行为类
    public class ProcessAction
    {
        public ProcessAction(Process p, bool o)
        {
            process = p;
            op = o;
        }
        public Process process;
        public bool op;
    }



    //内存空闲区表类
    public class FreeMemList
    {
        public FreeMemList(MemBlock fst)
        {
            first = fst;
        }



        public MemBlock first;
    }

    //内存占用区表类
    public class UsedMemList
    {
        public UsedMemList()
        {

        }

        public MemBlock first;
    }

    //内存块类
    public class MemBlock
    {
        public MemBlock(int st, int bs)
        {
            starting = st;
            blockSize = bs;
        }

        public MemBlock next;
        public MemBlock last;
        public int starting;
        public int blockSize;
    }
}
