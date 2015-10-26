using PrivatePhotoStorage.Models;
using PrivatePhotoStorage.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PrivatePhotoStorage.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new StorageViewModel();
            //this.StackLayout.BindingContext = new Photos();
        }
    }
}
