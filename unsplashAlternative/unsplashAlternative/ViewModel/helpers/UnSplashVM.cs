using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using unsplashAlternative.Model;
using unsplashAlternative.ViewModel.commands;
using unsplashAlternative.ViewModel.converters;

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
            unSplashImage[] images = await unSplashHelper.ImageApi("laptop", 1);
            LinkToImage linkToImage = new LinkToImage();
            var valami2 = linkToImage.linkToImage(images[0].links.download);
            var valami = 1;
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
