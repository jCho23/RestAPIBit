using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RestAPIBit
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            GetPostMessages();


		}

        private async void GetPostMessages()
        {
            HttpClient client = new HttpClient();

            var response = await client.GetStringAsync("http://lionapp.azurewebsites.net/api/PostTexts");

            var postMessages= JsonConvert.DeserializeObject<List<PostMessage>>(response);
            PostMessageListView.ItemSource = postMessages;
        }
	}
}
