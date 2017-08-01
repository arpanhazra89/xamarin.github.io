using System;
using Xamarin.Forms;
namespace Assignment1
{
    public class Page1 : ContentPage
    {
        public Page1()
        {
            var buttonNext = new Button { Text = "Next Page" };
            buttonNext.Clicked += OnNextPageButtonClicked;
            Title = "First Page";
            Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Children = 
                {
                    new Label { 
                        Text = "Welcome to Xamarin!", 
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        HorizontalOptions = LayoutOptions.FillAndExpand
                    }
                    , buttonNext
                }
            };
        }
        async void OnNextPageButtonClicked (object sender, EventArgs e)
        {
			var contact = new Contact
			{
				Name = "Jane Doe",
				Age = "30",
				Occupation = "Developer",
				Country = "USA"
			};

            var secondPage = new Page2(contact);
            secondPage.BindingContext = contact;
            await Navigation.PushAsync(new Page2(contact));
        }
    }
}
