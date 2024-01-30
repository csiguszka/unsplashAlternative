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

        private BitmapImage[] bitMapImages;

        public BitmapImage[] BitmapImages
        {
            get { return bitMapImages; }
            set { bitMapImages = value;} 
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

        public async void MakeQuery()
        {
            Images = await unSplashHelper.ImageApi("laptop", 1);
            ConvertImages();
            images[0].urls.full = images[0].urls.full.Replace("&", "amp;");
        }

        private void ConvertImages()
        {
            BitmapImages = new BitmapImage[Images.Length];
            for (int i = 0; i < Images.Length; i++)
            {
                BitmapImages[i] = LinkToImage.linkToImage(Images[i].urls.full);
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
		private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
    }
}
