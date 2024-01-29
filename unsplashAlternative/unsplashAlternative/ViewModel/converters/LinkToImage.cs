using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows;

namespace unsplashAlternative.ViewModel.converters
{
    public class LinkToImage
    {
        public BitmapImage linkToImage(string imageUrl)
        {
            using (WebClient webClient = new WebClient())
            {
                byte[] data = webClient.DownloadData(new Uri(imageUrl));
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = new System.IO.MemoryStream(data);
                bitmapImage.EndInit();

                return bitmapImage;
            }
        }
    }
}
