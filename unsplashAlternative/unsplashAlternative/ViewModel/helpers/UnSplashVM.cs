using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Imaging;
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
            unSplashImage[] images = await unSplashHelper.ImageApi("Laptop", 1);
            BitmapImage ImageBitmap = LinkToImage.linkToImage(images[0].urls.full);
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

        private BitmapImage imageBitmap;

        public BitmapImage ImageBitmap
        {
            get { return imageBitmap; }
            set { imageBitmap = value; }
        }




        public event PropertyChangedEventHandler? PropertyChanged;

		private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
    }
}
