using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RevitAutoAddin.Pages
{
    /// <summary>
    /// ViewPage.xaml 的交互逻辑
    /// </summary>
    public partial class ViewPage : Page
    {
        public ViewPage()
        {
            InitializeComponent();
        }

        private void ExportButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog.Title = "请选择保存路径";
            saveFileDialog.Filter = "Addin文件(*.addin)|*.addin";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.DefaultExt = "addin";
            saveFileDialog.FileName = "RevitAutoAddin";
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog()==true)
            {
                string filePath = saveFileDialog.FileName;
                try
                {
                    string contentTosave = ViewBox.Text;
                    File.WriteAllText(filePath, contentTosave, Encoding.UTF8);
                    MessageBox.Show($"文件已成功保存至：\n{filePath}", "成功");
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"保存文件时出错：{ex.Message}", "错误");
                }
            }

        }
    }
}
