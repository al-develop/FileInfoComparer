using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DevExpress.Mvvm;

namespace FileInfoComparer
{
    public class MainWindowViewModel : ViewModelBase
    {
        public Func<string> SelectRightRootAction { get; set; }
        public Func<string> SelectLeftRootAction { get; set; }


        #region Properties
        private ObservableCollection<FileInfo> _rightFiles;
        private ObservableCollection<FileInfo> _leftFiles;
        private FileInfo _rightSelection;
        private FileInfo _leftSelection;
        private string _rightRoot;
        private string _leftRoot;

        public string LeftRoot
        {
            get { return _leftRoot; }
            set { SetProperty(ref _leftRoot, value, () => LeftRoot); }
        }
        public string RightRoot
        {
            get { return _rightRoot; }
            set { SetProperty(ref _rightRoot, value, () => RightRoot); }
        }
        public FileInfo LeftSelection
        {
            get { return _leftSelection; }
            set { SetProperty(ref _leftSelection, value, () => LeftSelection); }
        }
        public FileInfo RightSelection
        {
            get { return _rightSelection; }
            set { SetProperty(ref _rightSelection, value, () => RightSelection); }
        }
        public ObservableCollection<FileInfo> LeftFiles
        {
            get { return _leftFiles; }
            set { SetProperty(ref _leftFiles, value, () => LeftFiles); }
        }
        public ObservableCollection<FileInfo> RightFiles
        {
            get { return _rightFiles; }
            set { SetProperty(ref _rightFiles, value, () => RightFiles); }
        }
        #endregion

        public MainWindowViewModel()
        {
            LeftFiles = new ObservableCollection<FileInfo>();
            RightFiles = new ObservableCollection<FileInfo>();
            SelectRightRootCommand = new DelegateCommand(SelectRightRoot);
            SelectLeftRootCommand = new DelegateCommand(SelectLeftRoot);
        }

        public ICommand SelectRightRootCommand { get; set; }
        public ICommand SelectLeftRootCommand { get; set; }

        private void SelectLeftRoot()
        {
            this.LeftRoot = SelectLeftRootAction.Invoke();
            if (String.IsNullOrEmpty(LeftRoot))
                return;

            string[] files = Directory.GetFiles(LeftRoot);
            foreach (var file in files)
            {
                FileInfo info = new FileInfo(file);
                this.LeftFiles.Add(info);
            }
        }

        private void SelectRightRoot()
        {
            this.RightRoot = SelectRightRootAction.Invoke();
            if (String.IsNullOrEmpty(RightRoot))
                return;

            string[] files = Directory.GetFiles(RightRoot);
            foreach (var file in files)
            {
                FileInfo info = new FileInfo(file);
                this.RightFiles.Add(info);
            }
        }
    }
}