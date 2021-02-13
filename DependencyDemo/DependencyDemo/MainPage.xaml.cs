using DependencyDemo.Dependecy;

using System;

using Xamarin.Forms;

namespace DependencyDemo {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e) {

            IPlatformMessage service = DependencyService.Get<IPlatformMessage>();
            string message = service.getMessage();
            DisplayAlert("DependeencyService", message, "OK");
        }
    }
}
