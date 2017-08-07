using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FileInfoComparer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowViewModel vm;
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = vm = new MainWindowViewModel();
            vm.SelectLeftRootAction = new Func<string>(SelectLeftRoot);
            vm.SelectRightRootAction = new Func<string>(SelectRightRoot);

        }

        private string SelectRightRoot()
        {
            return CallDialog();
        }

        private string SelectLeftRoot()
        {
            return CallDialog();
        }

        private string CallDialog()
        {
            var dialog = new Ookii.Dialogs.Wpf.VistaFolderBrowserDialog();
            if (dialog.ShowDialog() == true)
                return dialog.SelectedPath;

            return "";
        }

        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            var info = new InfoWindow();
            info.Show();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}