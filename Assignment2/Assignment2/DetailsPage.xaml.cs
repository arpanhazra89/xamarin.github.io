using System;
using System.Collections.Generic;
using Assignment2.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
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
