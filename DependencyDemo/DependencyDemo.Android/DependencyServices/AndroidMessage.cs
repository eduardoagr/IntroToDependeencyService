
using DependencyDemo.Dependecy;
using DependencyDemo.Droid.DependencyServices;
using Xamarin.Forms;

[assembly: Dependency(typeof(AndroidMessage))]

namespace DependencyDemo.Droid.DependencyServices {
    public class AndroidMessage : IPlatformMessage {
        public string getMessage() {

            return "I am on Android";
        }
    }
}