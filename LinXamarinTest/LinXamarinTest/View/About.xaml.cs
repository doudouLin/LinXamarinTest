using Xamarin.Forms;

namespace LinXamarinTest.View
{
    public partial class About : ContentPage
	{
		public About ()
		{
			InitializeComponent ();
            //AboutLabel.Text = param + " called me!";
		}

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            var btn = (Button)sender;

            btn.Text = "set text!";
        }
    }
}
