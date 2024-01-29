using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using unsplashAlternative.ViewModel.commands;

namespace unsplashAlternative.ViewModel.helpers
{
    public class UnSplashVM : INotifyPropertyChanged
    {
		private unSplashImage[] images;

		public unSplashImage[] Images
		{
			get { return images; }
			set { OnPropertyChanged(nameof(Images)); }
		}

        public async void MakeQuery()
        {
            unSplashImage[] images = await unSplashHelper.ImageApi("", 1);
        }

        private ICommand _searchCommand;

        public ICommand SearchCommand
        {
            get
            {
                if (_searchCommand == null)
                {
                    _searchCommand = new Search(this);
                }
                return _searchCommand;
            }
        }



        public event PropertyChangedEventHandler? PropertyChanged;

		private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
    }
}
