using Xamarin.Essentials;
using Xamarin.Forms;

namespace XF_LaunchingApps.Views
{
    public partial class LaunchingPage : ContentPage
    {
        public LaunchingPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            //開外部網站(誤會了)
            string uri = "https://docs.microsoft.com/zh-tw/xamarin/xamarin-forms/";
            if (await Launcher.CanOpenAsync(uri))
            {
                await Launcher.OpenAsync(uri);
            }
            //var supportsUri = await Launcher.CanOpenAsync("lyft://");
            //if (supportsUri)

        }
    }
}
