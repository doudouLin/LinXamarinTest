using Xamarin.Forms;
using LinXamarinTest.ViewModel;
using System;

namespace LinXamarinTest.View
{
    public partial class About : ContentPage
	{
		public async void OnCall(object sender, EventArgs e)
		{
			if (await this.DisplayAlert("Dial a number", "Would you like to call Lin?", "Yes", "No"))
			{
				var dialer = DependencyService.Get<IDialer>();

				if (dialer != null)
					dialer.Dial("+41794350697");
			}
		}

		public About ()
		{
			InitializeComponent();
			//BindingContext = App.Locator.About;
		}
    }
}
