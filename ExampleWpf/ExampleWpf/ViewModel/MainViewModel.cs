using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ExampleWpf.ViewModel
{
    public class MainViewModel : NotifyBase
    {
        
        public MainViewModel()
        {
            _submitCommand = new RelayCommand(_ => MessageBox.Show("Success"));
        }

        private ICommand _submitCommand;

        public ICommand SubmitCommand
        {
            get => _submitCommand;
            set => _submitCommand = value;
        }

        private string _userName;

        public string UserName
        {
            get => _userName;
            set => SetProperty(ref _userName, value);
        }

        private string _apiKey;
        
        public string ApiKey
        {
            get => _apiKey;
            set => SetProperty(ref _apiKey, value);
        }
    }
}
