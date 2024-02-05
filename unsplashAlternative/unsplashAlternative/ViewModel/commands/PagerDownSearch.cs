using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using unsplashAlternative.ViewModel.helpers;

namespace unsplashAlternative.ViewModel.commands
{
    public class PagerDownSearch : ICommand
    {
        event EventHandler? ICommand.CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public UnSplashVM? VM
        {
            get; set;
        }

        public PagerDownSearch(UnSplashVM vm)
        {
            VM = vm;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            if (string.IsNullOrWhiteSpace(VM.lastQuery))
            {
                return false;
            }
            if (VM.Pager < 2)
            {
                return false;
            }
            return true;
        }

        public void Execute(object? parameter)
        {
            VM.MakeQueryDown();
        }
    }
}
