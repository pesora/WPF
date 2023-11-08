using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfStudy.ViewModels;

namespace WpfStudy
{
    class TestClickCommand : ICommand
    {
        private MainViewModel _mainViewModel;
        private bool rtnCan = true;
        public event EventHandler CanExecuteChanged;

        public TestClickCommand(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return rtnCan;
        }

        public void Execute(object parameter)
        {
            MessageBox.Show(_mainViewModel.ProgressValue+"");
        }
    }
}
