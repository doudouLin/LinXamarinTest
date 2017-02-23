using LinXamarinTest.Models;
using LinXamarinTest.View;
using LinXamarinTest.ViewModel;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace LinXamarinTest.View
{
    public partial class HomePage : ContentPage
	{
        public int ClickCount;

        public HomePage ()
		{
			InitializeComponent ();
            BindingContext = App.Locator.Home;
        }

        //protected async override void OnAppearing()
        //{
        //    base.OnAppearing();

        //    ListItems.ItemsSource = await App.TodoManager.GetTasksAsync();
        //}

        private async void LstPanda_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem == null)
            {
                return;
            }

            var cm = (CountryModel)e.SelectedItem;

            await Navigation.PushAsync(new Detail(cm));
        }
        
    }
}
