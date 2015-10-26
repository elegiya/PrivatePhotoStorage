using System.ComponentModel;
using System.Runtime.CompilerServices;
using XLabs.Data;

namespace PrivatePhotoStorage.ViewModels
{
    /// <summary>
    /// Base ViewModel to implememnt MVVM.
    /// </summary>
    public class BaseViewModel : ObservableObject
    {
        /// <summary>
        /// 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
