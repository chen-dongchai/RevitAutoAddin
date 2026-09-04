using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RevitAutoAddin.Pages;
using Wpf.Ui.Controls;

namespace RevitAutoAddin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : FluentWindow
    {
        private SetPage _setPage;
        private ViewPage _viewPage;
        public MainWindow()
        {
            InitializeComponent();
            SetPage setPage = new SetPage();
            ViewPage viewPage = new ViewPage();
            _setPage = setPage;
            _viewPage = viewPage; 

        }

        private void SetButton_Click(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(_setPage);
        }

        private void ViewButton_Click(object sender, RoutedEventArgs e)
        {
            Function function = new Function(_setPage._typeName,_setPage.FilePathTextBox.Text,_setPage.GUIDTextBox.Text,_setPage.ProgramNameTextBox.Text,_setPage.ClassNameTextBox.Text);
            _viewPage.ViewBox.Text = function.ResultGenerate();
            contentFrame.Navigate(_viewPage);
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // 如果鼠标双击，让窗口最大化/还原
            if (e.ClickCount == 2)
            {
                if (this.WindowState == WindowState.Normal)
                    this.WindowState = WindowState.Maximized;
                else
                    this.WindowState = WindowState.Normal;
                return;
            }

            // 单次点击并按住，则拖动窗口
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
    }
}