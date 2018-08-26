using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using System.Diagnostics;

namespace FYT_Winform_SecretProject
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        /*--------------------------------属性和数据---------------------------------*/
        #region 属性和数据
        string iCloudPath = @"C:\Users\yutan\iCloudDrive\Documents\FYT\MTeam-TP";                                        //种子保存路径
        string handleTorrentPath = @"C:\Users\yutan\Downloads\FYT\HandleTorrent";                                         //处理种子临时路径
        string downloadPath = @"C:\Users\yutan\Downloads\FYT";                                                                        //RAR文件下载路径

        DataBindingClass dataBindingClass;                                //存放绑定数据
   
        public uint uiGetTorrentNum
        {
            get;
            set;
        }
        
        #endregion


        /*-------------------------------主窗口构造函数----------------------------*/
        #region 主窗口构造函数和加载响应函数
        /// <summary>
        /// 主窗口构造函数
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            //数据初始化
            dataBindingClass = new DataBindingClass();

            //设置各个panel父容器
            panel_1.Parent = container_Main;
            panel_2.Parent = container_Main;
            panel_3.Parent = container_Main;
            panel_4.Parent = container_Main;

            //设置控件父容器
            //For Debug
            label1.Parent = panel_1;
            label2.Parent = panel_2;
            label3.Parent = panel_3;
            label4.Parent = panel_4;

            //panel_1
            btn_ChooseiCloudPath.Parent = panel_1;
            btn_ClassifyClassicTorrents.Parent = panel_1;
            btn_ClassifyCommonTorrents.Parent = panel_1;


            //panel_2
            btn_ChooseCommonTorrents.Parent = panel_2;
            btn_ChooseClassicTorrents.Parent = panel_2;
            numericUpDown_GetTorrentsCount.Parent = panel_2;
            btn_SetHandleTempPath.Parent = panel_2;

            //panel_3
            btn_GetDownloadLinks.Parent = panel_3;

            //panel_4
            label_Text.Parent = panel_4;
            label_RARFilesCount.Parent = panel_4;

            //数据绑定
            uiGetTorrentNum = 20;
            numericUpDown_GetTorrentsCount.DataBindings.Add("Value", this, "uiGetTorrentNum");

            dataBindingClass.uiRARFilesNum = UpdateRARFilesNum(downloadPath);              //更新已下载RAR文件数
            label_RARFilesCount.DataBindings.Add("Text", dataBindingClass, "uiRARFilesNum");

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //设置默认加载可见性
            panel_1.Visible = true;
            panel_2.Visible = false;
            panel_3.Visible = false;
            panel_4.Visible = false;
        }
        #endregion


        /*-----------------------------控件事件处理程序-------------------------------*/
        #region 控件事件处理程序
        private void listItem_ClassifyTorrentsFiles_Click(object sender, EventArgs e)
        {
            panel_1.Visible = true;
            panel_2.Visible = false;
            panel_3.Visible = false;
            panel_4.Visible = false;
        }

        private void listItem_ChooseTorrents_Click(object sender, EventArgs e)
        {
            panel_1.Visible = false;
            panel_2.Visible = true;
            panel_3.Visible = false;
            panel_4.Visible = false;
        }

        private void listItem_GetDownloadLinks_Click(object sender, EventArgs e)
        {
            panel_1.Visible = false;
            panel_2.Visible = false;
            panel_3.Visible = true;
            panel_4.Visible = false;
        }

        private void listItem_DecompressFiles_Click(object sender, EventArgs e)
        {
            dataBindingClass.uiRARFilesNum = UpdateRARFilesNum(downloadPath);

            panel_1.Visible = false;
            panel_2.Visible = false;
            panel_3.Visible = false;
            panel_4.Visible = true;
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(UpdateRARFilesNum(downloadPath).ToString());
        }

        private void btn_ChooseiCloudPath_Click(object sender, EventArgs e)
        {
            //打开路径选择框选择iCloud的目录路径
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            var result=folderDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                iCloudPath = folderDialog.SelectedPath;
            }

        }
        /// <summary>
        /// 按钮点击响应程序：分类普通种子文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ClassifyCommonTorrents_Click(object sender, EventArgs e)
        {
            MoveTorrents(@"C:\Users\yutan\Downloads", Path.Combine(iCloudPath, "Torrents"));
            MessageBox.Show("Complete","Result");
        }
        /// <summary>
        /// 按钮点击响应程序：分类经典种子文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ClassifyClassicTorrents_Click(object sender, EventArgs e)
        {
            MoveTorrents(@"C:\Users\yutan\Downloads", Path.Combine(iCloudPath, "Torrents","Classic"));
            MessageBox.Show("Complete", "Result");
        }
        /// <summary>
        /// 设置临时处理种子的目录路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SetHandleTempPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            var result = folderDialog.ShowDialog();
            if(result==DialogResult.OK)
            {
                handleTorrentPath = folderDialog.SelectedPath;
            }
        }
        /// <summary>
        /// 按钮点击响应程序：提取普通种子文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ChooseCommonTorrents_Click(object sender, EventArgs e)
        {
            GetTorrentsFromiCloud(Path.Combine(iCloudPath, "Torrents"), handleTorrentPath, uiGetTorrentNum);
            MessageBox.Show("Complete","Result");
        }
        /// <summary>
        /// 按钮点击响应事件：提取经典种子文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ChooseClassicTorrents_Click(object sender, EventArgs e)
        {
            GetTorrentsFromiCloud(Path.Combine(iCloudPath, "Torrents","Classic"), handleTorrentPath, uiGetTorrentNum);
            MessageBox.Show("Complete", "Result");
        }
        /// <summary>
        /// 按钮点击响应处理程序：提取下载地址，删除rar种子文件，将已经提取地址的txt种子文件移动到iCloud
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_GetDownloadLinks_Click(object sender, EventArgs e)
        {
            //string rarExePath = GetWinRarpath();
            Decompress(handleTorrentPath);                //将种子文件解压到当前目录
            DeleteRARFiles(handleTorrentPath);             //删除当前目录下的rar文件
            string outputFilePath=GetDownloadLinks(handleTorrentPath);       //提取所有下载地址
            MoveCompletedTorrents(handleTorrentPath, Path.Combine(iCloudPath, "Complete"));

            //打开记事本
            System.Diagnostics.Process.Start("notepad.exe", outputFilePath);
        }

        /// <summary>
        /// 选择提取种子数量控件数值改变事件响应程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDown_GetTorrentsCount_ValueChanged(object sender, EventArgs e)
        {

        }

        #endregion


        /*-------------------------自定义函数-----------------------------*/
        #region 自定义函数

        /// <summary>
        /// 根据文件创建时间进行排序
        /// </summary>
        private static IEnumerable<FileTimeInfo> GetFileList(string folderPath,uint count)
        {
            List<FileTimeInfo> list = new List<FileTimeInfo>();
            DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);
            var allFiles = directoryInfo.GetFiles();
            var files = from x in allFiles
                        where x.Extension == ".rar"
                        select x;

            foreach (var file in files)
            {
                list.Add(new FileTimeInfo(file.FullName, file.CreationTime));
            }

            var orderedList = from x in list
                              orderby x.FileCreateTime
                              select x;

            return orderedList.Reverse<FileTimeInfo>().Take((int)count);
        }

        /// <summary>
        /// 从iCloud提取特定数量的种子文件到目标路径
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="count"></param>
        private void GetTorrentsFromiCloud(string filePath,string destPath,uint count)
        {
            txb_TorrentsToDownload.Clear();
            var files = GetFileList(filePath,count);
            foreach(var file in files)
            {
                File.Move(file.FileName, Path.Combine(destPath, Path.GetFileName(file.FileName)));
                txb_TorrentsToDownload.AppendText(Path.GetFileName(file.FileName) + "\n");
            }
        }

        /// <summary>
        /// 获取winRAR执行路径
        /// </summary>
        /// <returns></returns>
        private static string GetWinRarpath()
        {
            RegistryKey regKey;
            try
            {
                regKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\WinRAR.exe");
            }
            catch
            {
                MessageBox.Show("Fail to access winRAR's RegistryPath");
                return "Error";
            }
            string strKey = regKey.GetValue("").ToString();
            regKey.Close();

            return strKey;
        }

        /// <summary>
        /// 解压缩指定文件夹下的所有压缩文件
        /// </summary>
        /// <param name="folderPath">源文件夹路径</param>
        /// <param name="destPath">目标文件夹路径，为空则与源文件夹路径相同</param>
        private static void Decompress(string folderPath, string destPath = "DefaultPath")
        {
            //如果传入目标路径为空，则目标路径与源路径相同
            if (destPath == "DefaultPath")
                destPath = folderPath;

            //获取winRAR执行路径
            string rarPath = GetWinRarpath();

            if (rarPath == "Error")
                return;

            string strShellArg;

            strShellArg = string.Format($" e -o+ {Path.Combine(folderPath, "*.rar")} {destPath} *.txt");

            using (Process process = new Process())
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = rarPath;
                startInfo.Arguments = strShellArg;
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;

                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();

                process.Close();
                Console.WriteLine("Complete!!");
            }

        }

        /// <summary>
        /// 删除指定目录下的所有rar文件和特定的文本文件
        /// </summary>
        /// <param name="folderPath"></param>
        private static void DeleteRARFiles(string folderPath)
        {
            var fileList = Directory.EnumerateFiles(folderPath);
            foreach (var fileName in fileList)
            {
                if (Path.GetExtension(fileName) == ".rar")
                    File.Delete(fileName);
            }
            File.Delete(Path.Combine(folderPath, "解壓密碼.txt"));
        }

        /// <summary>
        /// 从指定目录下的所有文本文件中提取特定行的地址
        /// </summary>
        /// <param name="DirectoryPath"></param>
        private static string GetDownloadLinks(string DirectoryPath)
        {
            String[] Files = Directory.GetFiles(DirectoryPath);
            //输出文件路径
            string OutputFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Result.txt");
            //输出文件流
            FileStream ResultFileStream = new FileStream(OutputFilePath, FileMode.Create, FileAccess.Write);
            //输出文件流写入器
            StreamWriter ResultWriter = new StreamWriter(ResultFileStream);

            uint cResultLine = 0;

            foreach (var FilePath in Files)
            {
                using (var ReadFileStream = File.OpenRead(FilePath))
                {
                    StreamReader SourceReader = new StreamReader(ReadFileStream);
                    for (int iLine = 1; iLine < 16; ++iLine)
                    {
                        string Temp = SourceReader.ReadLine();
                        if (iLine == 15)
                        {
                            ResultWriter.WriteLine(Temp);
                            if ((++cResultLine) % 15 == 0)
                                ResultWriter.WriteLine();
                        }
                    }
                }
            }
            ResultWriter.Flush();
            ResultWriter.Close();

            return OutputFilePath;
        }

        /// <summary>
        /// 移动文件
        /// </summary>
        /// <param name="folderPath"></param>
        /// <param name="destPath"></param>
        private void MoveTorrents(string folderPath, string destPath = @"C:\Users\yutan\iCloudDrive\Documents\FYT\MTeam-TP\Complete")
        {
            txb_ClassifyFileName.Clear();               //清空当前文本框内容
            // var fileNameList = Directory.EnumerateFiles(folderPath);
            var fileNameList = from x in Directory.EnumerateFiles(folderPath)
                               where Path.GetExtension(x) == ".rar"
                               select x;

            try
            {
                foreach (var fileName in fileNameList)
                {
                    File.Move(fileName, Path.Combine(destPath, Path.GetFileName(fileName)));
                    txb_ClassifyFileName.AppendText(Path.GetFileName(fileName) + "\n");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// 移动已经提取下载地址的文件
        /// </summary>
        /// <param name="folderPath"></param>
        /// <param name="destPath"></param>
        private void MoveCompletedTorrents(string folderPath,string destPath)
        {
            var fileNameList = Directory.EnumerateFiles(folderPath);
            try
            {
                foreach (var fileName in fileNameList)
                {
                    File.Move(fileName, Path.Combine(destPath, Path.GetFileName(fileName)));
                }
            }
            catch (IOException e)
            {
                MessageBox.Show("Error : " + e.Message);
            }
        }
        
        
        /// <summary>
        /// 计算已经完成的RAR文件数
        /// </summary>
        /// <param name="path"></param>
        private static uint UpdateRARFilesNum(string path)
        {
            var allFiles = Directory.GetFiles(path);
            var rarFiles = from x in allFiles
                           where Path.GetExtension(x) == ".rar"
                           select x;

            return (uint)rarFiles.Count();
        }

        #endregion

        /*--------------------------自定义类--------------------------*/
        #region 自定义类
        /// <summary>
        /// 用于根据文件创建时间排序函数
        /// </summary>
        private class FileTimeInfo
        {
            public string FileName;
            public DateTime FileCreateTime;

            public FileTimeInfo(string fileName, DateTime fileCreateTime)
            {
                FileName = fileName;
                FileCreateTime = fileCreateTime;
            }
        }


        private class DataBindingClass:INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;

            private uint _uiRARFilesNum;
            public uint uiRARFilesNum
            {
                get
                {
                    return _uiRARFilesNum;
                }
                set
                {
                    _uiRARFilesNum = value;

                    
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("uiRARFilesNum"));
                }
            }
        }




        #endregion

        /// <summary>
        /// 打开iCloud文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", iCloudPath);
        }
        /// <summary>
        /// 打开种子临时处理路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", handleTorrentPath);
        }
        /// <summary>
        /// 打开RAR文件路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", downloadPath);
        }
    }
}
