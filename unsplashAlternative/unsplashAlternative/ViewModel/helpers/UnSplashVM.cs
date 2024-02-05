using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using unsplashAlternative.Model;
using System.Windows.Media.Imaging;
using unsplashAlternative.ViewModel.commands;

namespace unsplashAlternative.ViewModel.helpers
{
    public class UnSplashVM : INotifyPropertyChanged
    {
		private unSplashImage images;

		public unSplashImage Images
		{
			get { return images; }
			set 
            {
                images = value;
                OnPropertyChanged(nameof(Images));
            }
		}

        private string? query;
        public string Query
        {
            get { return query; }
            set
            {
                query = value;
                OnPropertyChanged(nameof(Query));
            }
        }

        private int pager;
        public int Pager
        {
            get { return pager; }
            set
            {
                pager = value;
                OnPropertyChanged(nameof(Pager));
            }
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

        private ICommand _searchDown;

        public ICommand SearchDown
        {
            get
            {
                if (_searchDown == null)
                {
                    _searchDown = new PagerDownSearch(this);
                }
                return _searchDown;
            }
        }

        private ICommand _searchUp;

        public ICommand SearchUp
        {
            get
            {
                if (_searchUp == null)
                {
                    _searchUp = new PagerUpSearch(this);
                }
                return _searchUp;
            }
        }

        public string lastQuery { get; private set; }

        public async void MakeQuery()
        {
            lastQuery = query;
            Pager = 1;
            Images = await unSplashHelper.ImageApi(query, Pager);
            await Console.Out.WriteLineAsync();
        }

        public async void MakeQueryDown()
        {
            Pager -= 1;
            Images = await unSplashHelper.ImageApi(lastQuery, Pager);
        }

        public async void MakeQueryUp()
        {
            Pager += 1;
            Images = await unSplashHelper.ImageApi(lastQuery, Pager);
        }

        public event PropertyChangedEventHandler? PropertyChanged;
		private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
    }
}
