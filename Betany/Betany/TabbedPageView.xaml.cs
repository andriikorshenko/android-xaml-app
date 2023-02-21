using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Betany
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPageView : TabbedPage
    {
        public TabbedPageView()
        {
            InitializeComponent();
        }
    }
}