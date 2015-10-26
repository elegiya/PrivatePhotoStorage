using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XLabs.Data;

namespace PrivatePhotoStorage.Models
{
   // [Table("Photos")]
    public class Photos : ObservableObject
    {
        private string _name;
        private string _path;

        /// <summary>
        /// Gets or sets photo Id.
        /// </summary>
     //   [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets photo name.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        /// <summary>
        /// Gets or sets path to get a photo.
        /// </summary>
        public string Path
        {
            get { return _path; }
            set { SetProperty(ref _path, value); }
        }
    }
}
