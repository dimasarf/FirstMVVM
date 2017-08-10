using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using FirstMVVM.Droid;
using FirstMVVM.Services;

[assembly: Dependency(typeof(LocalFileHelper))]
namespace FirstMVVM.Droid
{
   
    public class LocalFileHelper : ILocalFileHelper
    {
        public string GetLocalPath(string FileName)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(path, FileName);
        }
    }
}