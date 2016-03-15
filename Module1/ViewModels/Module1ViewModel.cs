using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Module1.ViewModels
{
    public class Module1ViewModel : BindableBase
    {
        public DelegateCommand<TouchEventArgs> MaCommand { get; set; }

        private string result;
        public string Result
        {
            get { return result; }
            set { SetProperty(ref result, value); }
        }

        private string titreModule;
        public string TitreModule
        {
            get { return titreModule; }
            set { SetProperty(ref titreModule, value); }
        }

        public Module1ViewModel()
        {
            TitreModule = "Module1";
            MaCommand = new DelegateCommand<TouchEventArgs>(mafonction);
        }

        private void mafonction(TouchEventArgs obj)
        {
            Result += 1;
        }
    }
}
