using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using DependencyApp.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(TipoDevice))]

namespace DependencyApp.Droid
{
    public class TipoDevice : ITipoDevice
    {
        public string GetTipoDevice()
        {
            return "ANDROID";
        }

    }
}