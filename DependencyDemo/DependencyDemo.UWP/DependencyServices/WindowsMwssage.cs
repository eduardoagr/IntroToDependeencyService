using DependencyDemo.Dependecy;
using DependencyDemo.UWP.DependencyServices;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

[assembly: Dependency(typeof(WindowsMwssage))]

namespace DependencyDemo.UWP.DependencyServices {
    public class WindowsMwssage : IPlatformMessage {
        public string getMessage() {
            return "I am on Windows";
        }
    }
}
