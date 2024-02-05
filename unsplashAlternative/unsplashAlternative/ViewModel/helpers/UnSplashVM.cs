﻿using System;
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
using unsplashAlternative.ViewModel.converters;

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
            Images = await unSplashHelper.ImageApi(query, 1);
        }

        public event PropertyChangedEventHandler? PropertyChanged;
		private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
    }
}
