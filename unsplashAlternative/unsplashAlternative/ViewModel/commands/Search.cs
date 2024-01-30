using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using unsplashAlternative.ViewModel.helpers;


namespace unsplashAlternative.ViewModel.commands
{
    public class Search : ICommand
    {
        public UnSplashVM? VM
        {
            get; set;
        }

        public Search(UnSplashVM vm)
        {
            VM = vm;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            VM.MakeQuery();
        }
    }
}
