using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Betany.Helpers
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePageView : ContentPage
	{
		public HomePageView()
		{
			InitializeComponent();

		    //this.Navigation.PopAsync();
		    //this.Navigation.PopToRootAsync();
		}
	}
}