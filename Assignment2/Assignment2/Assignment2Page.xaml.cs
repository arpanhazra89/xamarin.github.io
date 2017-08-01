using Xamarin.Forms;
using System.Net.Http;
using Assignment2.Model;
using Newtonsoft.Json;

namespace Assignment2
{
    public partial class Assignment2Page : ContentPage
    {
        
        public Assignment2Page()
        {
            InitializeComponent();
            GetDataFromJSON();
        }

        public async void GetDataFromJSON()
        {
            var client = new HttpClient();
            var response = await client.GetAsync("http://www.mocky.io/v2/59806aef1100000f0b1cf9c8");
            string json = response.Content.ReadAsStringAsync().Result;

            ContactList  ObjContactList = new ContactList();

            if(json != "")
            {
                //Converting JSON Array Objects into generic list
                ObjContactList = JsonConvert.DeserializeObject<ContactList>(json);
			}
            listviewConacts.ItemsSource = ObjContactList.contacts;

        }

        private void listviewContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            
			var itemSelectedData = e.SelectedItem as Contact;
            Navigation.PushAsync(new DetailsPage(itemSelectedData));
        }
    }
}
