using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
[assembly: ExportFont("CeraPro-Light.ttf", Alias ="CeraProRegular")]
[assembly: ExportFont("CeraPro-Bold.ttf", Alias = "CeraProBold")]
namespace BloomKitchenomics
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.FromHex("#FFFFFF"),
                BarTextColor = Color.FromHex("#8dbd07"),
            }; 
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
