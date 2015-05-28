using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DependencyApp.WinPhone;
using Xamarin.Forms;

[assembly: Dependency(typeof(TipoDevice))]


namespace DependencyApp.WinPhone
{
    public class TipoDevice : ITipoDevice
    {
        public string GetTipoDevice()
        {
            return "WinPhone";
        }

    }
}
