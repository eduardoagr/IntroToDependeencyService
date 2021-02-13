using DependencyDemo.Dependecy;
using DependencyDemo.iOS.DependencyServices;

using Xamarin.Forms;
[assembly: Dependency(typeof(IOSMessage))]

namespace DependencyDemo.iOS.DependencyServices {
    public class IOSMessage : IPlatformMessage {
        public string getMessage() {
            return "I am in IOS";
        }
    }
}