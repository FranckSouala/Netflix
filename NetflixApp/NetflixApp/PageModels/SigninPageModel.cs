using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace NetflixApp.PageModels
{
    internal class SigninPageModel : BasePageModel
    {
        public SigninPageModel()
        {
            IsPassword = true;
            IsPasswordCommand = new Command(() =>
            {
                IsPassword = !IsPassword;
            });
        }

        private bool _isPassword;
        public bool IsPassword
        {
            get { return _isPassword; }
            set => SetProperty(ref _isPassword, value);
        }

        public ICommand IsPasswordCommand { get; }
    }
}

