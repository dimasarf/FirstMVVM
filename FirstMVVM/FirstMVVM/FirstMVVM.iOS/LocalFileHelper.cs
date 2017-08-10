using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using FirstMVVM.Services;
using System.IO;

namespace FirstMVVM.iOS
{
    public class LocalFileHelper : ILocalFileHelper
    {
        public string GetLocalPath(string FileName)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");
            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }
            return Path.Combine(libFolder, FileName);
        }
    }
}