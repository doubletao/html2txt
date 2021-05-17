using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace html2txt
{
    public partial class html2txt : Form
    {
        public html2txt()
        {
            InitializeComponent();
        }

        private void findRsmFile(string dirPath, ref List<string> fileList)
        {
            DirectoryInfo drInfo = new DirectoryInfo(dirPath);
            //获取当前目录下所有以*.RSM结尾的文件，并添加至fileList 
            FileInfo[] fi = drInfo.GetFiles();
            foreach (FileInfo f in fi)
            {
                if (f.Extension == ".html" || f.Extension == ".htm")
                {
                    fileList.Add(f.FullName);
                }
            }
            //获取当前目录下所有子文件夹
            DirectoryInfo[] subDr = drInfo.GetDirectories();
            //遍历所有子文件夹
            foreach (DirectoryInfo subDir in drInfo.GetDirectories())
            {
                string subFile = subDir.FullName + @"\";
                //递归
                findRsmFile(subFile, ref fileList);
            }
        }

        private void btnSrcPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBoxSrcPath.Text = dialog.SelectedPath;
                List<string> lstFileList = new List<string>();
                findRsmFile(textBoxSrcPath.Text, ref lstFileList);
                foreach (string file in lstFileList)
                {
                    textBoxSrcFileList.AppendText(file);
                    textBoxSrcFileList.AppendText("\r\n");
                }
            }
        }

        private void btnDesPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBoxDesPath.Text = dialog.SelectedPath;
            }
        }

        private void btnStartProcess_Click(object sender, EventArgs e)
        {
            foreach (string file in textBoxSrcFileList.Lines)
            {
                try
                {
                    StreamReader sr = new StreamReader(file, Encoding.UTF8);
                    string strContent = sr.ReadToEnd();
                    html2txthelper helper = new html2txthelper();
                    string strFinal = helper.Convert(strContent);
                    StreamWriter sw = new StreamWriter(textBoxDesPath.Text + "/" + Path.GetFileNameWithoutExtension(file) + ".txt", false, Encoding.UTF8);
                    sw.Write(strFinal);
                    sw.Flush();
                    sw.Close();
                }
                catch (Exception)
                { }
            }
        }
    }
}
