using System;
using Xamarin.Forms;
namespace Assignment1
{
    public class MyClass : Application
    {
        public MyClass()
        {
            MainPage = new NavigationPage( new Page1()) {Title = "Navigation Stack"};
        }
    }
}
