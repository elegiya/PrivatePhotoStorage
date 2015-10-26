using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XLabs.Platform.Services.Media;

namespace PrivatePhotoStorage.ViewModels
{
    /// <summary>
    /// 
    /// </summary>
    public class StorageViewModel : BaseViewModel
    {
        private readonly IMediaPicker _mediaPicker;
        private string _photos;

        public StorageViewModel()
        {
            _mediaPicker = DependencyService.Get<IMediaPicker>();
            Images = new ObservableCollection<Image>();

            this.AddPhotoCommand = new Command(AddImages);
        }

        public ObservableCollection<Image> Images { get; set; }

        public ICommand AddPhotoCommand { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string Photos
        {
            get { return _photos; }
            set { SetProperty(ref _photos, value); }
        }

        public async void AddImages()
        {
            await _mediaPicker.SelectPhotoAsync(new CameraMediaStorageOptions()).ContinueWith(t =>
            {
                if (t.IsCanceled)
                {
                    return;
                }
                var file = t.Result;
            });
        }


//        if (_mediaPicker.IsCameraAvailable)
//            {
//                {
//                    await _mediaPicker.TakePhotoAsync(new CameraMediaStorageOptions()).ContinueWith(t =>
//                    {
//            if (t.IsCanceled)
//            {
//                return;
//            }
//            var file = t.Result;
//        });
//                }
//}
//            else
//            {
//                {
//                    await _mediaPicker.SelectPhotoAsync(new CameraMediaStorageOptions()).ContinueWith(t =>
//                    {
//    if (t.IsCanceled)
//    {
//        return;
//    }
//    var file = t.Result;
//});
//                }
//            }
        //return Task.Run(async () =>
        //{
        //    await Task.Delay(1000);
        //    for (var i = 0; i < 5; i++)
        //    {
        //        Images.Add("http://www.stockvault.net/data/2011/05/31/124348/small.jpg");
        //    }
        //});
    }
}
