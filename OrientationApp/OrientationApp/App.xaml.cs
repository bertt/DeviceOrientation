using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace OrientationApp
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            var content = new ContentPage
            {
                Title = "BertView",
                Content = new BertView() { Name="bert111"}
            };

            MainPage = new NavigationPage(content);
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
