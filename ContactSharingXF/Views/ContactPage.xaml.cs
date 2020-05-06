using ContactSharingXF.ViewModels;
using Xamarin.Forms;

namespace ContactSharingXF.Views
{
    public partial class ContactPage : ContentPage
    {
        public ContactPage()
        {
            InitializeComponent();
            BindingContext = new ContactPageViewModel();
        }
    }
}
