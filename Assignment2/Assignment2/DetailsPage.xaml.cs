using Assignment2.Model;
using Xamarin.Forms;

namespace Assignment2
{
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage(Contact selectedItem)
        {
            InitializeComponent();
            GridDetails.BindingContext = selectedItem;
        }
    }
}
