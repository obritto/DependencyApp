using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

using DependencyApp.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(TipoDevice))]

namespace DependencyApp.iOS
{
    public class TipoDevice : ITipoDevice
    {
        public string GetTipoDevice()
        {
            return "iOS";
        }

    }
}