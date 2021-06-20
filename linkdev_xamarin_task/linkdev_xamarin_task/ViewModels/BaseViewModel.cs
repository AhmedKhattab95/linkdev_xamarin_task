using linkdev_xamarin_task.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace linkdev_xamarin_task.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public BaseViewModel()
        {
            MessagingCenter.Subscribe<BaseView, Views.Size>(this, "sizeChanged", _sizeChanged);
        }

        private void _sizeChanged(BaseView arg1, Views.Size arg2)
        {
            if (arg2 != null)
            {
               // Size = arg2;
                ImageSize = arg2.Height /2.5;
            }
        }

        //represents device size (height, width)
        double _imageSize;
        public double ImageSize
        {
            get { return _imageSize; }
            set { SetProperty(ref _imageSize, value); }
        }

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

     
        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName] string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region network connection

        private bool _connected = true;
        public bool Connected
        {
            get => _connected;
            set
            {
                SetProperty(ref _connected, value);
            }
        } 
        #endregion
        
        #region Empty Data Visability connection

        private bool _hasData = false;
        public bool HasData
        {
            get => _hasData;
            set
            {
                SetProperty(ref _hasData, value);
            }
        }
        #endregion


        #region visibility of main content if Connected and hasData

        private bool _ShowMainUI;
        public bool ShowMainUI
        {
            get => Connected && !HasData;
            set
            {
                SetProperty(ref _ShowMainUI, value);
            }
        }
        #endregion

    }
}
