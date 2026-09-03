using Microsoft.Win32;
using System;
using System.Collections.Generic;
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
using RevitAutoAddin;

namespace RevitAutoAddin.Pages
{
    /// <summary>
    /// SetPage.xaml 的交互逻辑
    /// </summary>
    public partial class SetPage : Page
    {
        public string _typeName;
        
        public SetPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 点击“浏览”按钮，弹出文件选择对话框
        /// </summary>
        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            // 1. 创建 OpenFileDialog 实例
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // 2. 设置对话框属性（根据需求定制）
            openFileDialog.Title = "请选择一个文件";
            openFileDialog.Filter = "项目文件|*.dll";  // 你可以改为特定类型，如 "文本文件|*.txt"
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.RestoreDirectory = true;

            // 3. 显示对话框并判断结果
            if (openFileDialog.ShowDialog() == true)
            {
                // 将选中的文件路径显示在文本框中
                FilePathTextBox.Text = openFileDialog.FileName;
                string[] strings = openFileDialog.FileName.Split("\\");
                string[] result = strings[strings.Length-1].Split(".dll");
                ProgramNameTextBox.Text = result[0];
            }
        }

        private void TypeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            // sender 就是用户刚刚点击的那个 RadioButton
            RadioButton selectedRb = sender as RadioButton;
            if (selectedRb != null)
            {
                // 获取显示文本
                string selectedContent = selectedRb.Content.ToString();
                _typeName = selectedContent;
            }
        }
    }
}
